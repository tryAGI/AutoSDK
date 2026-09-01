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
        return CSharpPipeline.PrepareAndEnrich(tuple, cancellationToken);
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
        var collectSchemasTime = Stopwatch.StartNew();
        var polymorphicArraysTime = Stopwatch.StartNew();
        var (suppressedLegacyPolymorphicSchemas, generatedPolymorphicTypes) =
            CollectPolymorphicArrayGenerationState(filteredSchemas, settings);
        polymorphicArraysTime.Stop();
#if NET
        var allocAfterPolymorphicArrays = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var schemaModelsTime = Stopwatch.StartNew();
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
            if (IsSuppressedLegacyPolymorphicSchema(schema, suppressedLegacyPolymorphicSchemas))
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
        schemaModelsTime.Stop();
        collectSchemasTime.Stop();
#if NET
        var allocAfterCollectSchemas = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var operationsTime = Stopwatch.StartNew();
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
        operationsTime.Stop();
#if NET
        var allocAfterOperations = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var endPointsTime = Stopwatch.StartNew();
        var endPointCreationCache = new CSharpEndPointFactory.EndPointCreationCache();
        var methods = ImmutableArray.CreateBuilder<EndPoint>(filteredOperations.Length);
        foreach (var operation in filteredOperations)
        {
            methods.AddRange(CreateEndPoints(
                operation,
                anyOfDatas,
                endPointCreationCache));
        }
        endPointsTime.Stop();
#if NET
        var allocAfterEndPoints = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var authorizationsTime = Stopwatch.StartNew();
        var authorizationsByIdentity = AuthorizationHelpers.CreateResolvedAuthorizationMap(
            (openApiDocument.Security ?? [])
            .SelectMany(requirement => requirement.OrderBy(
                x => x.Key.Reference?.Id ?? x.Key.Name ?? x.Key.Scheme ?? string.Empty,
                StringComparer.Ordinal))
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(x.Key, settings, globalSettings))
            .Concat(methods.SelectMany(x => x.Authorizations)));
        for (var index = 0; index < methods.Count; index++)
        {
            methods[index] = AuthorizationHelpers.NormalizeEndPoint(methods[index], authorizationsByIdentity);
        }
        authorizationsTime.Stop();
#if NET
        var allocAfterAuthorizations = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var convertersTime = Stopwatch.StartNew();
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
        convertersTime.Stop();
#if NET
        var allocAfterConverters = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var tagsAndClientsTime = Stopwatch.StartNew();
        var activeTagNames = new HashSet<string>(
            methods.Select(m => m.Tag.Name),
            StringComparer.Ordinal);
        var activeIncludedTags = includedTags
            .Where(tag => tag.Name != null && activeTagNames.Contains(tag.Name))
            .ToArray();
        var resolvedIncludedTagsMap = CSharpClientNameGenerator.ResolveTags(settings, activeIncludedTags);
        for (var index = 0; index < methods.Count; index++)
        {
            methods[index] = ResolveEndPointTag(methods[index], resolvedIncludedTagsMap);
        }
        methods.Sort(static (left, right) =>
        {
            var tagComparison = StringComparer.Ordinal.Compare(left.Tag.SafeName, right.Tag.SafeName);
            return tagComparison != 0
                ? tagComparison
                : StringComparer.Ordinal.Compare(left.NotAsyncMethodName, right.NotAsyncMethodName);
        });
        var resolvedIncludedTags = activeIncludedTags
            .Select(tag => resolvedIncludedTagsMap[tag.Name!])
            .OrderBy(tag => tag.SafeName, StringComparer.Ordinal)
            .ToArray();
        var hasIdempotencySupport = methods.Any(static method => method.Parameters.Any(static parameter => parameter.IsIdempotencyHeader));
        var rootClassName = settings.ClassName.Replace(".", string.Empty);
        var documentServers = CSharpServerFactory.CreateServerOptions(openApiDocument.Servers);
        var clientServersByClass = BuildClientServerMap(methods, rootClassName, documentServers);
        var usesServerSelectionSupport = clientServersByClass.Values.Any(static servers => servers.Length > 1);
        ApplyClientServerSelectionSupport(methods, clientServersByClass, usesServerSelectionSupport);
        ApplyLocationWaitCompanions(methods);
        ApplyPageableMetadata(methods, classes, settings);
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
                UsesServerSelectionSupport: usesServerSelectionSupport,
                NeedsScopedServerResolver: NeedsScopedServerResolver(rootClassName, methods))]
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
                        UsesServerSelectionSupport: usesServerSelectionSupport,
                        NeedsScopedServerResolver: NeedsScopedServerResolver(
                            CSharpClientNameGenerator.Generate(tag),
                            methods))))
                .ToArray();
        }
        tagsAndClientsTime.Stop();
