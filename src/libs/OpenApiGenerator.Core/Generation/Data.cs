using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static class Data
{
    #region Methods

    public static (EquatableArray<ModelData> Models, EquatableArray<EndPoint> Methods, EquatableArray<AnyOfData> AnyOfs, EquatableArray<TypeData> Types) Prepare(
        (string text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;

        var openApiDocument = text.GetOpenApiDocument(cancellationToken);
        
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
        var allTags = openApiDocument.Tags;
        foreach (var operation in openApiDocument.Paths
                     .SelectMany(x => x.Value.Operations)
                     .Select(x => x.Value))
        {
            foreach (var tag in operation.Tags)
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
            : new HashSet<string>(openApiDocument.Components.Schemas
                .Where(schema =>
                    (includedModels.Count == 0 ||
                    includedModels.Contains(schema.Key)) &&
                    !excludedModels.Contains(schema.Key))
                .SelectMany(schema => schema.GetReferences())
                .Select(reference => reference.Id));

        var includedSchemas = openApiDocument.Components.Schemas
            .Where(schema =>
                (includedModels.Count == 0 ||
                 includedModels.Contains(schema.Key) ||
                 referencesOfIncludedModels.Contains(schema.Key)) &&
                !excludedModels.Contains(schema.Key))
            .ToArray();
        Dictionary<string, ModelData> classes = includedSchemas
            // .Where(schema =>
            //     schema.Value.AnyOf is not { Count: >0 } &&
            //     schema.Value.OneOf is not { Count: >0 } &&
            //     schema.Value.AllOf is not { Count: >0 })
            .Select(schema => ModelData.FromSchema(schema, settings))
            .SelectMany(model => model.WithAdditionalModels())
            .GroupBy(x => x.ClassName)
            .Select(x => x.First())
            .ToDictionary(x => x.ClassName, x => x);

        var operations = openApiDocument.Paths.SelectMany(path =>
                path.Value.Operations
                    .Where(x =>
                    {
                        if (includedOperationIds.Count == 0 && excludedOperationIds.Count == 0)
                        {
                            return true;
                        }
                    
                        var methodName = x.Value.GetMethodName(path: path.Key, operationType: x.Key,
                            settings.MethodNamingConvention, settings.MethodNamingConventionFallback);
                    
                        return (includedOperationIds.Count == 0 ||
                                includedOperationIds.Contains(methodName) ||
                                includedOperationIds.Contains(x.Value.OperationId)) &&
                               !excludedOperationIds.Contains(methodName) &&
                               !excludedOperationIds.Contains(x.Value.OperationId);
                    })
                    .Select(x => (Path: path, Operation: x)))
            .ToArray();
        
        var operationsAsMethods = operations
            .Select(x => EndPoint.FromSchema(x.Operation, settings, x.Path.Key))
            .ToArray();
        var authorizations = openApiDocument.SecurityRequirements
            .SelectMany(requirement => requirement)
            .Select(x => EndPoint.FromAuthorization(x.Key.Scheme, settings))
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
                BaseUrl: openApiDocument.Servers.FirstOrDefault()?.Url ?? string.Empty,
                Stream: false,
                Path: string.Empty,
                AuthorizationScheme: string.Empty,
                Properties: settings.GroupByTags && (settings.GenerateSdk || settings.GenerateConstructors)
                    ? [
                        .. includedTags.Select(x => PropertyData.Default with
                        {
                            Name = PropertyData.SanitizeName(x.Name.ToClassName()),
                            Type = TypeData.Default with
                            {
                                CSharpType = $"{x.Name.ToClassName()}Client",
                            },
                            Summary = x.Description ?? string.Empty,
                        })
                    ]
                    : [],
                TargetFramework: settings.TargetFramework,
                JsonSerializerType: settings.JsonSerializerType,
                JsonSerializerContext: settings.JsonSerializerContext,
                HttpMethod: OperationType.Get,
                Summary: openApiDocument.Info?.Description?.ClearForXml() ?? string.Empty,
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
                        BaseUrl: openApiDocument.Servers.FirstOrDefault()?.Url ?? string.Empty,
                        Stream: false,
                        Path: string.Empty,
                        AuthorizationScheme: string.Empty,
                        Properties: ImmutableArray<PropertyData>.Empty,
                        TargetFramework: settings.TargetFramework,
                        JsonSerializerType: settings.JsonSerializerType,
                        JsonSerializerContext: settings.JsonSerializerContext,
                        HttpMethod: OperationType.Get,
                        Summary: x.Description?.ClearForXml() ?? string.Empty,
                        RequestType: TypeData.Default,
                        ResponseType: TypeData.Default,
                        AdditionalModels: [],
                        AdditionalTypes: [],
                        Converters: [])))
                .ToArray();
        }
            
        EndPoint[] methods = [
            ..operationsAsMethods,
            ..authorizations,
            ..constructors,
        ];
        
        var allSchemas = settings.GenerateSdk || settings.GenerateModels ? classes.Values.Concat(methods
                .SelectMany(x => x.AdditionalModels))
            .SelectMany(x => x.Schema.Value.Properties.Concat([x.Schema]).ToArray())
            .Select(x => x.Value)
            .ToArray() : [];
        var anyOfs = allSchemas
            .Where(x => x.AnyOf is { Count: > 0 })
            .Select(x => new AnyOfData("AnyOf", x.AnyOf.Count, settings.JsonSerializerType))
            .Concat(allSchemas
                .Where(x => x.Items?.AnyOf is { Count: > 0 })
                .Select(x => new AnyOfData("AnyOf", x.Items.AnyOf.Count, settings.JsonSerializerType)))
            .Distinct()
            .ToImmutableArray();
        var oneOfs = allSchemas
            .Where(x => x.OneOf is { Count: > 0 })
            .Select(x => new AnyOfData("OneOf", x.OneOf.Count, settings.JsonSerializerType))
            .Concat(allSchemas
                .Where(x => x.Items?.OneOf is { Count: > 0 })
                .Select(x => new AnyOfData("OneOf", x.Items.OneOf.Count, settings.JsonSerializerType)))
            .Distinct()
            .ToImmutableArray();
        var allOfs = allSchemas
            .Where(x => x.AllOf is { Count: > 0 })
            .Select(x => new AnyOfData("AllOf", x.AllOf.Count, settings.JsonSerializerType))
            .Concat(allSchemas
                .Where(x => x.Items?.AllOf is { Count: > 0 })
                .Select(x => new AnyOfData("AllOf", x.Items.AllOf.Count, settings.JsonSerializerType)))
            .Distinct()
            .ToImmutableArray();

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
            .GroupBy(x => x.FileNameWithoutExtension)
            .Select(x => x.First())
            .ToImmutableArray() : [];

        for (var i = 0; i < methods.Length; i++)
        {
            if (methods[i].Id != "MainConstructor")
            {
                continue;
            }
            
            methods[i] = methods[i] with
            {
                Converters = models
                    .Where(x => x.Style == ModelStyle.Enumeration && x.JsonSerializerType != JsonSerializerType.NewtonsoftJson)
                    .SelectMany(x => new [] {
                        $"global::OpenApiGenerator.JsonConverters.{x.ClassName}JsonConverter",
                        $"global::OpenApiGenerator.JsonConverters.{x.ClassName}NullableJsonConverter"
                    })
                    .ToImmutableArray(),
            };
        }
        
        return (Models: models,
                Methods: settings.GenerateSdk || settings.GenerateMethods
                    ? methods.Select(x => x with{ AdditionalModels = []}).ToImmutableArray()
                    : [],
                AnyOfs: anyOfDatas.ToImmutableArray(),
                Types: types);
    }
    
    public static FileWithName GetSourceCode(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{modelData.FileNameWithoutExtension}.g.cs",
            Text: Sources.GenerateModel(modelData, cancellationToken: cancellationToken));
    }
    
    public static FileWithName GetSourceCodeForType(
        AnyOfData data,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{data.SubType}.{data.Count}.g.cs",
            Text: Sources.GenerateAnyOf(data, cancellationToken: cancellationToken));
    }
    
    public static FileWithName GetSourceCodeForAnyOfJsonConverter(
        AnyOfData data,
        CancellationToken cancellationToken = default)
    {
        if (data.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"JsonConverters.{data.SubType}{data.Count}.g.cs",
            Text: Sources.GenerateAnyOfJsonConverter(data, cancellationToken: cancellationToken));
    }
    
    public static FileWithName GetSourceCodeForEnumJsonConverter(
        ModelData data,
        CancellationToken cancellationToken = default)
    {
        if (data.Style != ModelStyle.Enumeration ||
            data.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"JsonConverters.{data.ClassName}.g.cs",
            Text: Sources.GenerateEnumJsonConverter(data, cancellationToken: cancellationToken));
    }
    
    public static FileWithName GetSourceCodeForEnumNullableJsonConverter(
        ModelData data,
        CancellationToken cancellationToken = default)
    {
        if (data.Style != ModelStyle.Enumeration ||
            data.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"JsonConverters.{data.ClassName}Nullable.g.cs",
            Text: Sources.GenerateEnumNullableJsonConverter(data, cancellationToken: cancellationToken));
    }

    public static FileWithName GetSourceCodeForAnyOfJsonConverterFactory(
        AnyOfData anyOf,
        CancellationToken cancellationToken = default)
    {
        if (anyOf.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"JsonConverters.{anyOf.SubType}Factory{anyOf.Count}.g.cs",
            Text: Sources.GenerateAnyOfJsonConverterFactory(anyOf, cancellationToken: cancellationToken));
    }
    
    public static FileWithName GetSourceCodeForJsonSerializerContextTypes(
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (types.IsEmpty ||
            !types[0].GenerateJsonSerializerContextTypes ||
            types[0].JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: "JsonSerializerContextTypes.g.cs",
            Text: Sources.GenerateJsonSerializerContextTypes(types, cancellationToken: cancellationToken));
    }
    
    public static FileWithName GetSourceCode(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{endPoint.FileNameWithoutExtension}.g.cs",
            Text: Sources.GenerateEndPoint(endPoint, cancellationToken: cancellationToken));
    }

    #endregion
}
