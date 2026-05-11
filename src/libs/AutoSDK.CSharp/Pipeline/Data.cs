using System.Collections.Immutable;
using System.Diagnostics;
using AutoSDK.Extensions;
using AutoSDK.Enrichment;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Clients;
using AutoSDK.Naming.Models;
using AutoSDK.Naming.Parameters;
using AutoSDK.Serialization.Json;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static class Data
{
    [ThreadStatic] private static System.Text.StringBuilder? s_converterBuilder;

    public static Models.Data Prepare(
        ((string Text, Settings Settings) Context, Settings GlobalSettings) tuple,
        CancellationToken cancellationToken = default)
    {
        return Prepare(
            (
                (tuple.Context.Text, (CSharpSettings)tuple.Context.Settings),
                (CSharpSettings)tuple.GlobalSettings
            ),
            cancellationToken);
    }

    public static Models.Data Prepare(
        ((string Text, CSharpSettings Settings) Context, CSharpSettings GlobalSettings) tuple,
        CancellationToken cancellationToken = default)
    {
        var totalTime = Stopwatch.StartNew();
#if NET
        var allocBefore = GC.GetTotalAllocatedBytes(precise: true);
#endif
        var parsingTime = Stopwatch.StartNew();

        var ((text, settings), globalSettings) = tuple;
        var csharpSettings = settings;
        var csharpGlobalSettings = globalSettings;

        // Detect spec format and delegate to AsyncAPI pipeline if needed
        if (SpecFormatDetector.DetectFormat(text) == SpecFormat.AsyncApi)
        {
            return AsyncApiData.Prepare(tuple, cancellationToken);
        }

        var openApiDocument = text.GetOpenApiDocument(csharpSettings.ToCoreSettings(), cancellationToken);

        parsingTime.Stop();
#if NET
        var allocAfterParsing = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var traversalTreeTime = Stopwatch.StartNew();

        var schemas = openApiDocument.GetSchemas(csharpSettings);

        traversalTreeTime.Stop();
#if NET
        var allocAfterTree = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var namingTime = Stopwatch.StartNew();

        for (var i = 0; i < schemas.Count; i++)
        {
            if (schemas[i].IsModel)
            {
                _ = ModelNameGenerator.ComputeId(schemas[i]);
            }
        }

        ModelNameGenerator.ResolveCollisions(schemas);
        
        namingTime.Stop();
#if NET
        var allocAfterNaming = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var resolveReferencesTime = Stopwatch.StartNew();
        
        var componentSchemas = new Dictionary<string, SchemaContext>();
        for (var i = 0; i < schemas.Count; i++)
        {
            if (schemas[i].ComponentId is string componentId)
            {
                componentSchemas[componentId] = schemas[i];
            }
        }

        var unresolvedReferences = new HashSet<SchemaContext>();
        for (var i = 0; i < schemas.Count; i++)
        {
            if (!schemas[i].IsReference)
            {
                continue;
            }
            var refSchema = schemas[i];
            if (componentSchemas.TryGetValue(refSchema.ReferenceId!, out var resolvedReference))
            {
                refSchema.ResolvedReference = resolvedReference;
                refSchema.Id = refSchema.ResolvedReference.Id;
                refSchema.TypeData = refSchema.ResolvedReference.TypeData;

                refSchema.ResolvedReference.Links.Add(refSchema);
            }
            else if (!settings.IgnoreOpenApiErrors)
            {
                throw new KeyNotFoundException($"Schema reference '{refSchema.ReferenceId}' could not be resolved. " +
                    $"This may indicate a malformed OpenAPI specification (e.g., using #/definitions/ in an OpenAPI 3.x spec).");
            }
            else
            {
                // Mark unresolved references for removal
                unresolvedReferences.Add(refSchema);
            }
        }

        // Filter out unresolved references
        if (unresolvedReferences.Count > 0)
        {
            DetachUnresolvedReferences(schemas, unresolvedReferences);
            var kept = new List<SchemaContext>(schemas.Count - unresolvedReferences.Count);
            for (var i = 0; i < schemas.Count; i++)
            {
                if (!unresolvedReferences.Contains(schemas[i]))
                {
                    kept.Add(schemas[i]);
                }
            }
            schemas = kept;
        }

        // Detect circular references so ComputeData can skip re-traversal
        // of cyclic subtrees during the first pass.
        DetectCycles(schemas);
        for (var i = 0; i < schemas.Count; i++)
        {
            schemas[i].ComponentSchemas = componentSchemas;
        }

        resolveReferencesTime.Stop();
#if NET
        var allocAfterResolve = GC.GetTotalAllocatedBytes(precise: true);
#endif

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
        // Also collect ad-hoc vendor group names that should materialize as sub-clients.
        var allTags = openApiDocument.Tags!;
        var knownTagNames = new HashSet<string>();
        foreach (var tag in allTags)
        {
            if (tag.Name != null)
            {
                knownTagNames.Add(tag.Name);
            }
        }
        var paths = openApiDocument.Paths ?? new OpenApiPaths();
        foreach (var pathEntry in paths)
        {
            var pathOps = pathEntry.Value.Operations;
            if (pathOps == null)
            {
                continue;
            }
            foreach (var opEntry in pathOps)
            {
                var operation = opEntry.Value;
                if (operation.Tags != null)
                {
                    foreach (var tag in operation.Tags)
                    {
                        if (tag.Name != null && knownTagNames.Add(tag.Name))
                        {
                            allTags.Add(new OpenApiTag
                            {
                                Name = tag.Name,
                                Description = tag.Description,
                                Summary = tag.Summary,
                                Parent = tag.Parent,
                                Kind = tag.Kind,
                            });
                        }
                    }
                }

                if (settings.UseExtensionNaming &&
                    OpenApiExtensions.TryGetOperationGroupNameOverride(operation.Extensions, out var groupName) &&
                    !string.IsNullOrWhiteSpace(groupName) &&
                    knownTagNames.Add(groupName))
                {
                    allTags.Add(new OpenApiTag { Name = groupName });
                }
            }
        }

        if (settings.GroupByTags && allTags.Count < 2)
        {
            settings = settings with
            {
                GroupByTags = false,
            };
            csharpSettings = settings;
        }

        var provisionalTags = CSharpClientNameGenerator.CreateProvisionalTags(csharpSettings, allTags);

        var maxDepth = 20;
        for (var i = 0; i < schemas.Count; i++)
        {
            if (schemas[i].Depth > maxDepth)
            {
                maxDepth = schemas[i].Depth;
            }
        }
#if NET
        var allocBeforeTags = GC.GetTotalAllocatedBytes(precise: true);
#endif
        var tagsVisited = new HashSet<SchemaContext>();
        for (var i = 0; i < schemas.Count; i++)
        {
            if (schemas[i].Operation != null)
            {
                tagsVisited.Clear();
                schemas[i].ComputeTags(maxDepth: maxDepth, visited: tagsVisited);
            }
        }
        for (var i = 0; i < schemas.Count; i++)
        {
            tagsVisited.Clear();
            schemas[i].ComputeTags(maxDepth: maxDepth, visited: tagsVisited);
        }
#if NET
        var allocAfterTags = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var includedModels = new HashSet<string>(settings.IncludeModels);
        var excludedModels = new HashSet<string>(settings.ExcludeModels);

        var hasTagFilters = settings.IncludeTags.Length > 0 || settings.ExcludeTags.Length > 0;
        var hasModelFilters = includedModels.Count > 0 || excludedModels.Count > 0;
        var skipModels = !settings.GenerateModels && !settings.GenerateSdk;
        var includeAllSchemas = (settings.GenerateModels || settings.GenerateSdk) &&
                                !hasTagFilters && !hasModelFilters;
        var includeOperationSchemas = settings.GenerateMethods ||
                                      settings.GenerateConstructors ||
                                      settings.GenerateCli ||
                                      includedOperationIds.Count > 0 ||
                                      excludedOperationIds.Count > 0 ||
                                      hasTagFilters ||
                                      settings.ExcludeDeprecatedOperations;

        IReadOnlyList<SchemaContext> filteredSchemas;
        if (includeAllSchemas)
        {
            // Fast path: all schemas pass the predicate, no expansion needed.
            // schemas already contains all children from TraversalTree.
            filteredSchemas = schemas;
        }
        else
        {
            // Selective filtering with child expansion
            var includeTagsArr = settings.IncludeTags.ToArray();
            var excludeTagsArr = settings.ExcludeTags.ToArray();
            var collected = new HashSet<SchemaContext>();
            bool CanExpandReference(SchemaContext resolvedReference)
            {
                if (!(hasModelFilters && resolvedReference.IsComponent))
                {
                    return true;
                }

                if (includedModels.Count > 0 && !includedModels.Contains(resolvedReference.ComponentId!))
                {
                    return false;
                }

                return !excludedModels.Contains(resolvedReference.ComponentId!);
            }
            for (var i = 0; i < schemas.Count; i++)
            {
                var x = schemas[i];
                var shouldIncludeSchema = settings.GenerateModels || settings.GenerateSdk;
                if (!shouldIncludeSchema)
                {
                    if (!includeOperationSchemas || x.Operation == null)
                    {
                        continue;
                    }

                    var operationId = x.Operation.OperationId;
                    if (settings.ExcludeDeprecatedOperations &&
                        x.Operation.IsDeprecated())
                    {
                        continue;
                    }

                    if (includedOperationIds.Count > 0 &&
                        (operationId == null || !includedOperationIds.Contains(operationId)))
                    {
                        continue;
                    }

                    if (operationId != null &&
                        excludedOperationIds.Contains(operationId))
                    {
                        continue;
                    }
                }
                if (!shouldIncludeSchema &&
                    x.ComponentId != null)
                {
                    continue;
                }
                if (includeTagsArr.Length > 0 && !x.HasAnyTag(includeTagsArr))
                {
                    continue;
                }
                if (excludeTagsArr.Length > 0 && x.HasAnyTag(excludeTagsArr))
                {
                    continue;
                }
                if (hasModelFilters && x.IsComponent)
                {
                    if (includedModels.Count > 0 && !includedModels.Contains(x.ComponentId!))
                    {
                        x.IsFilteredOutModel = true;
                        continue;
                    }
                    if (excludedModels.Contains(x.ComponentId!))
                    {
                        x.IsFilteredOutModel = true;
                        continue;
                    }
                }
                // Add this schema and all its children without intermediate List allocations
                x.CollectWithAllChildren(
                    collected,
                    hasModelFilters ? CanExpandReference : null);
            }
            if (skipModels)
            {
                foreach (var schema in collected)
                {
                    if (schema.IsComponent)
                    {
                        schema.IsFilteredOutModel = true;
                    }
                }
            }
            filteredSchemas = new List<SchemaContext>(collected);
        }

        // Remove metadata-only allOf/anyOf/oneOf wrappers (single item, no properties).
        // Use single-pass approach: collect non-metadata schemas directly.
        {
            var hasAny = false;
            for (var i = 0; i < filteredSchemas.Count; i++)
            {
                if (filteredSchemas[i].IsAllOfForMetadata)
                {
                    hasAny = true;
                    break;
                }
            }
            if (hasAny)
            {
                var filtered = new List<SchemaContext>(filteredSchemas.Count);
                for (var i = 0; i < filteredSchemas.Count; i++)
                {
                    if (!filteredSchemas[i].IsAllOfForMetadata)
                    {
                        filtered.Add(filteredSchemas[i]);
                    }
                }
                filteredSchemas = filtered;
            }
        }
        
        filteringTime.Stop();
#if NET
        var allocAfterFilter = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var computeDataTime = Stopwatch.StartNew();

        var sharedVisited = new HashSet<SchemaContext>();
        foreach (var schema in filteredSchemas)
        {
            sharedVisited.Clear();
            schema.ComputeData(
                CSharpModelDataFactory.CreateModelData,
                CSharpTypeMapper.CreateTypeData,
                static type => type.WithCSharpComputedValues(),
                CSharpTypeMapper.GetCSharpType,
                CSharpTypeMapper.GetCSharpNullability,
                CSharpSchemaDataFactory.CreatePropertyData,
                CSharpSchemaDataFactory.CreateMethodParameter,
                CSharpSchemaDataFactory.CreateAnyOfData,
                visited: sharedVisited);
        }

        // Second pass: recompute only schemas involved in circular references.
        // After the first pass all TypeData is set, so cyclic schemas now
        // produce their final results with complete data. O(k) where k is
        // the number of unmemoized schemas (~10% for specs with circular refs).
        foreach (var schema in filteredSchemas)
        {
            schema.RecomputeDataIfNeeded(
                CSharpModelDataFactory.CreateModelData,
                CSharpTypeMapper.CreateTypeData,
                static type => type.WithCSharpComputedValues(),
                CSharpTypeMapper.GetCSharpType,
                CSharpTypeMapper.GetCSharpNullability,
                CSharpSchemaDataFactory.CreatePropertyData,
                CSharpSchemaDataFactory.CreateMethodParameter,
                CSharpSchemaDataFactory.CreateAnyOfData);
        }

        computeDataTime.Stop();
#if NET
        var allocAfterData = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var computeDataClassesTime = Stopwatch.StartNew();
        
        var classesBuilder = ImmutableArray.CreateBuilder<ModelData>();
        var enumsBuilder = ImmutableArray.CreateBuilder<ModelData>();
        var anyOfSet = new HashSet<AnyOfData>();
        var anyOfBuilder = ImmutableArray.CreateBuilder<AnyOfData>();
        foreach (var schema in filteredSchemas)
        {
            if (schema.IsReference)
            {
                continue;
            }
            if (schema.IsAnyOfLikeStructure)
            {
                if (schema.AnyOfData is { } anyOf && anyOfSet.Add(anyOf))
                {
                    anyOfBuilder.Add(anyOf);
                }
            }
            else
            {
                if (schema.ClassData is { } classData)
                {
                    classesBuilder.Add(classData);
                }
                if (schema.EnumData is { } enumData)
                {
                    enumsBuilder.Add(enumData);
                }
            }
        }
        var classes = classesBuilder.ToImmutable();
        var enums = enumsBuilder.ToImmutable();
        var anyOfDatas = anyOfBuilder.ToImmutable();

        var operations = openApiDocument.GetOperations(csharpSettings, csharpGlobalSettings, filteredSchemas, provisionalTags);
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
            .ToImmutableArray();

        var authorizationsByIdentity = AuthorizationHelpers.CreateResolvedAuthorizationMap(
            (openApiDocument.Security ?? [])
            .SelectMany(requirement => requirement.OrderBy(
                x => x.Key.Reference?.Id ?? x.Key.Name ?? x.Key.Scheme ?? string.Empty,
                StringComparer.Ordinal))
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(x.Key, csharpSettings, csharpGlobalSettings))
            .Concat(methods.SelectMany(x => x.Authorizations)));
        methods = methods
            .Select(method => AuthorizationHelpers.NormalizeEndPoint(method, authorizationsByIdentity))
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
        
        var authorizations = authorizationsByIdentity
            .Values
            .ToArray();
        var hasOAuth2Support = authorizations.Any(static x => x.Type is SecuritySchemeType.OAuth2);
        var hasMutualTlsSupport = authorizations.Any(static x => x.Type is SecuritySchemeType.MutualTLS);

        var convertersBuilder = ImmutableArray.CreateBuilder<string>();
        // Enum converters
        foreach (var x in enums)
        {
            if (x.Style == ModelStyle.Enumeration)
            {
                convertersBuilder.Add($"global::{x.Namespace}.JsonConverters.{x.ClassName}JsonConverter");
                convertersBuilder.Add($"global::{x.Namespace}.JsonConverters.{x.ClassName}NullableJsonConverter");
            }
        }
        // Named AnyOf converters
        foreach (var x in anyOfDatas)
        {
            if (x.Settings.UsesSystemTextJson() &&
                !string.IsNullOrWhiteSpace(x.Name))
            {
                convertersBuilder.Add($"global::{x.Namespace}.JsonConverters.{x.Name}JsonConverter");
            }
        }
        // Generic AnyOf converters
        foreach (var x in filteredSchemas)
        {
            if (x.Settings.UsesSystemTextJson() &&
                x.AnyOfData.HasValue &&
                string.IsNullOrWhiteSpace(x.AnyOfData.Value.Name))
            {
                var hint = x.IsAnyOf ? Hint.AnyOf : x.IsOneOf ? Hint.OneOf : Hint.AllOf;
                var sb = s_converterBuilder ??= new System.Text.StringBuilder();
                sb.Clear();
                sb.Append("global::");
                sb.Append(x.AnyOfData?.Namespace);
                sb.Append(".JsonConverters.");
                sb.Append(x.AnyOfData?.SubType);
                sb.Append("JsonConverter<");
                var first = true;
                foreach (var y in x.Children)
                {
                    if (y.Hint == hint)
                    {
                        if (!first) sb.Append(", ");
                        sb.Append(y.TypeData.CSharpTypeWithNullabilityForValueTypes);
                        first = false;
                    }
                }
                sb.Append('>');
                convertersBuilder.Add(sb.ToString());
            }
        }
        // Unix Timestamp converter
        convertersBuilder.Add($"global::{globalSettings.Namespace}.JsonConverters.UnixTimestampJsonConverter");
        var converters = convertersBuilder.ToImmutable();
        
        var includedTags = allTags
            .Where(x =>
                x.Name != null &&
                (settings.IncludeTags.Length == 0 ||
                 settings.IncludeTags.Contains(x.Name)) &&
                !settings.ExcludeTags.Contains(x.Name))
            .ToArray();
        var activeTagNames = new HashSet<string>(
            methods.Select(m => m.Tag.Name),
            StringComparer.Ordinal);
        var activeIncludedTags = includedTags
            .Where(tag => tag.Name != null && activeTagNames.Contains(tag.Name))
            .ToArray();
        var resolvedIncludedTagsMap = CSharpClientNameGenerator.ResolveTags(csharpSettings, activeIncludedTags);
        methods = methods
            .Select(method => ResolveEndPointTag(method, resolvedIncludedTagsMap))
            .OrderBy(m => m.Tag.SafeName, StringComparer.Ordinal)
            .ThenBy(m => m.NotAsyncMethodName, StringComparer.Ordinal)
            .ToImmutableArray();
        var hasIdempotencySupport = methods.Any(static method => method.Parameters.Any(static parameter => parameter.IsIdempotencyHeader));
        var resolvedIncludedTags = activeIncludedTags
            .Select(tag => resolvedIncludedTagsMap[tag.Name!])
            .OrderBy(tag => tag.SafeName, StringComparer.Ordinal)
            .ToArray();
        var rootClassName = settings.ClassName.Replace(".", string.Empty);
        var documentServers = CSharpServerFactory.CreateServerOptions(openApiDocument.Servers);
        var clientServersByClass = BuildClientServerMap(methods, rootClassName, documentServers);
        var usesServerSelectionSupport = clientServersByClass.Values.Any(static servers => servers.Length > 1);
        methods = ApplyClientServerSelectionSupport(methods, clientServersByClass);
        methods = ApplyLocationWaitCompanions(methods);
        methods = ApplyPageableMetadata(methods, classes, csharpSettings);
        var rootClientServers = GetClientServers(rootClassName, clientServersByClass, documentServers);

        Client[] clients = settings.GenerateSdk || settings.GenerateConstructors ? [new Client(
                Id: "MainConstructor",
                ClassName: rootClassName,
                FileNameWithoutExtension: $"{settings.Namespace}.{rootClassName}",
                InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I{rootClassName}",
                BaseUrl: rootClientServers.FirstOrDefault().Url ?? string.Empty,
                Clients: settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors)
                    ? [
                        .. resolvedIncludedTags.Select(tag => (PropertyData.Default with
                        {
                            Name = tag.SafeName,
                            Type = (TypeData.Default with
                            {
                                CSharpTypeRaw = CSharpClientNameGenerator.Generate(tag),
                                GeneratedNamespace = settings.Namespace,
                            }).WithCSharpComputedValues(),
                            Summary = tag.DocumentationSummary.ClearForXml(),
                        }).WithCSharpParameterName())
                    ]
                    : [],
                Summary: openApiDocument.Info?.Description?.ClearForXml() ?? string.Empty,
                BaseUrlSummary: rootClientServers.FirstOrDefault().Description?.ClearForXml() ?? string.Empty,
                Settings: csharpSettings,
                GlobalSettings: csharpGlobalSettings,
                Converters: converters,
                HasOAuth2Support: hasOAuth2Support,
                HasIdempotencySupport: hasIdempotencySupport,
                HasMutualTlsSupport: hasMutualTlsSupport,
                Servers: rootClientServers,
                UsesServerSelectionSupport: usesServerSelectionSupport)] : [];
        if (settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors))
        {
            clients = clients.Concat(
                resolvedIncludedTags
                    .Select(tag => new Client(
                        Id: "Constructors",
                        ClassName: CSharpClientNameGenerator.Generate(tag),
                        FileNameWithoutExtension: $"{settings.Namespace}.{CSharpClientNameGenerator.Generate(tag)}",
                        InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I{CSharpClientNameGenerator.Generate(tag)}",
                        BaseUrl: GetClientServers(CSharpClientNameGenerator.Generate(tag), clientServersByClass, documentServers).FirstOrDefault().Url ?? string.Empty,
                        Clients: [],
                        Summary: (!string.IsNullOrWhiteSpace(tag.DisplayName) ? tag.DisplayName : tag.Description)?.ClearForXml() ?? string.Empty,
                        BaseUrlSummary: GetClientServers(CSharpClientNameGenerator.Generate(tag), clientServersByClass, documentServers).FirstOrDefault().Description?.ClearForXml() ?? string.Empty,
                        Settings: csharpSettings,
                        GlobalSettings: csharpGlobalSettings,
                        Converters: [],
                        HasOAuth2Support: hasOAuth2Support,
                        HasIdempotencySupport: hasIdempotencySupport,
                        HasMutualTlsSupport: hasMutualTlsSupport,
                        Servers: GetClientServers(CSharpClientNameGenerator.Generate(tag), clientServersByClass, documentServers),
                        UsesServerSelectionSupport: usesServerSelectionSupport)))
                .ToArray();
        }
        
        var types =
            !skipModels && settings.GenerateJsonSerializerContextTypes
                ? filteredSchemas
                    .Where(x =>
                        x.TypeData != TypeData.Default &&
                        !string.IsNullOrWhiteSpace(x.TypeData.CSharpType))
                    .Select(x => x.TypeData)
                    .GroupBy(x => x.CSharpTypeWithNullability)
                    .Select(x => x.First())
                    .ToImmutableArray()
                : [];

        var outputClasses = skipModels
            ? ImmutableArray<ModelData>.Empty
            : classes
                .Select(x => x with
                {
                    SchemaContext = default!,
                })
                .ToImmutableArray();
        var outputEnums = skipModels
            ? ImmutableArray<ModelData>.Empty
            : enums
                .Select(x => x with
                {
                    SchemaContext = default!,
                })
                .ToImmutableArray();
        var outputAnyOfDatas = skipModels
            ? ImmutableArray<AnyOfData>.Empty
            : anyOfDatas;
        
        computeDataClassesTime.Stop();
