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
        // Also collect ad-hoc group names from x-fern-sdk-group-name extensions in a single pass.
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
                            allTags.Add(new OpenApiTag { Name = tag.Name, Description = tag.Description });
                        }
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
        var allSchemasPass = (settings.GenerateModels || settings.GenerateSdk) &&
                             !hasTagFilters && !hasModelFilters;

        IReadOnlyList<SchemaContext> filteredSchemas;
        if (allSchemasPass)
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
                if (!(settings.GenerateModels ||
                      settings.GenerateSdk ||
                      (x.Operation?.OperationId != null && includedOperationIds.Contains(x.Operation.OperationId))))
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
            .SelectMany(requirement => requirement.OrderBy(x => x.Key.Name ?? string.Empty, StringComparer.Ordinal))
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(x.Key, csharpSettings, csharpGlobalSettings))
            .Concat(methods.SelectMany(x => x.Authorizations))
            .GroupBy(x => x.FriendlyName)
            .Select(g => g.First())
            .ToArray();
        var hasOAuth2Support = authorizations.Any(static x => x.Type is SecuritySchemeType.OAuth2);

        var convertersBuilder = ImmutableArray.CreateBuilder<string>();
        // Enum converters
        foreach (var x in enums)
        {
            if (x.Style == ModelStyle.Enumeration &&
                !x.Settings.UsesNewtonsoftJson())
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
        var resolvedIncludedTags = activeIncludedTags
            .Select(tag => resolvedIncludedTagsMap[tag.Name!])
            .OrderBy(tag => tag.SafeName, StringComparer.Ordinal)
            .ToArray();
        Client[] clients = settings.GenerateSdk || settings.GenerateConstructors ? [new Client(
                Id: "MainConstructor",
                ClassName: settings.ClassName.Replace(".", string.Empty),
                FileNameWithoutExtension: $"{settings.Namespace}.{settings.ClassName.Replace(".", string.Empty)}",
                InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I{settings.ClassName.Replace(".", string.Empty)}",
                BaseUrl: openApiDocument.Servers!.FirstOrDefault().ExpandServerTemplate(),
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
                            Summary = (!string.IsNullOrWhiteSpace(tag.DisplayName) ? tag.DisplayName : tag.Description)?.ClearForXml() ?? string.Empty,
                        }).WithCSharpParameterName())
                    ]
                    : [],
                Summary: openApiDocument.Info?.Description?.ClearForXml() ?? string.Empty,
                BaseUrlSummary: openApiDocument.Servers!.FirstOrDefault()?.Description?.ClearForXml() ?? string.Empty,
                Settings: csharpSettings,
                GlobalSettings: csharpGlobalSettings,
                Converters: converters,
                HasOAuth2Support: hasOAuth2Support)] : [];
        if (settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors))
        {
            clients = clients.Concat(
                resolvedIncludedTags
                    .Select(tag => new Client(
                        Id: "Constructors",
                        ClassName: CSharpClientNameGenerator.Generate(tag),
                        FileNameWithoutExtension: $"{settings.Namespace}.{CSharpClientNameGenerator.Generate(tag)}",
                        InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I{CSharpClientNameGenerator.Generate(tag)}",
                        BaseUrl: openApiDocument.Servers!.FirstOrDefault().ExpandServerTemplate(),
                        Clients: [],
                        Summary: (!string.IsNullOrWhiteSpace(tag.DisplayName) ? tag.DisplayName : tag.Description)?.ClearForXml() ?? string.Empty,
                        BaseUrlSummary: openApiDocument.Servers!.FirstOrDefault()?.Description?.ClearForXml() ?? string.Empty,
                        Settings: csharpSettings,
                        GlobalSettings: csharpGlobalSettings,
                        Converters: [],
                        HasOAuth2Support: hasOAuth2Support)))
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
        
        computeDataClassesTime.Stop();
#if NET
        var allocAfterClasses = GC.GetTotalAllocatedBytes(precise: true);
#endif

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
                FileNameWithoutExtension: $"{settings.Namespace}.",
                InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I",
                BaseUrl: string.Empty,
                Summary: string.Empty,
                Clients: [],
                BaseUrlSummary: string.Empty,
                Settings: csharpSettings,
                GlobalSettings: csharpGlobalSettings,
                Converters: converters),
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

        var authorizations = openApiDocument.Security!
            .SelectMany(requirement => requirement.OrderBy(x => x.Key.Name ?? string.Empty, StringComparer.Ordinal))
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(x.Key, settings, globalSettings))
            .Concat(methods.SelectMany(x => x.Authorizations))
            .GroupBy(x => x.FriendlyName)
            .Select(g => g.First())
            .ToArray();
        var hasOAuth2Support = authorizations.Any(static x => x.Type is SecuritySchemeType.OAuth2);

        var convertersBuilder = ImmutableArray.CreateBuilder<string>();
        foreach (var value in enums)
        {
            if (value.Style == ModelStyle.Enumeration &&
                !value.Settings.UsesNewtonsoftJson())
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

        Client[] clients = settings.GenerateSdk || settings.GenerateConstructors
            ? [new Client(
                Id: "MainConstructor",
                ClassName: settings.ClassName.Replace(".", string.Empty),
                FileNameWithoutExtension: $"{settings.Namespace}.{settings.ClassName.Replace(".", string.Empty)}",
                InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I{settings.ClassName.Replace(".", string.Empty)}",
                BaseUrl: openApiDocument.Servers!.FirstOrDefault().ExpandServerTemplate(),
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
                            Summary = (!string.IsNullOrWhiteSpace(tag.DisplayName) ? tag.DisplayName : tag.Description)?.ClearForXml() ?? string.Empty,
                        }).WithCSharpParameterName())
                    ]
                    : [],
                Summary: openApiDocument.Info?.Description?.ClearForXml() ?? string.Empty,
                BaseUrlSummary: openApiDocument.Servers!.FirstOrDefault()?.Description?.ClearForXml() ?? string.Empty,
                Settings: settings,
                GlobalSettings: globalSettings,
                Converters: converters,
                HasOAuth2Support: hasOAuth2Support)]
            : [];

        if (settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors))
        {
            clients = clients.Concat(
                    resolvedIncludedTags.Select(tag => new Client(
                        Id: "Constructors",
                        ClassName: CSharpClientNameGenerator.Generate(tag),
                        FileNameWithoutExtension: $"{settings.Namespace}.{CSharpClientNameGenerator.Generate(tag)}",
                        InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I{CSharpClientNameGenerator.Generate(tag)}",
                        BaseUrl: openApiDocument.Servers!.FirstOrDefault().ExpandServerTemplate(),
                        Clients: [],
                        Summary: (!string.IsNullOrWhiteSpace(tag.DisplayName) ? tag.DisplayName : tag.Description)?.ClearForXml() ?? string.Empty,
                        BaseUrlSummary: openApiDocument.Servers!.FirstOrDefault()?.Description?.ClearForXml() ?? string.Empty,
                        Settings: settings,
                        GlobalSettings: globalSettings,
                        Converters: [],
                        HasOAuth2Support: hasOAuth2Support)))
                .ToArray();
        }

        var types = settings.GenerateJsonSerializerContextTypes
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

        computeDataClassesTime.Stop();
