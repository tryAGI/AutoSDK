using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static class Data
{
    #region Methods

    public static (EquatableArray<ModelData> Models, EquatableArray<EndPoint> Methods) Prepare(
        (string text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;

        Dictionary<string, ModelData> schemas = [];
        EndPoint[] methods = [];
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

        if (settings.GenerateSdk || settings.GenerateModels)
        {
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
            
            schemas = openApiDocument.Components.Schemas
                .Where(schema =>
                    (includedModels.Count == 0 ||
                    includedModels.Contains(schema.Key) ||
                    referencesOfIncludedModels.Contains(schema.Key)) &&
                    !excludedModels.Contains(schema.Key))
                .Select(schema => ModelData.FromSchema(schema, settings))
                .SelectMany(model => model.WithAdditionalModels())
                .Select(model => model with
                {
                    Schema = default,
                })
                .ToDictionary(x => x.ClassName, x => x);
        }

        if (settings.GenerateSdk || settings.GenerateMethods)
        {
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
                    Id: "Constructors",
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
                                UnsanitaryName = x.Name.ToClassName(),
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
                    RequestType: string.Empty,
                    ResponseType: string.Empty,
                    AdditionalModels: [])] : [];
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
                            RequestType: string.Empty,
                            ResponseType: string.Empty,
                            AdditionalModels: [])))
                    .ToArray();
            }
                
            methods = [
                ..operationsAsMethods,
                ..authorizations,
                ..constructors,
            ];
        }

        return (schemas.Values.Concat(
                methods.SelectMany(x => x.AdditionalModels))
                    .GroupBy(x => x.FileNameWithoutExtension)
                    .Select(x => x.First())
                    .ToImmutableArray(),
                methods.Select(x => x with{ AdditionalModels = []}).ToImmutableArray());
    }
    
    public static FileWithName GetSourceCode(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{modelData.FileNameWithoutExtension}.g.cs",
            Text: Sources.GenerateModel(modelData, cancellationToken: cancellationToken));
    }
    
    public static FileWithName GetSourceCodeForSuperClass(
        EquatableArray<ModelData> models,
        CancellationToken cancellationToken = default)
    {
        if (models.IsEmpty ||
            !models[0].GenerateSuperTypeForJsonSerializerContext ||
            models[0].JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: "OpenApiGeneratorTrimmableSupport.g.cs",
            Text: Sources.GenerateSuperClass(models, cancellationToken: cancellationToken));
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