#if NET
        var allocAfterClasses = GC.GetTotalAllocatedBytes(precise: true);
#endif

        return new Models.Data(
            Classes: outputClasses,
            Enums: outputEnums,
            Methods: methods,
            Clients: clients.ToImmutableArray(),
            AnyOfs: outputAnyOfDatas,
            Types: types,
            Authorizations: settings.GenerateSdk || settings.GenerateConstructors
                ? authorizations.ToImmutableArray()
                : [],
            Tags: resolvedIncludedTags.ToImmutableArray(),
            Converters: new Client(
                Id: "Converters",
                ClassName: string.Empty,
                FileNameWithoutExtension: $"{settings.Namespace}.",
                InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I",
                BaseUrl: string.Empty,
                Summary: string.Empty,
                Clients: [],
                BaseUrlSummary: string.Empty,
                Settings: csharpSettings,
                GlobalSettings: csharpGlobalSettings,
                Converters: converters,
                UsesServerSelectionSupport: usesServerSelectionSupport),
            Schemas: schemas,
            FilteredSchemas: filteredSchemas,
            Times: new Times(
                Parsing: parsingTime.Elapsed,
                TraversalTree: traversalTreeTime.Elapsed,
                Naming: namingTime.Elapsed,
                ResolveReferences: resolveReferencesTime.Elapsed,
                Filtering: filteringTime.Elapsed,
                ComputeData: computeDataTime.Elapsed,
                ComputeDataClasses: computeDataClassesTime.Elapsed,
                Total: totalTime.Elapsed
#if NET
                ,
                AllocParsing: allocAfterParsing - allocBefore,
                AllocTraversalTree: allocAfterTree - allocAfterParsing,
                AllocNaming: allocAfterNaming - allocAfterTree,
                AllocResolveReferences: allocAfterResolve - allocAfterNaming,
                AllocFiltering: allocAfterFilter - allocAfterResolve,
                AllocComputeData: allocAfterData - allocAfterFilter,
                AllocComputeDataClasses: allocAfterClasses - allocAfterData,
                AllocFilterTags: allocAfterTags - allocBeforeTags
#endif
                )
            );
    }

    internal static Models.Data Enrich(
        CorePipelineResult coreResult,
        CancellationToken cancellationToken = default)
    {
        var totalTime = Stopwatch.StartNew();
#if NET
        var allocBefore = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var openApiDocument = coreResult.OpenApiDocument ?? throw new InvalidOperationException("Core pipeline result does not contain an OpenAPI document.");
        var coreTimes = coreResult.Times;
        var schemas = coreResult.Schemas;
        var filteredSchemas = coreResult.FilteredSchemas;
        var skipModels = coreResult.SkipModels;
        var settings = (CSharpSettings)coreResult.Settings;
        var globalSettings = (CSharpSettings)coreResult.GlobalSettings;
        var includedOperationIds = new HashSet<string>(coreResult.IncludedOperationIds);
        var excludedOperationIds = new HashSet<string>(coreResult.ExcludedOperationIds);
        var allTags = coreResult.AllTags.ToArray();
        var includedTags = coreResult.IncludedTags.ToArray();

        var provisionalTags = CSharpClientNameGenerator.CreateProvisionalTags(settings, allTags);
#if NET
        var allocAfterNaming = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var computeDataTime = Stopwatch.StartNew();

        var sharedVisited = new HashSet<SchemaContext>();
        foreach (var schema in filteredSchemas)
        {
            sharedVisited.Clear();
            schema.ComputeData(
                CSharpModelDataFactory.CreateModelData,
                CSharpTypeMapper.CreateTypeData,
                static type => type.WithCSharpComputedValues(),
                CSharpTypeMapper.GetCSharpType,
                CSharpTypeMapper.GetCSharpNullability,
                CSharpSchemaDataFactory.CreatePropertyData,
                CSharpSchemaDataFactory.CreateMethodParameter,
                CSharpSchemaDataFactory.CreateAnyOfData,
                visited: sharedVisited);
        }

        foreach (var schema in filteredSchemas)
        {
            schema.RecomputeDataIfNeeded(
                CSharpModelDataFactory.CreateModelData,
                CSharpTypeMapper.CreateTypeData,
                static type => type.WithCSharpComputedValues(),
                CSharpTypeMapper.GetCSharpType,
                CSharpTypeMapper.GetCSharpNullability,
                CSharpSchemaDataFactory.CreatePropertyData,
                CSharpSchemaDataFactory.CreateMethodParameter,
                CSharpSchemaDataFactory.CreateAnyOfData);
        }

        computeDataTime.Stop();
#if NET
        var allocAfterData = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var computeDataClassesTime = Stopwatch.StartNew();

        var classesBuilder = ImmutableArray.CreateBuilder<ModelData>();
        var enumsBuilder = ImmutableArray.CreateBuilder<ModelData>();
        var anyOfSet = new HashSet<AnyOfData>();
        var anyOfBuilder = ImmutableArray.CreateBuilder<AnyOfData>();
        foreach (var schema in filteredSchemas)
        {
            if (schema.IsReference)
            {
                continue;
            }

            if (schema.IsAnyOfLikeStructure)
            {
                if (schema.AnyOfData is { } anyOf && anyOfSet.Add(anyOf))
                {
                    anyOfBuilder.Add(anyOf);
                }
            }
            else
            {
                if (schema.ClassData is { } classData)
                {
                    classesBuilder.Add(classData);
                }

                if (schema.EnumData is { } enumData)
                {
                    enumsBuilder.Add(enumData);
                }
            }
        }

        var classes = classesBuilder.ToImmutable();
        var enums = enumsBuilder.ToImmutable();
        var anyOfDatas = anyOfBuilder.ToImmutable();

        var operations = openApiDocument.GetOperations(settings, globalSettings, filteredSchemas, provisionalTags);
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
                            (operation.Operation.OperationId != null &&
                             includedOperationIds.Contains(operation.Operation.OperationId))) &&
                           !excludedOperationIds.Contains(operation.MethodName) &&
                           (operation.Operation.OperationId == null ||
                            !excludedOperationIds.Contains(operation.Operation.OperationId));
                })
                .ToArray()
            : [];

        var methods = filteredOperations
            .SelectMany(CreateEndPoints)
            .ToImmutableArray();

        var authorizationsByIdentity = AuthorizationHelpers.CreateResolvedAuthorizationMap(
            (openApiDocument.Security ?? [])
            .SelectMany(requirement => requirement.OrderBy(
                x => x.Key.Reference?.Id ?? x.Key.Name ?? x.Key.Scheme ?? string.Empty,
                StringComparer.Ordinal))
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(x.Key, settings, globalSettings))
            .Concat(methods.SelectMany(x => x.Authorizations)));
        methods = methods
            .Select(method => AuthorizationHelpers.NormalizeEndPoint(method, authorizationsByIdentity))
            .ToImmutableArray();

        if (settings.GenerateCli)
        {
            foreach (var group in methods
                         .GroupBy(x => x.Tag)
                         .Where(x => !x.AreKeysUnique(y => y.CliAction)))
            {
                Console.WriteLine(
                    $"Found duplicate CLI action names in '{group.Key.SingularizedName}': {string.Join(", ", group.Select(x => x.CliAction))}");
            }
        }

        var authorizations = authorizationsByIdentity
            .Values
            .ToArray();
        var hasOAuth2Support = authorizations.Any(static x => x.Type is SecuritySchemeType.OAuth2);
        var hasMutualTlsSupport = authorizations.Any(static x => x.Type is SecuritySchemeType.MutualTLS);

        var convertersBuilder = ImmutableArray.CreateBuilder<string>();
        foreach (var value in enums)
        {
            if (value.Style == ModelStyle.Enumeration)
            {
                convertersBuilder.Add($"global::{value.Namespace}.JsonConverters.{value.ClassName}JsonConverter");
                convertersBuilder.Add($"global::{value.Namespace}.JsonConverters.{value.ClassName}NullableJsonConverter");
            }
        }

        foreach (var value in anyOfDatas)
        {
            if (value.Settings.UsesSystemTextJson() &&
                !string.IsNullOrWhiteSpace(value.Name))
            {
                convertersBuilder.Add($"global::{value.Namespace}.JsonConverters.{value.Name}JsonConverter");
            }
        }

        foreach (var schema in filteredSchemas)
        {
            if (schema.Settings.UsesSystemTextJson() &&
                schema.AnyOfData.HasValue &&
                string.IsNullOrWhiteSpace(schema.AnyOfData.Value.Name))
            {
                var hint = schema.IsAnyOf ? Hint.AnyOf : schema.IsOneOf ? Hint.OneOf : Hint.AllOf;
                var sb = s_converterBuilder ??= new System.Text.StringBuilder();
                sb.Clear();
                sb.Append("global::");
                sb.Append(schema.AnyOfData?.Namespace);
                sb.Append(".JsonConverters.");
                sb.Append(schema.AnyOfData?.SubType);
                sb.Append("JsonConverter<");
                var first = true;
                foreach (var child in schema.Children)
                {
                    if (child.Hint == hint)
                    {
                        if (!first)
                        {
                            sb.Append(", ");
                        }

                        sb.Append(child.TypeData.CSharpTypeWithNullabilityForValueTypes);
                        first = false;
                    }
                }

                sb.Append('>');
                convertersBuilder.Add(sb.ToString());
            }
        }

        convertersBuilder.Add($"global::{globalSettings.Namespace}.JsonConverters.UnixTimestampJsonConverter");
        var converters = convertersBuilder.ToImmutable();

        var activeTagNames = new HashSet<string>(
            methods.Select(m => m.Tag.Name),
            StringComparer.Ordinal);
        var activeIncludedTags = includedTags
            .Where(tag => tag.Name != null && activeTagNames.Contains(tag.Name))
            .ToArray();
        var resolvedIncludedTagsMap = CSharpClientNameGenerator.ResolveTags(settings, activeIncludedTags);
        methods = methods
            .Select(method => ResolveEndPointTag(method, resolvedIncludedTagsMap))
            .OrderBy(m => m.Tag.SafeName, StringComparer.Ordinal)
            .ThenBy(m => m.NotAsyncMethodName, StringComparer.Ordinal)
            .ToImmutableArray();
        var resolvedIncludedTags = activeIncludedTags
            .Select(tag => resolvedIncludedTagsMap[tag.Name!])
            .OrderBy(tag => tag.SafeName, StringComparer.Ordinal)
            .ToArray();
        var hasIdempotencySupport = methods.Any(static method => method.Parameters.Any(static parameter => parameter.IsIdempotencyHeader));
        var rootClassName = settings.ClassName.Replace(".", string.Empty);
        var documentServers = CSharpServerFactory.CreateServerOptions(openApiDocument.Servers);
        var clientServersByClass = BuildClientServerMap(methods, rootClassName, documentServers);
        var usesServerSelectionSupport = clientServersByClass.Values.Any(static servers => servers.Length > 1);
        methods = ApplyClientServerSelectionSupport(methods, clientServersByClass);
        methods = ApplyLocationWaitCompanions(methods);
        methods = ApplyPageableMetadata(methods, classes, settings);
        var rootClientServers = GetClientServers(rootClassName, clientServersByClass, documentServers);

        Client[] clients = settings.GenerateSdk || settings.GenerateConstructors
            ? [new Client(
                Id: "MainConstructor",
                ClassName: rootClassName,
                FileNameWithoutExtension: $"{settings.Namespace}.{rootClassName}",
                InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I{rootClassName}",
                BaseUrl: rootClientServers.FirstOrDefault().Url ?? string.Empty,
                Clients: settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors)
                    ? [
                        .. resolvedIncludedTags.Select(tag => (PropertyData.Default with
                        {
                            Name = tag.SafeName,
                            Type = (TypeData.Default with
                            {
                                CSharpTypeRaw = CSharpClientNameGenerator.Generate(tag),
                                GeneratedNamespace = settings.Namespace,
                            }).WithCSharpComputedValues(),
                            Summary = tag.DocumentationSummary.ClearForXml(),
                        }).WithCSharpParameterName())
                    ]
                    : [],
                Summary: openApiDocument.Info?.Description?.ClearForXml() ?? string.Empty,
                BaseUrlSummary: rootClientServers.FirstOrDefault().Description?.ClearForXml() ?? string.Empty,
                Settings: settings,
                GlobalSettings: globalSettings,
                Converters: converters,
                HasOAuth2Support: hasOAuth2Support,
                HasIdempotencySupport: hasIdempotencySupport,
                HasMutualTlsSupport: hasMutualTlsSupport,
                Servers: rootClientServers,
                UsesServerSelectionSupport: usesServerSelectionSupport)]
            : [];

        if (settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors))
        {
            clients = clients.Concat(
                    resolvedIncludedTags.Select(tag => new Client(
                        Id: "Constructors",
                        ClassName: CSharpClientNameGenerator.Generate(tag),
                        FileNameWithoutExtension: $"{settings.Namespace}.{CSharpClientNameGenerator.Generate(tag)}",
                        InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I{CSharpClientNameGenerator.Generate(tag)}",
                        BaseUrl: GetClientServers(CSharpClientNameGenerator.Generate(tag), clientServersByClass, documentServers).FirstOrDefault().Url ?? string.Empty,
                        Clients: [],
                        Summary: (!string.IsNullOrWhiteSpace(tag.DisplayName) ? tag.DisplayName : tag.Description)?.ClearForXml() ?? string.Empty,
                        BaseUrlSummary: GetClientServers(CSharpClientNameGenerator.Generate(tag), clientServersByClass, documentServers).FirstOrDefault().Description?.ClearForXml() ?? string.Empty,
                        Settings: settings,
                        GlobalSettings: globalSettings,
                        Converters: [],
                        HasOAuth2Support: hasOAuth2Support,
                        HasIdempotencySupport: hasIdempotencySupport,
                        HasMutualTlsSupport: hasMutualTlsSupport,
                        Servers: GetClientServers(CSharpClientNameGenerator.Generate(tag), clientServersByClass, documentServers),
                        UsesServerSelectionSupport: usesServerSelectionSupport)))
                .ToArray();
        }

        var types = !skipModels && settings.GenerateJsonSerializerContextTypes
            ? filteredSchemas
                .Where(x =>
                    x.TypeData != TypeData.Default &&
                    !string.IsNullOrWhiteSpace(x.TypeData.CSharpType))
                .Select(x => x.TypeData)
                .GroupBy(x => x.CSharpTypeWithNullability)
                .Select(x => x.First())
                .ToImmutableArray()
            : [];

        var outputClasses = skipModels
            ? ImmutableArray<ModelData>.Empty
            : classes
                .Select(x => x with
                {
                    SchemaContext = default!,
                })
                .ToImmutableArray();
        var outputEnums = skipModels
            ? ImmutableArray<ModelData>.Empty
            : enums
                .Select(x => x with
                {
                    SchemaContext = default!,
                })
                .ToImmutableArray();
        var outputAnyOfDatas = skipModels
            ? ImmutableArray<AnyOfData>.Empty
            : anyOfDatas;

        computeDataClassesTime.Stop();