#if NET
        var allocAfterClasses = GC.GetTotalAllocatedBytes(precise: true);
#endif

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
                FileNameWithoutExtension: $"{settings.Namespace}.",
                InterfaceFileNameWithoutExtension: $"{settings.Namespace}.I",
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
            contentType.Contains("application/json", StringComparison.OrdinalIgnoreCase));
        var hasNdjson = responseContentTypes.Any(static contentType =>
            contentType.Contains("application/x-ndjson", StringComparison.OrdinalIgnoreCase));
        var hasSse = responseContentTypes.Any(static contentType =>
            contentType.Contains("text/event-stream", StringComparison.OrdinalIgnoreCase));

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
            !hasNdjson)
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
                forcedRequestStreamValue: hasNdjson || hasSse ? false : null,
                successResponseOverride: fernStreaming?.RegularResponseOverride));
        }

        if (hasSse)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPoint(
                operation,
                preferredMimeType: "text/event-stream",
                methodNameSuffix: GetStreamMethodSuffix(
                    hasRegularJsonVariant: hasJson,
                    hasAnotherStreamingVariant: hasNdjson,
                    streamFormat: StreamFormat.ServerSentEvents),
                forcedRequestStreamValue: hasJson ? true : null,
                successResponseOverride: fernStreaming?.StreamResponseOverride,
                streamFormatOverride: fernStreaming?.StreamFormat == StreamFormat.ServerSentEvents
                    ? fernStreaming.StreamFormat
                    : null,
                streamTerminator: fernStreaming?.Terminator));
        }

        if (hasNdjson)
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
            responseContentTypes.Any(static x => x.Contains("text/event-stream", StringComparison.OrdinalIgnoreCase)))
        {
            return "text/event-stream";
        }

        if (streamFormat == StreamFormat.Ndjson &&
            responseContentTypes.Any(static x => x.Contains("application/x-ndjson", StringComparison.OrdinalIgnoreCase)))
        {
            return "application/x-ndjson";
        }

        if (responseContentTypes.Any(static x => x.Contains("application/json", StringComparison.OrdinalIgnoreCase)))
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
