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
        
        foreach (var context in schemas.Where(x => x.IsReference))
        {
            context.ResolvedReference = componentSchemas[context.ReferenceId!];
            context.Id = context.ResolvedReference.Id;
            context.TypeData = context.ResolvedReference.TypeData;
            
            context.ResolvedReference.Links.Add(context);
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
        
        // Find all tags used in operations besides the ones defined in the document
        var allTags = openApiDocument.Tags!;
        foreach (var operation in openApiDocument.Paths!
                     .SelectMany(x => x.Value.Operations)
                     .Select(x => x.Value))
        {
            foreach (var tag in operation.Tags ?? Array.Empty<OpenApiTagReference>())
            {
                var existingTag = allTags.FirstOrDefault(x => x.Name == tag.Name);
                if (existingTag is null)
                {
                    allTags.Add(tag);
                }
            }
        }
        
        if (settings.GroupByTags && allTags.Count < 2)
        {
            settings = settings with
            {
                GroupByTags = false,
            };
        }

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

        var operations = openApiDocument.GetOperations(settings, globalSettings, filteredSchemas);
        ModelNameGenerator.ResolveCollisions(operations);
        
        var filteredOperations = settings.GenerateSdk || settings.GenerateMethods
                ? operations
                    .Where(operation =>
                    {
                        if (settings.ExcludeDeprecatedOperations &&
                            operation.Operation.Deprecated)
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
            .Select(EndPoint.FromSchema)
            .ToImmutableArray();

        foreach (var group in methods
                     .GroupBy(x => x.Tag)
                     .Where(x => !x.AreKeysUnique(y => y.CliAction)))
        {
            Console.WriteLine($"Found duplicate CLI action names in '{group.Key.SingularizedName}': {string.Join(", ", group.Select(x => x.CliAction))}");
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
                        .Where(y => y.Hint is Hint.AnyOf or Hint.OneOf or Hint.AllOf)
                        .Select(y => y.TypeData.CSharpTypeWithNullabilityForValueTypes))}>"))
            // Unix Timestamp converter
            .Concat([
                $"global::{globalSettings.Namespace}.JsonConverters.UnixTimestampJsonConverter",
            ])
            .ToImmutableArray();
        
        var includedTags = allTags
            .Where(x =>
                (settings.IncludeTags.Length == 0 ||
                 settings.IncludeTags.Contains(x.Name)) &&
                !settings.ExcludeTags.Contains(x.Name))
            .ToArray();
        Client[] clients = settings.GenerateSdk || settings.GenerateConstructors ? [new Client(
                Id: "MainConstructor",
                ClassName: settings.ClassName.Replace(".", string.Empty),
                BaseUrl: openApiDocument.Servers!.FirstOrDefault()?.Url ?? string.Empty,
                Clients: settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors)
                    ? [
                        .. includedTags.Select(tag => PropertyData.Default with
                        {
                            Name = ClientNameGenerator.GeneratePropertyName(settings, tag),
                            Type = TypeData.Default with
                            {
                                CSharpTypeRaw = ClientNameGenerator.Generate(settings, tag),
                            },
                            Summary = tag.Description?.ClearForXml() ?? string.Empty,
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
                includedTags
                    .Select(tag => new Client(
                        Id: "Constructors",
                        ClassName: ClientNameGenerator.Generate(settings, tag),
                        BaseUrl: openApiDocument.Servers!.FirstOrDefault()?.Url ?? string.Empty,
                        Clients: [],
                        Summary: tag.Description?.ClearForXml() ?? string.Empty,
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
            Tags: includedTags.Select(x => Tag.FromTag(x, settings)).ToImmutableArray(),
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
}