#if NET
        var allocAfterClasses = GC.GetTotalAllocatedBytes(precise: true);
#endif

        return new Models.Data(
            Classes: outputClasses,
            Enums: outputEnums,
            Methods: methods,
            Clients: clients.ToImmutableArray(),
            AnyOfs: outputAnyOfDatas,
            Types: types,
            Authorizations: settings.GenerateSdk || settings.GenerateConstructors
                ? authorizations.ToImmutableArray()
                : [],
            Tags: resolvedIncludedTags.ToImmutableArray(),
            Converters: new Client(
                Id: "Converters",
                ClassName: string.Empty,
                FileNameWithoutExtension: $"{settings.Namespace}.",
                InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I",
                BaseUrl: string.Empty,
                Summary: string.Empty,
                Clients: [],
                BaseUrlSummary: string.Empty,
                Settings: settings,
                GlobalSettings: globalSettings,
                Converters: converters,
                UsesServerSelectionSupport: usesServerSelectionSupport),
            Schemas: schemas,
            FilteredSchemas: filteredSchemas,
            Times: new Times(
                Parsing: coreTimes.Parsing,
                TraversalTree: coreTimes.TraversalTree,
                Naming: coreTimes.Naming,
                ResolveReferences: coreTimes.ResolveReferences,
                Filtering: coreTimes.Filtering,
                ComputeData: computeDataTime.Elapsed,
                ComputeDataClasses: computeDataClassesTime.Elapsed,
                Total: totalTime.Elapsed
#if NET
                ,
                AllocParsing: coreTimes.AllocParsing,
                AllocTraversalTree: coreTimes.AllocTraversalTree,
                AllocNaming: allocAfterNaming - allocBefore,
                AllocResolveReferences: coreTimes.AllocResolveReferences,
                AllocFiltering: coreTimes.AllocFiltering,
                AllocComputeData: allocAfterData - allocAfterNaming,
                AllocComputeDataClasses: allocAfterClasses - allocAfterData,
                AllocFilterTags: coreTimes.AllocFilterTags
#endif
            ));
    }

    private static Dictionary<string, EquatableArray<ServerOption>> BuildClientServerMap(
        IReadOnlyList<EndPoint> methods,
        string rootClassName,
        EquatableArray<ServerOption> documentServers)
    {
        var serversByClass = new Dictionary<string, List<ServerOption>>(StringComparer.Ordinal);

        if (!documentServers.IsEmpty)
        {
            AddServers(rootClassName, documentServers);
        }

        foreach (var method in methods)
        {
            var effectiveServers = method.Servers.IsEmpty
                ? documentServers
                : method.Servers;
            if (effectiveServers.IsEmpty)
            {
                continue;
            }

            AddServers(rootClassName, effectiveServers);
            AddServers(method.ClassName, effectiveServers);
        }

        return serversByClass.ToDictionary(
            static pair => pair.Key,
            static pair => pair.Value.ToImmutableArray().AsEquatableArray(),
            StringComparer.Ordinal);

        void AddServers(
            string className,
            EquatableArray<ServerOption> servers)
        {
            if (!serversByClass.TryGetValue(className, out var list))
            {
                list = [];
                serversByClass[className] = list;
            }

            foreach (var server in servers)
            {
                if (list.Any(existing =>
                        string.Equals(existing.Id, server.Id, StringComparison.Ordinal) ||
                        string.Equals(existing.Url, server.Url, StringComparison.Ordinal)))
                {
                    continue;
                }

                list.Add(server);
            }
        }
    }

    private static ImmutableArray<EndPoint> ApplyClientServerSelectionSupport(
        IReadOnlyList<EndPoint> methods,
        Dictionary<string, EquatableArray<ServerOption>> clientServersByClass)
    {
        return methods
            .Select(method => method with
            {
                ClientUsesServerSelectionSupport =
                    clientServersByClass.TryGetValue(method.ClassName, out var servers) &&
                    servers.Length > 1,
            })
            .ToImmutableArray();
    }

    /// <summary>
    /// Auto-detects offset/page-number pagination for endpoints that have a
    /// `page`/`page_number`/`pageIndex` query parameter and a 2XX response whose schema
    /// has exactly one array property. The result is stored on the endpoint's
    /// <see cref="EndPoint.PageableMetadata"/> so <see cref="Sources.Methods"/> can emit
    /// a <c>&lt;Method&gt;AutoPagingAsync</c> companion backed by
    /// <c>AutoSDKPager.OffsetAsync</c>.
    /// </summary>
    private static ImmutableArray<EndPoint> ApplyPageableMetadata(
        IReadOnlyList<EndPoint> methods,
        ImmutableArray<ModelData> classes,
        CSharpSettings settings)
    {
        if (!settings.GeneratePageableHelpers || methods.Count == 0)
        {
            return methods.ToImmutableArray();
        }

        var classByName = classes
            .Where(static c => !string.IsNullOrEmpty(c.GlobalClassName))
            .ToDictionary(static c => c.GlobalClassName, static c => c, StringComparer.Ordinal);

        return methods
            .Select(method =>
            {
                if (method.HttpMethod != System.Net.Http.HttpMethod.Get ||
                    method.HasPageableHelper ||
                    string.IsNullOrWhiteSpace(method.SuccessResponse.Type.CSharpType))
                {
                    return method;
                }

                var responseClassName = method.SuccessResponse.Type.CSharpTypeWithoutNullability;
                if (!classByName.TryGetValue(responseClassName, out var responseClass))
                {
                    return method;
                }

                // Locate the single array property on the response. Multiple array
                // properties make the items field ambiguous and skip detection.
                PropertyData? itemsProperty = null;
                foreach (var property in responseClass.Properties)
                {
                    if (!property.Type.IsArray ||
                        property.Type.SubTypes.Length == 0 ||
                        string.IsNullOrWhiteSpace(property.Type.SubTypes[0].Unbox<TypeData>().CSharpType))
                    {
                        continue;
                    }

                    if (itemsProperty != null)
                    {
                        return method;
                    }

                    itemsProperty = property;
                }

                if (itemsProperty is null)
                {
                    return method;
                }

                var itemType = itemsProperty.Value.Type.SubTypes[0].Unbox<TypeData>();

                // Offset style takes priority — it requires a known page-number query
                // parameter, which is a stronger signal than a cursor-named param.
                var pageParam = method.Parameters
                    .FirstOrDefault(static p =>
                        p.Location == Microsoft.OpenApi.ParameterLocation.Query &&
                        IsOffsetPageParameter(p.Id));
                if (!string.IsNullOrEmpty(pageParam.ParameterName))
                {
                    return method with
                    {
                        PageableMetadata = new PageableMetadata(
                            Style: PageableStyle.Offset,
                            PageParameterName: pageParam.ParameterName,
                            ItemsPropertyName: itemsProperty.Value.Name,
                            ItemType: itemType,
                            NextCursorPropertyName: string.Empty),
                    };
                }

                // Cursor style: known cursor-named query parameter (string-typed) plus
                // a response property that exposes the next cursor / next page token.
                var cursorParam = method.Parameters
                    .FirstOrDefault(static p =>
                        p.Location == Microsoft.OpenApi.ParameterLocation.Query &&
                        IsCursorPageParameter(p.Id));
                if (string.IsNullOrEmpty(cursorParam.ParameterName))
                {
                    return method;
                }

                PropertyData? nextCursorProperty = null;
                foreach (var property in responseClass.Properties)
                {
                    if (!IsNextCursorProperty(property))
                    {
                        continue;
                    }

                    if (nextCursorProperty != null)
                    {
                        // Multiple plausible next-cursor properties → ambiguous, skip.
                        return method;
                    }

                    nextCursorProperty = property;
                }

                if (nextCursorProperty is null)
                {
                    return method;
                }

                return method with
                {
                    PageableMetadata = new PageableMetadata(
                        Style: PageableStyle.Cursor,
                        PageParameterName: cursorParam.ParameterName,
                        ItemsPropertyName: itemsProperty.Value.Name,
                        ItemType: itemType,
                        NextCursorPropertyName: nextCursorProperty.Value.Name),
                };
            })
            .ToImmutableArray();
    }

    private static bool IsOffsetPageParameter(string parameterId)
    {
        if (string.IsNullOrEmpty(parameterId))
        {
            return false;
        }

        return string.Equals(parameterId, "page", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "page_number", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "pageNumber", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "pageIndex", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "page_index", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsCursorPageParameter(string parameterId)
    {
        if (string.IsNullOrEmpty(parameterId))
        {
            return false;
        }

        return string.Equals(parameterId, "cursor", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "after", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "page_token", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "pageToken", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "next_page", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "nextPage", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "next_page_token", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "nextPageToken", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "pagination_token", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameterId, "paginationToken", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsNextCursorProperty(PropertyData property)
    {
        if (string.IsNullOrEmpty(property.Id) ||
            property.Type.IsArray ||
            !string.Equals(property.Type.CSharpTypeWithoutNullability, "string", StringComparison.Ordinal))
        {
            return false;
        }

        return string.Equals(property.Id, "next_cursor", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "nextCursor", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "next_page", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "nextPage", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "next_page_token", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "nextPageToken", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "next_page_cursor", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "nextPageCursor", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "after", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "last_id", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "lastId", StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Pairs non-GET endpoints whose success response declares a <c>Location</c> header with a
    /// sibling GET endpoint exposing a synthesized polling helper (typically emitted by
    /// <c>--auto-detect-status-polling</c>). When a pair is found, the create endpoint records
    /// the sibling's polling method, path template, ID parameter, and return type so
    /// <see cref="Sources.Methods"/> can emit a <c>&lt;CreateMethod&gt;WaitAsync</c> companion
    /// that calls the create operation, extracts the resource id from the response
    /// <c>Location</c> header, and dispatches to the sibling's polling helper.
    /// </summary>
    private static ImmutableArray<EndPoint> ApplyLocationWaitCompanions(
        IReadOnlyList<EndPoint> methods)
    {
        if (!methods.Any(static m =>
                m.HasLocationHeaderOnSuccess &&
                m.HttpMethod != System.Net.Http.HttpMethod.Get))
        {
            return methods.ToImmutableArray();
        }

        var pollingHelpersByPath = methods
            .Where(static m =>
                m.HttpMethod == System.Net.Http.HttpMethod.Get &&
                !m.PollingOperations.IsEmpty &&
                !string.IsNullOrEmpty(m.Path))
            .ToDictionary(static m => UnwrapPreparedPath(m.Path), static m => m, StringComparer.Ordinal);
        if (pollingHelpersByPath.Count == 0)
        {
            return methods.ToImmutableArray();
        }

        return methods
            .Select(method =>
            {
                if (!method.HasLocationHeaderOnSuccess ||
                    method.HttpMethod == System.Net.Http.HttpMethod.Get ||
                    string.IsNullOrEmpty(method.Path))
                {
                    return method;
                }

                var sibling = FindLocationSiblingGet(method, pollingHelpersByPath);
                if (sibling == null)
                {
                    return method;
                }

                var siblingValue = sibling.Value;
                var pollingOperation = siblingValue.PollingOperations.FirstOrDefault();
                if (pollingOperation.Name is null or { Length: 0 })
                {
                    return method;
                }

                var idParameter = siblingValue.Parameters
                    .FirstOrDefault(static p =>
                        p.Location == Microsoft.OpenApi.ParameterLocation.Path);
                if (string.IsNullOrEmpty(idParameter.ParameterName))
                {
                    return method;
                }

                return method with
                {
                    LocationWaitCompanion = new LocationWaitCompanion(
                        SiblingMethodName: siblingValue.NotAsyncMethodName,
                        SiblingPollingMethodName:
                            $"{siblingValue.NotAsyncMethodName}{pollingOperation.Name.ToPropertyName()}Async",
                        SiblingPath: siblingValue.Path,
                        SiblingIdParameterName: idParameter.ParameterName,
                        SiblingReturnType: siblingValue.SuccessResponse.Type),
                };
            })
            .ToImmutableArray();
    }

    // The path stored on EndPoint is a C# string-interpolation literal — e.g. `"/v1/tasks"`
    // for parameter-free paths or `$"/v1/tasks/{id}"` for paths with path-parameter
    // substitutions (see <c>OpenApiPathExtensions.PreparePath</c>). Cross-operation
    // pairing for #318 needs the raw template, so we strip the literal wrapping back
    // off when bucketing methods by path.
    private static string UnwrapPreparedPath(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return path;
        }

        var trimmed = path;
        if (trimmed.StartsWith("$", StringComparison.Ordinal))
        {
            trimmed = trimmed.Substring(1);
        }

        if (trimmed.Length >= 2 &&
            trimmed.StartsWith("\"", StringComparison.Ordinal) &&
            trimmed.EndsWith("\"", StringComparison.Ordinal))
        {
            trimmed = trimmed.Substring(1, trimmed.Length - 2);
        }

        return trimmed;
    }

    private static EndPoint? FindLocationSiblingGet(
        EndPoint createMethod,
        Dictionary<string, EndPoint> pollingHelpersByPath)
    {
        var prefix = UnwrapPreparedPath(createMethod.Path) + "/{";
        foreach (var pair in pollingHelpersByPath)
        {
            var candidate = pair.Key;
            if (candidate.Length <= prefix.Length ||
                !candidate.StartsWith(prefix, StringComparison.Ordinal))
            {
                continue;
            }

            var suffix = candidate.Substring(prefix.Length);
            // Suffix must be the rest of a single path parameter "<name>}" without further slashes.
            if (suffix.Contains('/'))
            {
                continue;
            }

            if (!suffix.EndsWith("}", StringComparison.Ordinal))
            {
                continue;
            }

            // One path parameter only — confirm it is a simple identifier (no nested templating).
            var parameterName = suffix.Substring(0, suffix.Length - 1);
            if (string.IsNullOrEmpty(parameterName) || parameterName.Contains('{'))
            {
                continue;
            }

            // Skip when the sibling is in a different client/tag from the create operation —
            // pairing across unrelated resource groups produces confusing call sites.
            if (!string.Equals(pair.Value.ClassName, createMethod.ClassName, StringComparison.Ordinal))
            {
                continue;
            }

            return pair.Value;
        }

        return null;
    }

    private static EquatableArray<ServerOption> GetClientServers(
        string className,
        Dictionary<string, EquatableArray<ServerOption>> clientServersByClass,
        EquatableArray<ServerOption> documentServers)
    {
        return clientServersByClass.TryGetValue(className, out var servers) && !servers.IsEmpty
            ? servers
            : documentServers;
    }

    private static IEnumerable<EndPoint> CreateEndPoints(OperationContext operation)
    {
        var fernStreaming = FernStreamingMetadata.TryCreate(operation);
        var responseContentTypes = (operation.Operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            .SelectMany(response => (response.Value?.Content ?? new Dictionary<string, IOpenApiMediaType>())
                .Where(_ => response.Key.StartsWith("2", StringComparison.OrdinalIgnoreCase))
                .Select(content => content.Key))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToArray();

        var hasJson = responseContentTypes.Any(static contentType =>
            contentType.IsJsonMimeType() && !contentType.IsSequentialJsonMimeType());
        var hasSequentialJson = responseContentTypes.Any(static contentType =>
            contentType.IsSequentialJsonMimeType());
        var hasSse = responseContentTypes.Any(static contentType =>
            contentType.IsServerSentEventsMimeType());

        var endPoints = new List<EndPoint>();

        if (fernStreaming?.HasRequestStreamCondition == true)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPoint(
                operation,
                preferredMimeType: "application/json",
                forcedRequestStreamValue: false,
                successResponseOverride: fernStreaming.RegularResponseOverride));
            endPoints.Add(CSharpEndPointFactory.CreateEndPoint(
                operation,
                preferredMimeType: GetPreferredStreamMimeType(responseContentTypes, fernStreaming.StreamFormat),
                methodNameSuffix: GetStreamMethodSuffix(
                    hasRegularJsonVariant: true,
                    hasAnotherStreamingVariant: false,
                    streamFormat: fernStreaming.StreamFormat),
                forcedRequestStreamValue: true,
                successResponseOverride: fernStreaming.StreamResponseOverride,
                streamFormatOverride: fernStreaming.StreamFormat,
                streamTerminator: fernStreaming.Terminator));
            return endPoints;
        }

        if (fernStreaming != null &&
            !hasSse &&
            !hasSequentialJson)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPoint(
                operation,
                preferredMimeType: GetPreferredStreamMimeType(responseContentTypes, fernStreaming.StreamFormat),
                successResponseOverride: fernStreaming.StreamResponseOverride ?? fernStreaming.RegularResponseOverride,
                streamFormatOverride: fernStreaming.StreamFormat,
                streamTerminator: fernStreaming.Terminator));
            return endPoints;
        }

        if (hasJson)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPoint(
                operation,
                preferredMimeType: "application/json",
                forcedRequestStreamValue: hasSequentialJson || hasSse ? false : null,
                successResponseOverride: fernStreaming?.RegularResponseOverride));
        }

        if (hasSse)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPoint(
                operation,
                preferredMimeType: "text/event-stream",
                methodNameSuffix: GetStreamMethodSuffix(
                    hasRegularJsonVariant: hasJson,
                    hasAnotherStreamingVariant: hasSequentialJson,
                    streamFormat: StreamFormat.ServerSentEvents),
                forcedRequestStreamValue: hasJson ? true : null,
                successResponseOverride: fernStreaming?.StreamResponseOverride,
                streamFormatOverride: fernStreaming?.StreamFormat == StreamFormat.ServerSentEvents
                    ? fernStreaming.StreamFormat
                    : null,
                streamTerminator: fernStreaming?.Terminator));
        }

        if (hasSequentialJson)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPoint(
                operation,
                preferredMimeType: "application/x-ndjson",
                methodNameSuffix: GetStreamMethodSuffix(
                    hasRegularJsonVariant: hasJson,
                    hasAnotherStreamingVariant: hasSse,
                    streamFormat: StreamFormat.Ndjson),
                forcedRequestStreamValue: hasJson ? true : null,
                successResponseOverride: fernStreaming?.StreamResponseOverride,
                streamFormatOverride: fernStreaming?.StreamFormat == StreamFormat.Ndjson
                    ? fernStreaming.StreamFormat
                    : null,
                streamTerminator: fernStreaming?.Terminator));
        }

        if (endPoints.Count == 0)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPoint(operation));
        }

        return endPoints;
    }

    private static string? GetPreferredStreamMimeType(
        IReadOnlyCollection<string> responseContentTypes,
        StreamFormat streamFormat)
    {
        if (streamFormat == StreamFormat.ServerSentEvents &&
            responseContentTypes.Any(static x => x.IsServerSentEventsMimeType()))
        {
            return "text/event-stream";
        }

        if (streamFormat == StreamFormat.Ndjson &&
            responseContentTypes.Any(static x => x.IsSequentialJsonMimeType()))
        {
            return responseContentTypes.First(static x => x.IsSequentialJsonMimeType()).NormalizeMimeType();
        }

        if (responseContentTypes.Any(static x => x.IsJsonMimeType() && !x.IsSequentialJsonMimeType()))
        {
            return "application/json";
        }

        return null;
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

    private static EndPoint ResolveEndPointTag(
        EndPoint method,
        IReadOnlyDictionary<string, Tag> resolvedTags)
    {
        if (method.Tag == Tag.Empty ||
            string.IsNullOrWhiteSpace(method.Tag.Name) ||
            !resolvedTags.TryGetValue(method.Tag.Name, out var resolvedTag) ||
            resolvedTag.SafeName == method.Tag.SafeName)
        {
            return method;
        }

        var className = method.Settings.GroupByTags && resolvedTag != Tag.Empty
            ? CSharpClientNameGenerator.Generate(resolvedTag)
            : method.Settings.ClassName.Replace(".", string.Empty);

        return method with
        {
            Tag = resolvedTag,
            ClassName = className,
            CliCommandClassName = resolvedTag != Tag.Empty && !string.IsNullOrWhiteSpace(resolvedTag.SafeName)
                ? $"{resolvedTag.SafeName}{method.NotAsyncMethodName}Command"
                : $"{method.NotAsyncMethodName}Command",
            FileNameWithoutExtension = $"{method.Settings.Namespace}.{className}.{method.NotAsyncMethodName}",
            InterfaceFileNameWithoutExtension = $"{method.Settings.Namespace}.I{className}.{method.NotAsyncMethodName}",
        };
    }

    private static string CreateServerSummary(OpenApiServer? server)
    {
        var name = server?.Name?.Trim();
        var description = server?.Description?.Trim();

        if (string.IsNullOrWhiteSpace(name))
        {
            return description?.ClearForXml() ?? string.Empty;
        }

        if (string.IsNullOrWhiteSpace(description) ||
            string.Equals(name, description, StringComparison.OrdinalIgnoreCase))
        {
            return name!.ClearForXml();
        }

        return $"{name}. {description}".ClearForXml();
    }

    /// <summary>
    /// Detects schemas involved in circular reference chains and marks them
    /// with <see cref="SchemaContext.IsInCycle"/>. Uses DFS with three-color
    /// marking (white/gray/black) to find back-edges in the schema graph.
    /// </summary>
    private static void DetectCycles(IReadOnlyCollection<SchemaContext> schemas)
    {
        // 0 = white (unvisited), 1 = gray (in progress), 2 = black (done)
        var color = new Dictionary<SchemaContext, byte>(schemas.Count);
        var cycleNodes = new HashSet<SchemaContext>();

        foreach (var schema in schemas)
        {
            if (!color.ContainsKey(schema))
            {
                DetectCyclesDfs(schema, color, cycleNodes, []);
            }
        }

        foreach (var node in cycleNodes)
        {
            node.IsInCycle = true;
        }
    }

    private static void DetectCyclesDfs(
        SchemaContext node,
        Dictionary<SchemaContext, byte> color,
        HashSet<SchemaContext> cycleNodes,
        List<SchemaContext> stack)
    {
        color[node] = 1; // gray
        stack.Add(node);

        foreach (var neighbor in GetNeighbors(node))
        {
            if (!color.TryGetValue(neighbor, out var c))
            {
                // White — recurse
                DetectCyclesDfs(neighbor, color, cycleNodes, stack);
            }
            else if (c == 1)
            {
                // Gray — back-edge found, mark all nodes in the cycle
                var idx = stack.LastIndexOf(neighbor);
                if (idx >= 0)
                {
                    for (var i = idx; i < stack.Count; i++)
                    {
                        cycleNodes.Add(stack[i]);
                    }
                }
            }
            // Black (2) — already fully processed, skip
        }

        stack.RemoveAt(stack.Count - 1);
        color[node] = 2; // black

        static IEnumerable<SchemaContext> GetNeighbors(SchemaContext ctx)
        {
            if (ctx.ResolvedReference != null)
            {
                yield return ctx.ResolvedReference;
            }
            foreach (var child in ctx.Children)
            {
                yield return child;
            }
        }
    }
}