#if NET
        var allocAfterTagsAndClients = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var jsonTypesAndOutputsTime = Stopwatch.StartNew();
        var types = CollectJsonSerializerContextTypes(
            filteredSchemas,
            generatedPolymorphicTypes,
            suppressedLegacyPolymorphicSchemas,
            skipModels,
            settings);

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
        jsonTypesAndOutputsTime.Stop();
#if NET
        var allocAfterJsonTypesAndOutputs = GC.GetTotalAllocatedBytes(precise: true);
#endif

        computeDataClassesTime.Stop();
#if NET
        var allocAfterClasses = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var dataEnrichmentTimes = new DataEnrichmentTimes(
            CollectSchemas: collectSchemasTime.Elapsed,
            Operations: operationsTime.Elapsed,
            EndPoints: endPointsTime.Elapsed,
            Authorizations: authorizationsTime.Elapsed,
            Converters: convertersTime.Elapsed,
            TagsAndClients: tagsAndClientsTime.Elapsed,
            JsonTypesAndOutputs: jsonTypesAndOutputsTime.Elapsed,
            PolymorphicArrays: polymorphicArraysTime.Elapsed,
            SchemaModels: schemaModelsTime.Elapsed
#if NET
            ,
            AllocCollectSchemas: allocAfterCollectSchemas - allocAfterData,
            AllocOperations: allocAfterOperations - allocAfterCollectSchemas,
            AllocEndPoints: allocAfterEndPoints - allocAfterOperations,
            AllocAuthorizations: allocAfterAuthorizations - allocAfterEndPoints,
            AllocConverters: allocAfterConverters - allocAfterAuthorizations,
            AllocTagsAndClients: allocAfterTagsAndClients - allocAfterConverters,
            AllocJsonTypesAndOutputs: allocAfterJsonTypesAndOutputs - allocAfterTagsAndClients,
            AllocPolymorphicArrays: allocAfterPolymorphicArrays - allocAfterData,
            AllocSchemaModels: allocAfterCollectSchemas - allocAfterPolymorphicArrays
#endif
        );

        return new Models.Data(
            Classes: outputClasses,
            Enums: outputEnums,
            Methods: methods.Capacity == methods.Count
                ? methods.MoveToImmutable()
                : methods.ToImmutable(),
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
                Total: totalTime.Elapsed,
                DataEnrichment: dataEnrichmentTimes
#if NET
                ,
                AllocParsing: coreTimes.AllocParsing,
                AllocTraversalTree: coreTimes.AllocTraversalTree,
                AllocNaming: allocAfterNaming - allocBefore,
                AllocResolveReferences: coreTimes.AllocResolveReferences,
                AllocFiltering: coreTimes.AllocFiltering,
                AllocComputeData: allocAfterData - allocAfterNaming,
                AllocComputeDataClasses: allocAfterClasses - allocAfterData,
                AllocFilterTags: coreTimes.AllocFilterTags,
                OpenApiParsing: coreTimes.OpenApiParsing
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

    private static void ApplyClientServerSelectionSupport(
        ImmutableArray<EndPoint>.Builder methods,
        Dictionary<string, EquatableArray<ServerOption>> clientServersByClass,
        bool usesServerSelectionSupport)
    {
        if (!usesServerSelectionSupport || methods.Count == 0)
        {
            return;
        }

        for (var index = 0; index < methods.Count; index++)
        {
            var method = methods[index];
            methods[index] = method with
            {
                UsesServerSelectionSupport = usesServerSelectionSupport,
                ClientUsesServerSelectionSupport =
                    clientServersByClass.TryGetValue(method.ClassName, out var servers) &&
                    servers.Length > 1,
            };
        }
    }

    private static bool NeedsScopedServerResolver(
        string className,
        IReadOnlyList<EndPoint> methods)
    {
        return methods.Any(method =>
            string.Equals(method.ClassName, className, StringComparison.Ordinal) &&
            method.UsesServerSelectionSupport &&
            method.HasServerOverride &&
            !method.ClientUsesServerSelectionSupport &&
            method.Servers.Length > 0);
    }

    /// <summary>
    /// Auto-detects offset/page-number pagination for endpoints that have a
    /// `page`/`page_number`/`pageIndex` query parameter and a 2XX response whose schema
    /// has exactly one array property. The result is stored on the endpoint's
    /// <see cref="EndPoint.PageableMetadata"/> so <see cref="Sources.Methods"/> can emit
    /// a <c>&lt;Method&gt;AutoPagingAsync</c> companion backed by
    /// <c>AutoSDKPager.OffsetAsync</c>.
    /// </summary>
    private static void ApplyPageableMetadata(
        ImmutableArray<EndPoint>.Builder methods,
        ImmutableArray<ModelData> classes,
        CSharpSettings settings)
    {
        if (!settings.GeneratePageableHelpers || methods.Count == 0)
        {
            return;
        }

        var classByName = classes
            .Where(static c => !string.IsNullOrEmpty(c.GlobalClassName))
            .ToDictionary(static c => c.GlobalClassName, static c => c, StringComparer.Ordinal);

        for (var index = 0; index < methods.Count; index++)
        {
            var method = methods[index];
            if (method.HttpMethod != System.Net.Http.HttpMethod.Get ||
                method.HasPageableHelper ||
                string.IsNullOrWhiteSpace(method.SuccessResponse.Type.CSharpType))
            {
                continue;
            }

            var responseClassName = method.SuccessResponse.Type.CSharpTypeWithoutNullability;
            if (!classByName.TryGetValue(responseClassName, out var responseClass))
            {
                continue;
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
                    itemsProperty = null;
                    break;
                }

                itemsProperty = property;
            }

            if (itemsProperty is null)
            {
                continue;
            }

            var itemType = itemsProperty.Value.Type.SubTypes[0].Unbox<TypeData>();

            // Offset style takes priority — it requires a known page-number query
            // parameter, which is a stronger signal than a cursor-named param.
            var pageParam = method.Parameters
                .FirstOrDefault(static p =>
                    p.Location == Microsoft.OpenApi.ParameterLocation.Query &&
                    IsOffsetPageParameter(p));
            if (!string.IsNullOrEmpty(pageParam.ParameterName))
            {
                // Also pick up a sibling has_more/has_next bool so the generated
                // auto-paging helper stops on an explicit "no more pages" signal
                // rather than waiting for an empty page.
                PropertyData? hasMoreProperty = null;
                foreach (var property in responseClass.Properties)
                {
                    if (!IsHasMoreProperty(property))
                    {
                        continue;
                    }

                    if (hasMoreProperty != null)
                    {
                        // Multiple has_more candidates → ambiguous, skip the predicate.
                        hasMoreProperty = null;
                        break;
                    }

                    hasMoreProperty = property;
                }

                methods[index] = method with
                {
                    PageableMetadata = new PageableMetadata(
                        Style: PageableStyle.Offset,
                        PageParameterName: pageParam.ParameterName,
                        ItemsPropertyName: itemsProperty.Value.Name,
                        ItemType: itemType,
                        NextCursorPropertyName: string.Empty,
                        HasMorePropertyName: hasMoreProperty?.Name ?? string.Empty,
                        HasMorePropertyIsNullable: hasMoreProperty?.Type.CSharpTypeNullability ?? false),
                };
                continue;
            }

            // Cursor style: known cursor-named query parameter (string-typed) plus
            // a response property that exposes the next cursor / next page token.
            var cursorParam = method.Parameters
                .Where(static p =>
                    p.Location == Microsoft.OpenApi.ParameterLocation.Query &&
                    IsCursorPageParameter(p))
                .OrderByDescending(static p => GetCursorPageParameterPriority(p.Id))
                .FirstOrDefault();
            if (string.IsNullOrEmpty(cursorParam.ParameterName))
            {
                continue;
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
                    nextCursorProperty = null;
                    break;
                }

                nextCursorProperty = property;
            }

            if (nextCursorProperty is null)
            {
                continue;
            }

            methods[index] = method with
            {
                PageableMetadata = new PageableMetadata(
                    Style: PageableStyle.Cursor,
                    PageParameterName: cursorParam.ParameterName,
                    ItemsPropertyName: itemsProperty.Value.Name,
                    ItemType: itemType,
                    NextCursorPropertyName: nextCursorProperty.Value.Name),
            };
        }
    }

    private static bool IsOffsetPageParameter(MethodParameter parameter)
    {
        if (string.IsNullOrEmpty(parameter.Id) ||
            !IsNumericPageParameterType(parameter.Type))
        {
            return false;
        }

        return string.Equals(parameter.Id, "page", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameter.Id, "page_number", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameter.Id, "pageNumber", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameter.Id, "pageIndex", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(parameter.Id, "page_index", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsCursorPageParameter(MethodParameter parameter)
    {
        if (string.IsNullOrEmpty(parameter.Id) ||
            parameter.Type.IsArray ||
            !string.Equals(parameter.Type.CSharpTypeWithoutNullability, "string", StringComparison.Ordinal))
        {
            return false;
        }

        return GetCursorPageParameterPriority(parameter.Id) > 0;
    }

    private static int GetCursorPageParameterPriority(string parameterId)
    {
        if (string.IsNullOrEmpty(parameterId))
        {
            return 0;
        }

        if (string.Equals(parameterId, "after", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "after_id", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "afterId", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "starting_after", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "startingAfter", StringComparison.OrdinalIgnoreCase))
        {
            return 3;
        }

        if (string.Equals(parameterId, "cursor", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "page", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "page_token", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "pageToken", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "next_page", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "nextPage", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "next_page_token", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "nextPageToken", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "pagination_token", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(parameterId, "paginationToken", StringComparison.OrdinalIgnoreCase))
        {
            return 2;
        }

        return 0;
    }

    private static bool IsNumericPageParameterType(TypeData type)
    {
        return string.Equals(type.CSharpTypeWithoutNullability, "int", StringComparison.Ordinal) ||
               string.Equals(type.CSharpTypeWithoutNullability, "long", StringComparison.Ordinal);
    }

    private static bool IsHasMoreProperty(PropertyData property)
    {
        if (string.IsNullOrEmpty(property.Id) ||
            property.Type.IsArray ||
            !string.Equals(property.Type.CSharpTypeWithoutNullability, "bool", StringComparison.Ordinal))
        {
            return false;
        }

        return string.Equals(property.Id, "has_more", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "hasMore", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "has_next", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "hasNext", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "more", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "has_next_page", StringComparison.OrdinalIgnoreCase) ||
               string.Equals(property.Id, "hasNextPage", StringComparison.OrdinalIgnoreCase);
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
    private static void ApplyLocationWaitCompanions(
        ImmutableArray<EndPoint>.Builder methods)
    {
        if (!methods.Any(static m =>
                m.HasLocationHeaderOnSuccess &&
                m.HttpMethod != System.Net.Http.HttpMethod.Get))
        {
            return;
        }

        var pollingHelpersByPath = methods
            .Where(static m =>
                m.HttpMethod == System.Net.Http.HttpMethod.Get &&
                !m.PollingOperations.IsEmpty &&
                !string.IsNullOrEmpty(m.Path))
            .ToDictionary(static m => UnwrapPreparedPath(m.Path), static m => m, StringComparer.Ordinal);
        if (pollingHelpersByPath.Count == 0)
        {
            return;
        }

        for (var index = 0; index < methods.Count; index++)
        {
            var method = methods[index];
            if (!method.HasLocationHeaderOnSuccess ||
                method.HttpMethod == System.Net.Http.HttpMethod.Get ||
                string.IsNullOrEmpty(method.Path))
            {
                continue;
            }

            var sibling = FindLocationSiblingGet(method, pollingHelpersByPath);
            if (sibling == null)
            {
                continue;
            }

            var siblingValue = sibling.Value;
            var pollingOperation = siblingValue.PollingOperations.FirstOrDefault();
            if (pollingOperation.Name is null or { Length: 0 })
            {
                continue;
            }

            var idParameter = siblingValue.Parameters
                .FirstOrDefault(static p =>
                    p.Location == Microsoft.OpenApi.ParameterLocation.Path);
            if (string.IsNullOrEmpty(idParameter.ParameterName))
            {
                continue;
            }

            methods[index] = method with
            {
                LocationWaitCompanion = new LocationWaitCompanion(
                    SiblingMethodName: siblingValue.NotAsyncMethodName,
                    SiblingPollingMethodName:
                        $"{siblingValue.NotAsyncMethodName}{pollingOperation.Name.ToPropertyName()}Async",
                    SiblingPath: siblingValue.Path,
                    SiblingIdParameterName: idParameter.ParameterName,
                    SiblingReturnType: siblingValue.SuccessResponse.Type),
            };
        }
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

    private static List<EndPoint> CreateEndPoints(
        OperationContext operation,
        IReadOnlyCollection<AnyOfData> anyOfDatas,
        CSharpEndPointFactory.EndPointCreationCache endPointCreationCache)
    {
        var fernStreaming = FernStreamingMetadata.TryCreate(operation);
        var responseContentTypes = (operation.Operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            .SelectMany(response => (response.Value?.Content ?? new Dictionary<string, IOpenApiMediaType>())
                .Where(_ => response.Key.StartsWith("2", StringComparison.OrdinalIgnoreCase))
                .Select(content => content.Key))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToArray();
        var supportedResponseContentTypes = responseContentTypes
            .Where(static contentType =>
                MediaTypeCapabilities.GetResponseSupport(contentType) != MediaTypeTransportSupport.Unsupported)
            .ToArray();

        if (responseContentTypes.Length > 0 && supportedResponseContentTypes.Length == 0)
        {
            throw new InvalidOperationException(
                $"AutoSDK cannot decode any success response representation for " +
                $"'{operation.OperationType.Method.ToUpperInvariant()} {operation.OperationPath}'. " +
                $"Unsupported media types: {string.Join(", ", responseContentTypes)}. " +
                "Add a JSON, text, binary, or supported streaming representation.");
        }

        var hasJson = supportedResponseContentTypes.Any(static contentType =>
            contentType.IsJsonMimeType() && !contentType.IsSequentialJsonMimeType());
        var hasSequentialJson = supportedResponseContentTypes.Any(static contentType =>
            contentType.IsSequentialJsonMimeType());
        var hasSse = supportedResponseContentTypes.Any(static contentType =>
            contentType.IsServerSentEventsMimeType());

        var endPoints = new List<EndPoint>();

        if (fernStreaming?.HasRequestStreamCondition == true)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPointWithCache(
                operation,
                endPointCreationCache,
                preferredMimeType: "application/json",
                forcedRequestStreamValue: false,
                successResponseOverride: fernStreaming.RegularResponseOverride,
                anyOfDatas: anyOfDatas) with
            {
                AcceptMediaType = "application/json",
            });
            var fernStreamMediaType = GetPreferredStreamMimeType(supportedResponseContentTypes, fernStreaming.StreamFormat);
            endPoints.Add(CSharpEndPointFactory.CreateEndPointWithCache(
                operation,
                endPointCreationCache,
                preferredMimeType: fernStreamMediaType,
                methodNameSuffix: GetStreamMethodSuffix(
                    hasRegularJsonVariant: true,
                    hasAnotherStreamingVariant: false,
                    streamFormat: fernStreaming.StreamFormat),
                forcedRequestStreamValue: true,
                successResponseOverride: fernStreaming.StreamResponseOverride,
                streamFormatOverride: fernStreaming.StreamFormat,
                streamTerminator: fernStreaming.Terminator,
                anyOfDatas: anyOfDatas) with
            {
                AcceptMediaType = fernStreamMediaType ?? string.Empty,
            });
            return endPoints;
        }

        if (fernStreaming != null &&
            !hasSse &&
            !hasSequentialJson)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPointWithCache(
                operation,
                endPointCreationCache,
                preferredMimeType: GetPreferredStreamMimeType(supportedResponseContentTypes, fernStreaming.StreamFormat),
                successResponseOverride: fernStreaming.StreamResponseOverride ?? fernStreaming.RegularResponseOverride,
                streamFormatOverride: fernStreaming.StreamFormat,
                streamTerminator: fernStreaming.Terminator,
                anyOfDatas: anyOfDatas));
            return endPoints;
        }

        if (supportedResponseContentTypes.Length == 0)
        {
            endPoints.Add(CSharpEndPointFactory.CreateEndPointWithCache(
                operation,
                endPointCreationCache,
                successResponseOverride: fernStreaming?.RegularResponseOverride,
                anyOfDatas: anyOfDatas));
            return endPoints;
        }

        var hasRegularResponse = supportedResponseContentTypes.Any(static contentType =>
            MediaTypeCapabilities.GetResponseSupport(contentType) != MediaTypeTransportSupport.Streaming);
        var hasStreamingResponse = supportedResponseContentTypes.Any(static contentType =>
            MediaTypeCapabilities.GetResponseSupport(contentType) == MediaTypeTransportSupport.Streaming);
        var orderedContentTypes = supportedResponseContentTypes
            .OrderByDescending(static contentType =>
                contentType.IsJsonMimeType() && !contentType.IsSequentialJsonMimeType())
            .ThenByDescending(static contentType =>
                MediaTypeCapabilities.GetResponseSupport(contentType) != MediaTypeTransportSupport.Streaming)
            .ToArray();
        var prototypes = orderedContentTypes
            .Select(contentType => CSharpEndPointFactory.CreateEndPointWithCache(
                operation,
                endPointCreationCache,
                preferredMimeType: contentType,
                forcedRequestStreamValue: hasRegularResponse && hasStreamingResponse
                    ? MediaTypeCapabilities.GetResponseSupport(contentType) == MediaTypeTransportSupport.Streaming
                    : null,
                streamTerminator: fernStreaming?.Terminator,
                anyOfDatas: anyOfDatas))
            .ToArray();
        var distinctPrototypes = prototypes
            .GroupBy(static endPoint => (
                endPoint.StreamFormat,
                endPoint.ContentType,
                endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability))
            .Select(static group => group.First())
            .ToArray();
        var hasBufferedBinaryStreamCompanion = distinctPrototypes.Any(static candidate =>
            !candidate.EnumerableStream &&
            candidate.ContentType == ContentType.ByteArray &&
            candidate.SuccessResponse.Type.IsBinary &&
            candidate.SuccessResponse.Type.CSharpTypeWithoutNullability == "byte[]");

        if (distinctPrototypes.Length == 1)
        {
            endPoints.Add(distinctPrototypes[0]);
            return endPoints;
        }

        for (var index = 0; index < distinctPrototypes.Length; index++)
        {
            var prototype = distinctPrototypes[index];
            var suffix = index == 0
                ? null
                : GetResponseMethodSuffix(
                    prototype,
                    hasRegularResponse,
                    distinctPrototypes.Count(static candidate => candidate.EnumerableStream),
                    hasBufferedBinaryStreamCompanion);
            var candidate = index == 0
                ? prototype
                : CSharpEndPointFactory.CreateEndPointWithCache(
                    operation,
                    endPointCreationCache,
                    preferredMimeType: prototype.SuccessResponse.MimeType,
                    methodNameSuffix: suffix,
                    forcedRequestStreamValue: hasRegularResponse && hasStreamingResponse
                        ? prototype.EnumerableStream
                        : null,
                    streamTerminator: fernStreaming?.Terminator,
                    anyOfDatas: anyOfDatas);
            endPoints.Add(candidate with { AcceptMediaType = candidate.SuccessResponse.MimeType });
        }

        return endPoints;
    }

    private static string GetResponseMethodSuffix(
        EndPoint endPoint,
        bool hasRegularResponse,
        int streamingVariantCount,
        bool hasBufferedBinaryStreamCompanion)
    {
        if (endPoint.EnumerableStream)
        {
            if (hasBufferedBinaryStreamCompanion &&
                endPoint.StreamFormat == StreamFormat.ServerSentEvents)
            {
                return "AsEventStream";
            }

            return GetStreamMethodSuffix(
                       hasRegularJsonVariant: hasRegularResponse,
                       hasAnotherStreamingVariant: streamingVariantCount > 1,
                       streamFormat: endPoint.StreamFormat) ??
                   "AsStream";
        }

        return MediaTypeCapabilities.Classify(endPoint.SuccessResponse.MimeType) switch
        {
            MediaTypeKind.Json => "AsJson",
            MediaTypeKind.Text => "AsText",
            MediaTypeKind.Binary or
            MediaTypeKind.MessagePack or
            MediaTypeKind.Protobuf or
            MediaTypeKind.VendorSpecific => "AsBytes",
            _ => "As" + endPoint.SuccessResponse.MimeType
                .NormalizeMimeType()
                .Replace("application/", string.Empty)
                .Replace("text/", string.Empty)
                .Replace("+", "-")
                .ToPropertyName(),
        };
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

    private static (HashSet<SchemaContext> SuppressedSchemas, ImmutableArray<TypeData> GeneratedTypes)
        CollectPolymorphicArrayGenerationState(
            IReadOnlyList<SchemaContext> filteredSchemas,
            CSharpSettings settings)
    {
        if (!settings.GeneratePolymorphicArrayHelpers)
        {
            return ([], []);
        }

        var plans = Sources.BuildPolymorphicFormatEmissionPlans(filteredSchemas);
        if (plans.Count == 0)
        {
            return ([], []);
        }

        var suppressedSchemas = new HashSet<SchemaContext>();
        var generatedTypes = ImmutableArray.CreateBuilder<TypeData>();

        foreach (var plan in plans)
        {
            suppressedSchemas.UnionWith(plan.SuppressedSchemas);
            generatedTypes.AddRange(plan.GeneratedTypes);
        }

        return (
            suppressedSchemas,
            generatedTypes
                .GroupBy(static type => type.CSharpTypeWithNullability, StringComparer.Ordinal)
                .Select(static group => group.First())
                .ToImmutableArray());
    }

    private static bool IsSuppressedLegacyPolymorphicSchema(
        SchemaContext schema,
        HashSet<SchemaContext> suppressedSchemas)
    {
        return suppressedSchemas.Count > 0 &&
               suppressedSchemas.Contains(schema);
    }

    private static ImmutableArray<TypeData> CollectJsonSerializerContextTypes(
        IReadOnlyList<SchemaContext> filteredSchemas,
        ImmutableArray<TypeData> generatedPolymorphicTypes,
        HashSet<SchemaContext> suppressedSchemas,
        bool skipModels,
        CSharpSettings settings)
    {
        if (skipModels || !settings.GenerateJsonSerializerContextTypes)
        {
            return [];
        }

        var seenTypes = new HashSet<string>(StringComparer.Ordinal);
        for (var index = 0; index < filteredSchemas.Count; index++)
        {
            var schema = filteredSchemas[index];
            if (!IsSuppressedLegacyPolymorphicSchema(schema, suppressedSchemas) &&
                schema.TypeData != TypeData.Default &&
                !string.IsNullOrWhiteSpace(schema.TypeData.CSharpType))
            {
                seenTypes.Add(schema.TypeData.CSharpTypeWithNullability);
            }
        }
        for (var index = 0; index < generatedPolymorphicTypes.Length; index++)
        {
            seenTypes.Add(generatedPolymorphicTypes[index].CSharpTypeWithNullability);
        }

        var typesBuilder = ImmutableArray.CreateBuilder<TypeData>(seenTypes.Count);
        seenTypes.Clear();
        for (var index = 0; index < filteredSchemas.Count; index++)
        {
            var schema = filteredSchemas[index];
            if (!IsSuppressedLegacyPolymorphicSchema(schema, suppressedSchemas) &&
                schema.TypeData != TypeData.Default &&
                !string.IsNullOrWhiteSpace(schema.TypeData.CSharpType) &&
                seenTypes.Add(schema.TypeData.CSharpTypeWithNullability))
            {
                typesBuilder.Add(schema.TypeData);
            }
        }
        for (var index = 0; index < generatedPolymorphicTypes.Length; index++)
        {
            var type = generatedPolymorphicTypes[index];
            if (seenTypes.Add(type.CSharpTypeWithNullability))
            {
                typesBuilder.Add(type);
            }
        }
        var types = typesBuilder.MoveToImmutable();

        if (!settings.DirectionAwareJsonGenerationMode)
        {
            return types;
        }

        return JsonSerializationDirectionAnalyzer.ApplyDirections(
            types,
            JsonSerializationDirectionAnalyzer.Analyze(filteredSchemas));
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
