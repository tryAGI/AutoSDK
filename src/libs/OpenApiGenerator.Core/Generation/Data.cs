using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static class Data
{
    public static Models.Data Prepare(
        (string text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;

        var openApiDocument = text.GetOpenApiDocument(cancellationToken);

        var allOperations = openApiDocument.Paths!
            .SelectMany(x => x.Value.Operations.Select(y => (OperationPath: x.Key, OperationType: y.Key, Operation: y.Value)))
            .ToArray();
        var schemaContexts = openApiDocument.Components!.Schemas!
            .SelectMany(schema => SchemaContext.FromSchema(
                schema: schema.Value,
                settings: settings,
                componentId: schema.Key))
            .Concat(allOperations
                .Where(x => x.Operation.RequestBody != null)
                .SelectMany(x => x.Operation.RequestBody!.Content.Select(y => (x.OperationPath, x.OperationType, x.Operation, ContentType: y.Key, MediaType: y.Value)))
                .Where(x => x.MediaType.Schema != null)
                .SelectMany(x => SchemaContext.FromSchema(
                    schema: x.MediaType.Schema!,
                    settings: settings,
                    operationPath: x.OperationPath,
                    operationType: x.OperationType,
                    operation: x.Operation,
                    contentType: x.ContentType,
                    mediaType: x.MediaType,
                    hint: Hint.Request)))
            .Concat(allOperations
                .SelectMany(x => (x.Operation.Parameters ?? []).Select(y => (x.OperationPath, x.OperationType, x.Operation, Parameter: y)))
                .SelectMany(x => x.Parameter.Content.Select(y => (x.OperationPath, x.OperationType, x.Operation, x.Parameter, ContentType: y.Key, MediaType: y.Value)))
                .Where(x => x.MediaType.Schema != null)
                .SelectMany(x => SchemaContext.FromSchema(
                    schema: x.MediaType.Schema!,
                    settings: settings,
                    operationPath: x.OperationPath,
                    operationType: x.OperationType,
                    operation: x.Operation,
                    contentType: x.ContentType,
                    mediaType: x.MediaType,
                    parameter: x.Parameter,
                    hint: Hint.Parameter)))
            .Concat(allOperations
                .SelectMany(x => (x.Operation.Responses ?? []).Select(y => (x.OperationPath, x.OperationType, x.Operation, ResponseStatusCode: y.Key, Response: y.Value)))
                .SelectMany(x => x.Response.Content.Select(y => (x.OperationPath, x.OperationType, x.Operation, x.ResponseStatusCode, x.Response, ContentType: y.Key, MediaType: y.Value)))
                .Where(x => x.MediaType.Schema != null)
                .SelectMany(x => SchemaContext.FromSchema(
                    schema: x.MediaType.Schema!,
                    settings: settings,
                    operationPath: x.OperationPath,
                    operationType: x.OperationType,
                    operation: x.Operation,
                    contentType: x.ContentType,
                    mediaType: x.MediaType,
                    responseStatusCode: x.ResponseStatusCode,
                    response: x.Response,
                    hint: Hint.Response)))
            .ToArray();
        
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
            foreach (var tag in operation.Tags ?? Array.Empty<OpenApiTag>())
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

        var includedModels = new HashSet<string>(settings.IncludeModels);
        var excludedModels = new HashSet<string>(settings.ExcludeModels);
        foreach (var tag in settings.IncludeTags)
        {
            includedModels.UnionWith(openApiDocument.FindAllModelsForTag(tag));
        }
        foreach (var tag in settings.ExcludeTags)
        {
            excludedModels.UnionWith(openApiDocument.FindAllModelsForTag(tag));
        }
        var referencesOfIncludedModels = includedModels.Count == 0
            ? []
            : new HashSet<string>(openApiDocument.Components.Schemas!
                .Where(schema =>
                    (includedModels.Count == 0 ||
                    includedModels.Contains(schema.Key)) &&
                    !excludedModels.Contains(schema.Key))
                .SelectMany(schema => schema.GetReferences())
                .Select(reference => reference.Id));

        var includedSchemas = openApiDocument.Components.Schemas!
            .Where(schema =>
                (includedModels.Count == 0 ||
                 includedModels.Contains(schema.Key) ||
                 referencesOfIncludedModels.Contains(schema.Key)) &&
                !excludedModels.Contains(schema.Key))
            .ToArray();
        Dictionary<string, ModelData> classes = includedSchemas
            .SelectMany(schema => ModelData.FromSchemas(schema.Value, settings, schema.Key))
            .SelectMany(model => model.WithAdditionalModels())
            .GroupBy(x => x.ClassName)
            .Select(x => x.First())
            .ToDictionary(x => x.ClassName, x => x);

        var operations = openApiDocument.Paths!.SelectMany(path =>
                path.Value.Operations
                    .Where(x =>
                    {
                        if (settings.ExcludeDeprecatedOperations &&
                            x.Value.Deprecated)
                        {
                            return false;
                        }
                        if (includedOperationIds.Count == 0 && excludedOperationIds.Count == 0)
                        {
                            return true;
                        }
                    
                        var methodName = x.Value.GetMethodName(path: path.Key, operationType: x.Key,
                            settings.MethodNamingConvention, settings.MethodNamingConventionFallback);
                    
                        return (includedOperationIds.Count == 0 ||
                                includedOperationIds.Contains(methodName) ||
                                (x.Value.OperationId != null && includedOperationIds.Contains(x.Value.OperationId))) &&
                               !excludedOperationIds.Contains(methodName) &&
                               (x.Value.OperationId == null || !excludedOperationIds.Contains(x.Value.OperationId));
                    })
                    .Select(x => (Path: path, Operation: x)))
            .ToArray();
        
        var operationsAsMethods = operations
            .Select(x => EndPoint.FromSchema(x.Operation, settings, x.Path.Key))
            .ToArray();
        var authorizations = openApiDocument.SecurityRequirements!
            .SelectMany(requirement => requirement)
            .Select(x => Authorization.FromOpenApiSecurityScheme(x.Key, settings))
            .ToArray();
        
        var includedTags = allTags
            .Where(x =>
                (settings.IncludeTags.Length == 0 ||
                 settings.IncludeTags.Contains(x.Name)) &&
                !settings.ExcludeTags.Contains(x.Name))
            .ToArray();
        EndPoint[] constructors = settings.GenerateSdk || settings.GenerateConstructors ? [new EndPoint(
                Id: "MainConstructor",
                Namespace: settings.Namespace,
                ClassName: settings.ClassName.Replace(".", string.Empty),
                BaseUrl: openApiDocument.Servers!.FirstOrDefault()?.Url ?? string.Empty,
                Stream: false,
                Path: string.Empty,
                RequestMediaType: string.Empty,
                Properties: settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors)
                    ? [
                        .. includedTags.Select(x => PropertyData.Default with
                        {
                            Name = PropertyData.SanitizeName(x.Name.ToClassName(), settings.ClsCompliantEnumPrefix),
                            Type = TypeData.Default with
                            {
                                CSharpType = $"{x.Name.ToClassName()}Client",
                            },
                            Summary = x.Description ?? string.Empty,
                        })
                    ]
                    : [],
                HttpMethod: OperationType.Get,
                ContentType: ContentType.String,
                Summary: openApiDocument.Info?.Description?.ClearForXml() ?? string.Empty,
                BaseUrlSummary: openApiDocument.Servers!.FirstOrDefault()?.Description?.ClearForXml() ?? string.Empty,
                Settings: settings,
                IsDeprecated: false,
                IsMultipartFormData: false,
                RequestType: TypeData.Default,
                ResponseType: TypeData.Default,
                AdditionalModels: [],
                AdditionalTypes: [],
                Converters: [])] : [];
        if (settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors))
        {
            constructors = constructors.Concat(
                includedTags
                    .Select(x => new EndPoint(
                        Id: "Constructors",
                        Namespace: settings.Namespace,
                        ClassName: $"{x.Name.ToClassName()}Client",
                        BaseUrl: openApiDocument.Servers!.FirstOrDefault()?.Url ?? string.Empty,
                        Stream: false,
                        Path: string.Empty,
                        RequestMediaType: string.Empty,
                        Properties: ImmutableArray<PropertyData>.Empty,
                        HttpMethod: OperationType.Get,
                        ContentType: ContentType.String,
                        Summary: x.Description?.ClearForXml() ?? string.Empty,
                        BaseUrlSummary: openApiDocument.Servers!.FirstOrDefault()?.Description?.ClearForXml() ?? string.Empty,
                        Settings: settings,
                        IsDeprecated: false,
                        IsMultipartFormData: false,
                        RequestType: TypeData.Default,
                        ResponseType: TypeData.Default,
                        AdditionalModels: [],
                        AdditionalTypes: [],
                        Converters: [])))
                .ToArray();
        }
            
        EndPoint[] methods = [
            ..operationsAsMethods,
            ..constructors,
        ];
        
        var isTrimming =
            settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
            (!string.IsNullOrWhiteSpace(settings.JsonSerializerContext) ||
             settings.GenerateJsonSerializerContextTypes);
        var allSchemas = settings.GenerateSdk || settings.GenerateModels ? classes.Values.Concat(methods
                .SelectMany(x => x.AdditionalModels))
            .SelectMany(x => x.Schema.Value.Properties.Values
                .Concat(x.Schema.Value.AnyOf)
                .Concat(x.Schema.Value.OneOf)
                .Concat(x.Schema.Value.AllOf)
                .Concat([x.Schema.Value])
                .ToArray())
            .ToArray() : [];
        var anyOfs = allSchemas
            .Where(x => x.AnyOf is { Count: > 0 })
            .Select(x => new AnyOfData("AnyOf", x.AnyOf.Count, settings.JsonSerializerType, isTrimming, "System", string.Empty, string.Empty, ImmutableArray<PropertyData>.Empty))
            .Concat(allSchemas
                .Where(x => x.Items?.AnyOf is { Count: > 0 })
                .Select(x => new AnyOfData("AnyOf", x.Items.AnyOf.Count, settings.JsonSerializerType, isTrimming, "System", string.Empty, string.Empty, ImmutableArray<PropertyData>.Empty)))
            .Distinct()
            .ToImmutableArray();
        var oneOfs = allSchemas
            .Where(x => x.OneOf is { Count: > 0 })
            .Select(x => new AnyOfData("OneOf", x.OneOf.Count, settings.JsonSerializerType, isTrimming, "System", string.Empty, string.Empty, ImmutableArray<PropertyData>.Empty))
            .Concat(allSchemas
                .Where(x => x.Items?.OneOf is { Count: > 0 })
                .Select(x => new AnyOfData("OneOf", x.Items.OneOf.Count, settings.JsonSerializerType, isTrimming, "System", string.Empty, string.Empty, ImmutableArray<PropertyData>.Empty)))
            .Distinct()
            .ToImmutableArray();
        var allOfs = allSchemas
            .Where(x => x.AllOf is { Count: > 0 })
            .Select(x => new AnyOfData("AllOf", x.AllOf.Count, settings.JsonSerializerType, isTrimming, "System", string.Empty, string.Empty, ImmutableArray<PropertyData>.Empty))
            .Concat(allSchemas
                .Where(x => x.Items?.AllOf is { Count: > 0 })
                .Select(x => new AnyOfData("AllOf", x.Items.AllOf.Count, settings.JsonSerializerType, isTrimming, "System", string.Empty, string.Empty, ImmutableArray<PropertyData>.Empty)))
            .Distinct()
            .ToImmutableArray();
        anyOfs = settings.GenerateSdk || settings.GenerateModels ? anyOfs
            .Concat(includedSchemas
                .Where(x => x.Value.AnyOf is { Count: >0 })
                .Select(schema => new AnyOfData(
                    "AnyOf",
                    schema.Value.AnyOf.Count,
                    settings.JsonSerializerType,
                    isTrimming,
                    settings.Namespace,
                    schema.Key.ToClassName(),
                    schema.Value.GetSummary(),
                    schema.Value.AnyOf.ToAnyOfProperties(settings, schema.Key))))
            .ToImmutableArray() : [];
        oneOfs = settings.GenerateSdk || settings.GenerateModels ? oneOfs
            .Concat(includedSchemas
                .Where(x => x.Value.OneOf is { Count: >0 })
                .Select(schema => new AnyOfData(
                    "OneOf",
                    schema.Value.OneOf.Count,
                    settings.JsonSerializerType,
                    isTrimming,
                    settings.Namespace,
                    schema.Key.ToClassName(),
                    schema.Value.GetSummary(),
                    schema.Value.OneOf.ToAnyOfProperties(settings, schema.Key))))
            .ToImmutableArray() : [];
        allOfs = settings.GenerateSdk || settings.GenerateModels ? allOfs
            .Concat(includedSchemas
                .Where(x => x.Value.AllOf is { Count: >0 })
                .Select(schema => new AnyOfData(
                    "AllOf",
                    schema.Value.AllOf.Count,
                    settings.JsonSerializerType,
                    isTrimming,
                    settings.Namespace,
                    schema.Key.ToClassName(),
                    schema.Value.GetSummary(),
                    schema.Value.AllOf.ToAnyOfProperties(settings, schema.Key))))
            .ToImmutableArray() : [];

        AnyOfData[] anyOfDatas =
        [
            ..anyOfs,
            ..oneOfs,
            ..allOfs,
        ];

        var types =
            settings.GenerateJsonSerializerContextTypes &&
            (settings.GenerateSdk || settings.GenerateModels)
                ? classes.Values
                    .SelectMany(model => model.Properties)
                    .Select(x => x.Type)
                    .Concat(methods.SelectMany(x => x.AdditionalTypes))
                    .Where(x => !string.IsNullOrWhiteSpace(x.CSharpType))
                    .GroupBy(x => x.CSharpTypeWithNullability)
                    .Select(x => x.First())
                    .ToImmutableArray()
                : [];
        var models = settings.GenerateSdk || settings.GenerateModels ? classes.Values
                .Select(model => model with
                {
                    Schema = default,
                }).Concat(
                methods
                    .SelectMany(x => x.AdditionalModels)
                    .Select(model => model with
                    {
                        Schema = default,
                    }))
            //.Where(x => x.Properties.Any())
            .GroupBy(x => x.FileNameWithoutExtension)
            .Select(x => x.First())
            .ToImmutableArray() : [];

        var converters = models
            .Where(x => x.Style == ModelStyle.Enumeration && x.Settings.JsonSerializerType != JsonSerializerType.NewtonsoftJson)
            .SelectMany(x => new[]
            {
                $"global::OpenApiGenerator.JsonConverters.{x.ClassName}JsonConverter",
                $"global::OpenApiGenerator.JsonConverters.{x.ClassName}NullableJsonConverter"
            })
            .Concat(anyOfDatas
                .Where(x => x.JsonSerializerType == JsonSerializerType.SystemTextJson)
                .Select(x =>
                    string.IsNullOrWhiteSpace(x.Name)
                        ? $"global::OpenApiGenerator.JsonConverters.{x.SubType}JsonConverterFactory{x.Count}"
                        : $"global::OpenApiGenerator.JsonConverters.{x.Name}JsonConverter"))
            .ToImmutableArray();
        for (var i = 0; i < methods.Length; i++)
        {
            if (methods[i].Id != "MainConstructor")
            {
                continue;
            }
            
            methods[i] = methods[i] with
            {
                Converters = converters,
            };
        }
        
        return new Models.Data(
            Models: models,
            Methods: settings.GenerateSdk || settings.GenerateMethods
                ? methods.Select(x => x with{ AdditionalModels = []}).ToImmutableArray()
                : [],
            AnyOfs: anyOfDatas.ToImmutableArray(),
            Types: types,
            Authorizations: settings.GenerateSdk || settings.GenerateConstructors
                ? authorizations.ToImmutableArray()
                : [],
            Converters: new EndPoint(
                Id: "Converters",
                Namespace: settings.Namespace,
                ClassName: string.Empty,
                BaseUrl: string.Empty,
                Stream: false,
                Path: string.Empty,
                RequestMediaType: string.Empty,
                Properties: [],
                HttpMethod: OperationType.Get,
                ContentType: ContentType.String,
                Summary: string.Empty,
                BaseUrlSummary: string.Empty,
                Settings: settings,
                IsDeprecated: false,
                IsMultipartFormData: false,
                RequestType: TypeData.Default,
                ResponseType: TypeData.Default,
                AdditionalModels: [],
                AdditionalTypes: [],
                Converters: converters),
            Schemas: schemaContexts);
    }
}
