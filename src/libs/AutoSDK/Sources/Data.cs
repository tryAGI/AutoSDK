using System.Collections.Immutable;
using System.Diagnostics;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Clients;
using AutoSDK.Naming.Models;
using AutoSDK.Serialization.Json;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static class Data
{
    public static Models.Data Prepare(
        ((string Text, Settings Settings) Context, Settings GlobalSettings) tuple,
        CancellationToken cancellationToken = default)
    {
        var totalTime = Stopwatch.StartNew();
        var traversalTreeTime = Stopwatch.StartNew();
        
        var ((text, settings), globalSettings) = tuple;

        // Detect spec format and delegate to AsyncAPI pipeline if needed
        if (SpecFormatDetector.DetectFormat(text) == SpecFormat.AsyncApi)
        {
            return AsyncApiData.Prepare(tuple, cancellationToken);
        }

        var openApiDocument = text.GetOpenApiDocument(settings, cancellationToken);

        var schemas = openApiDocument.GetSchemas(settings);
        
        traversalTreeTime.Stop();
        
        var namingTime = Stopwatch.StartNew();

        foreach (var schema in schemas.Where(x => x.IsModel))
        {
            _ = ModelNameGenerator.ComputeId(schema);
        }

        ModelNameGenerator.ResolveCollisions(schemas);
        
        namingTime.Stop();
        
        var resolveReferencesTime = Stopwatch.StartNew();
        
        var componentSchemas = schemas
            .Where(x => x.IsComponent)
            .ToDictionary(x => x.ComponentId!, x => x);
        
        var unresolvedReferences = new HashSet<SchemaContext>();
        foreach (var context in schemas.Where(x => x.IsReference).ToArray())
        {
            if (componentSchemas.TryGetValue(context.ReferenceId!, out var resolvedReference))
            {
                context.ResolvedReference = resolvedReference;
                context.Id = context.ResolvedReference.Id;
                context.TypeData = context.ResolvedReference.TypeData;

                context.ResolvedReference.Links.Add(context);
            }
            else if (!settings.IgnoreOpenApiErrors)
            {
                throw new KeyNotFoundException($"Schema reference '{context.ReferenceId}' could not be resolved. " +
                    $"This may indicate a malformed OpenAPI specification (e.g., using #/definitions/ in an OpenAPI 3.x spec).");
            }
            else
            {
                // Mark unresolved references for removal
                unresolvedReferences.Add(context);
            }
        }

        // Filter out unresolved references
        if (unresolvedReferences.Count > 0)
        {
            DetachUnresolvedReferences(schemas, unresolvedReferences);
            schemas = schemas.Where(x => !unresolvedReferences.Contains(x)).ToArray();
        }

        resolveReferencesTime.Stop();
        
        var filteringTime = Stopwatch.StartNew();

        var includedOperationIds = new HashSet<string>(settings.IncludeOperationIds);
        var excludedOperationIds = new HashSet<string>(settings.ExcludeOperationIds);
        foreach (var tag in settings.IncludeTags)
        {
            includedOperationIds.UnionWith(openApiDocument.FindAllOperationIdsForTag(tag));
        }
        foreach (var tag in settings.ExcludeTags)
        {
            excludedOperationIds.UnionWith(openApiDocument.FindAllOperationIdsForTag(tag));
        }
        
        // Find all tags used in operations besides the ones defined in the document.
        // Also collect ad-hoc group names from x-fern-sdk-group-name extensions in a single pass.
        var allTags = openApiDocument.Tags!;
        var knownTagNames = new HashSet<string>(
            allTags.Where(x => x.Name != null).Select(x => x.Name!));
        foreach (var operation in (openApiDocument.Paths ?? new OpenApiPaths())
                     .SelectMany(x => x.Value.Operations ?? new Dictionary<System.Net.Http.HttpMethod, OpenApiOperation>())
                     .Select(x => x.Value))
        {
            foreach (var tag in operation.Tags ?? new HashSet<OpenApiTagReference>())
            {
                if (tag.Name != null && knownTagNames.Add(tag.Name))
                {
                    // In OpenAPI 3.0+, Tags collection contains OpenApiTag, but operation.Tags contains OpenApiTagReference
                    // Create a new OpenApiTag from the reference
                    allTags.Add(new OpenApiTag { Name = tag.Name, Description = tag.Description });
                }
            }

            // x-fern-sdk-group-name creates new tags that need sub-client classes, just like regular tags.
            if (settings.UseExtensionNaming &&
                OpenApiExtensions.TryGetExtensionStringValue(
                    operation.Extensions, "x-fern-sdk-group-name", out var groupName) &&
                !string.IsNullOrWhiteSpace(groupName) &&
                knownTagNames.Add(groupName))
            {
                allTags.Add(new OpenApiTag { Name = groupName });
            }
        }

        if (settings.GroupByTags && allTags.Count < 2)
        {
            settings = settings with
            {
                GroupByTags = false,
            };
        }

        var resolvedTags = ClientNameGenerator.ResolveTags(settings, allTags);

        var maxDepth = schemas.Count == 0
            ? 20
            : schemas.Max(x => x.Depth);
        foreach (var context in schemas.Where(x => x.Operation != null))
        {
            context.ComputeTags(maxDepth: maxDepth);
        }
        foreach (var context in schemas)
        {
            context.ComputeTags(maxDepth: maxDepth);
        }
        
        var includedModels = new HashSet<string>(settings.IncludeModels);
        var excludedModels = new HashSet<string>(settings.ExcludeModels);
        
        var isFilteringRequired = settings.IncludeTags.Length > 0 ||
                                  settings.ExcludeTags.Length > 0 ||
                                  includedModels.Count > 0 ||
                                  excludedModels.Count > 0 ||
                                  !settings.GenerateModels;
        var filteredSchemas = isFilteringRequired
            ? schemas
                .Where(x =>
                    (settings.GenerateModels ||
                     settings.GenerateSdk ||
                     (x.Operation?.OperationId != null && includedOperationIds.Contains(x.Operation.OperationId))) &&
                    (settings.IncludeTags.Length == 0 ||
                     x.HasAnyTag(settings.IncludeTags.ToArray())) &&
                    !x.HasAnyTag(settings.ExcludeTags.ToArray()) &&
                    (!x.IsComponent && includedModels.Count == 0 ||
                     (includedModels.Count == 0 ||
                      includedModels.Contains(x.ComponentId!)) &&
                    !excludedModels.Contains(x.ComponentId!)))
                .SelectMany(x => x.WithAllChildren())
                .Distinct()
                .ToArray()
            : schemas;
        filteredSchemas = filteredSchemas
            .Where(x => !x.HasAllOfTypeForMetadata())
            .ToArray();
        
        filteringTime.Stop();
        
        var computeDataTime = Stopwatch.StartNew();

        foreach (var schema in filteredSchemas)
        {
            schema.ComputeData();
        }

        // Second pass: recompute only schemas involved in circular references.
        // After the first pass all TypeData is set, so cyclic schemas now
        // produce their final results with complete data. O(k) where k is
        // the number of unmemoized schemas (~10% for specs with circular refs).
        foreach (var schema in filteredSchemas)
        {
            schema.RecomputeDataIfNeeded();
        }

        computeDataTime.Stop();
        
        var computeDataClassesTime = Stopwatch.StartNew();
        
        var classes = filteredSchemas
            .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: false })
            .Select(x => x.ClassData)
            .Where(x => x is not null)
            .Select(x => x!.Value)
            .ToImmutableArray();
        var enums = filteredSchemas
            .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: false })
            .Select(x => x.EnumData)
            .Where(x => x is not null)
            .Select(x => x!.Value)
            .ToImmutableArray();
        var anyOfDatas = filteredSchemas
            .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: true })
            .Select(x => x.AnyOfData)
            .Where(x => x is not null)
            .Select(x => x!.Value)
            .Distinct()
            .ToImmutableArray();

        var operations = openApiDocument.GetOperations(settings, globalSettings, filteredSchemas, resolvedTags);
        ModelNameGenerator.ResolveCollisions(operations);
        
        var filteredOperations = settings.GenerateSdk || settings.GenerateMethods
                ? operations
                    .Where(operation =>
                    {
                        if (settings.ExcludeDeprecatedOperations &&
                            operation.Operation.IsDeprecated())
                        {
                            return false;
                        }
                        if (includedOperationIds.Count == 0 && excludedOperationIds.Count == 0)
                        {
                            return true;
                        }
                    
                        return (includedOperationIds.Count == 0 ||
                                includedOperationIds.Contains(operation.MethodName) ||
                                (operation.Operation.OperationId != null && includedOperationIds.Contains(operation.Operation.OperationId))) &&
                               !excludedOperationIds.Contains(operation.MethodName) &&
                               (operation.Operation.OperationId == null || !excludedOperationIds.Contains(operation.Operation.OperationId));
                    })
                    .ToArray()
                : [];
        
        var methods = filteredOperations
            .SelectMany(CreateEndPoints)
            .OrderBy(m => m.Tag.SafeName, StringComparer.Ordinal)
            .ThenBy(m => m.NotAsyncMethodName, StringComparer.Ordinal)
            .ToImmutableArray();

        if (settings.GenerateCli)
        {
            foreach (var group in methods
                         .GroupBy(x => x.Tag)
                         .Where(x => !x.AreKeysUnique(y => y.CliAction)))
            {
                Console.WriteLine($"Found duplicate CLI action names in '{group.Key.SingularizedName}': {string.Join(", ", group.Select(x => x.CliAction))}");
            }
        }
        
        var authorizations = openApiDocument.Security!
            .SelectMany(requirement => requirement)
            .Select(x => Authorization.FromOpenApiSecurityScheme(x.Key, settings, globalSettings))
            .ToArray();

        var converters =
            // Enum converters
            enums
                .Where(x =>
                    x.Style == ModelStyle.Enumeration &&
                    x.Settings.JsonSerializerType != JsonSerializerType.NewtonsoftJson)
                .SelectMany(x => new[]
                {
                    $"global::{settings.Namespace}.JsonConverters.{x.ClassName}JsonConverter",
                    $"global::{settings.Namespace}.JsonConverters.{x.ClassName}NullableJsonConverter"
                })
            // Named AnyOf converters
            .Concat(anyOfDatas
                .Where(x =>
                    x.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
                    !string.IsNullOrWhiteSpace(x.Name))
                .Select(x => $"global::{settings.Namespace}.JsonConverters.{x.Name}JsonConverter"))
            // Generic AnyOf converters
            .Concat(filteredSchemas
                .Where(x =>
                    x.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
                    x.AnyOfData.HasValue &&
                    string.IsNullOrWhiteSpace(x.AnyOfData.Value.Name))
                .Select(x => $"global::{settings.Namespace}.JsonConverters.{x.AnyOfData?.SubType}JsonConverter<{
                    string.Join(", ", x.Children
                        .Where(y => y.Hint == (x.IsAnyOf ? Hint.AnyOf : x.IsOneOf ? Hint.OneOf : Hint.AllOf))
                        .Select(y => y.TypeData.CSharpTypeWithNullabilityForValueTypes))}>"))
            // Unix Timestamp converter
            .Concat([
                $"global::{globalSettings.Namespace}.JsonConverters.UnixTimestampJsonConverter",
            ])
            .ToImmutableArray();
        
        var includedTags = allTags
            .Where(x =>
                x.Name != null &&
                (settings.IncludeTags.Length == 0 ||
                 settings.IncludeTags.Contains(x.Name)) &&
                !settings.ExcludeTags.Contains(x.Name))
            .ToArray();
        var resolvedIncludedTags = includedTags
            .Select(tag => resolvedTags.TryGetValue(tag.Name ?? string.Empty, out var resolvedTag)
                ? resolvedTag
                : Tag.FromTag(tag, settings))
            .ToArray();

        // Filter tags to only those that actually have methods assigned.
        // x-fern-sdk-group-name can reassign operations away from their original tags,
        // leaving some tags with no methods. We exclude those to avoid generating
        // empty sub-clients or orphaned CLI group commands.
        var tagsWithMethods = new HashSet<string>(
            methods.Select(m => m.Tag.SafeName));
        resolvedIncludedTags = resolvedIncludedTags
            .Where(tag => tagsWithMethods.Contains(tag.SafeName))
            .OrderBy(tag => tag.SafeName, StringComparer.Ordinal)
            .ToArray();
        Client[] clients = settings.GenerateSdk || settings.GenerateConstructors ? [new Client(
                Id: "MainConstructor",
                ClassName: settings.ClassName.Replace(".", string.Empty),
                BaseUrl: openApiDocument.Servers!.FirstOrDefault()?.Url ?? string.Empty,
                Clients: settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors)
                    ? [
                        .. resolvedIncludedTags.Select(tag => PropertyData.Default with
                        {
                            Name = tag.SafeName,
                            Type = TypeData.Default with
                            {
                                CSharpTypeRaw = ClientNameGenerator.Generate(tag),
                            },
                            Summary = (!string.IsNullOrWhiteSpace(tag.DisplayName) ? tag.DisplayName : tag.Description)?.ClearForXml() ?? string.Empty,
                        })
                    ]
                    : [],
                Summary: openApiDocument.Info?.Description?.ClearForXml() ?? string.Empty,
                BaseUrlSummary: openApiDocument.Servers!.FirstOrDefault()?.Description?.ClearForXml() ?? string.Empty,
                Settings: settings,
                GlobalSettings: globalSettings,
                Converters: converters)] : [];
        if (settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors))
        {
            clients = clients.Concat(
                resolvedIncludedTags
                    .Select(tag => new Client(
                        Id: "Constructors",
                        ClassName: ClientNameGenerator.Generate(tag),
                        BaseUrl: openApiDocument.Servers!.FirstOrDefault()?.Url ?? string.Empty,
                        Clients: [],
                        Summary: (!string.IsNullOrWhiteSpace(tag.DisplayName) ? tag.DisplayName : tag.Description)?.ClearForXml() ?? string.Empty,
                        BaseUrlSummary: openApiDocument.Servers!.FirstOrDefault()?.Description?.ClearForXml() ?? string.Empty,
                        Settings: settings,
                        GlobalSettings: globalSettings,
                        Converters: [])))
                .ToArray();
        }
        
        var types =
            settings.GenerateJsonSerializerContextTypes
                ? filteredSchemas
                    .Where(x =>
                        x.TypeData != TypeData.Default &&
                        !string.IsNullOrWhiteSpace(x.TypeData.CSharpType))
                    .Select(x => x.TypeData)
                    .GroupBy(x => x.CSharpTypeWithNullability)
                    .Select(x => x.First())
                    .ToImmutableArray()
                : [];
        
        classes = classes
            .Select(x => x with
            {
                SchemaContext = default!,
            })
            .ToImmutableArray();
        enums = enums
            .Select(x => x with
            {
                SchemaContext = default!,
            })
            .ToImmutableArray();
        
        return new Models.Data(
            Classes: classes,
            Enums: enums,
            Methods: methods,
            Clients: clients.ToImmutableArray(),
            AnyOfs: anyOfDatas,
            Types: types,
            Authorizations: settings.GenerateSdk || settings.GenerateConstructors
                ? authorizations.ToImmutableArray()
                : [],
            Tags: resolvedIncludedTags.ToImmutableArray(),
            Converters: new Client(
                Id: "Converters",
                ClassName: string.Empty,
                BaseUrl: string.Empty,
                Summary: string.Empty,
                Clients: [],
                BaseUrlSummary: string.Empty,
                Settings: settings,
                GlobalSettings: globalSettings,
                Converters: converters),
            Schemas: schemas,
            FilteredSchemas: filteredSchemas,
            Times: new Times(
                TraversalTree: traversalTreeTime.Elapsed,
                Naming: namingTime.Elapsed,
                ResolveReferences: resolveReferencesTime.Elapsed,
                Filtering: filteringTime.Elapsed,
                ComputeData: computeDataTime.Elapsed,
                ComputeDataClasses: computeDataClassesTime.Elapsed,
                Total: totalTime.Elapsed
                )
            );
    }

    private static IEnumerable<EndPoint> CreateEndPoints(OperationContext operation)
    {
        var responseContentTypes = (operation.Operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            .SelectMany(response => (response.Value?.Content ?? new Dictionary<string, IOpenApiMediaType>())
                .Where(_ => response.Key.StartsWith("2", StringComparison.OrdinalIgnoreCase))
                .Select(content => content.Key))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToArray();

        var hasJson = responseContentTypes.Any(static contentType =>
            contentType.Contains("application/json", StringComparison.OrdinalIgnoreCase));
        var hasNdjson = responseContentTypes.Any(static contentType =>
            contentType.Contains("application/x-ndjson", StringComparison.OrdinalIgnoreCase));
        var hasSse = responseContentTypes.Any(static contentType =>
            contentType.Contains("text/event-stream", StringComparison.OrdinalIgnoreCase));

        var endPoints = new List<EndPoint>();

        if (hasJson)
        {
            endPoints.Add(EndPoint.FromSchema(
                operation,
                preferredMimeType: "application/json",
                forcedRequestStreamValue: hasNdjson || hasSse ? false : null));
        }

        if (hasSse)
        {
            endPoints.Add(EndPoint.FromSchema(
                operation,
                preferredMimeType: "text/event-stream",
                methodNameSuffix: GetStreamMethodSuffix(
                    hasRegularJsonVariant: hasJson,
                    hasAnotherStreamingVariant: hasNdjson,
                    streamFormat: StreamFormat.ServerSentEvents),
                forcedRequestStreamValue: hasJson ? true : null));
        }

        if (hasNdjson)
        {
            endPoints.Add(EndPoint.FromSchema(
                operation,
                preferredMimeType: "application/x-ndjson",
                methodNameSuffix: GetStreamMethodSuffix(
                    hasRegularJsonVariant: hasJson,
                    hasAnotherStreamingVariant: hasSse,
                    streamFormat: StreamFormat.Ndjson),
                forcedRequestStreamValue: hasJson ? true : null));
        }

        if (endPoints.Count == 0)
        {
            endPoints.Add(EndPoint.FromSchema(operation));
        }

        return endPoints;
    }

    private static string? GetStreamMethodSuffix(
        bool hasRegularJsonVariant,
        bool hasAnotherStreamingVariant,
        StreamFormat streamFormat)
    {
        if (!hasRegularJsonVariant && !hasAnotherStreamingVariant)
        {
            return null;
        }

        if (!hasAnotherStreamingVariant)
        {
            return "AsStream";
        }

        return streamFormat switch
        {
            StreamFormat.ServerSentEvents => "AsServerSentEventsStream",
            StreamFormat.Ndjson => "AsNdjsonStream",
            _ => "AsStream",
        };
    }

    private static void DetachUnresolvedReferences(
        IReadOnlyCollection<SchemaContext> schemas,
        HashSet<SchemaContext> unresolvedReferences)
    {
        foreach (var schema in schemas)
        {
            if (schema.Children.Count == 0)
            {
                continue;
            }

            schema.Children = [..schema.Children.Where(x => !unresolvedReferences.Contains(x))];
        }
    }
}
