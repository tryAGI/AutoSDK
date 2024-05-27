using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static class ModelGeneratorMethods
{
    #region Methods

    public static EquatableArray<ModelData> PrepareData(
        (string text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        if (settings is { GenerateSdk: false, GenerateModels: false })
        {
            return ImmutableArray<ModelData>.Empty;
        }
        
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
        
        var components = openApiDocument.Components.Schemas
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
            .ToImmutableArray();

        var objectParameters = openApiDocument.Paths
            .SelectMany(path => path.Value.Operations.Select(operation => (Path: path.Key, Operation: operation)))
            .SelectMany(x => x.Operation.Value.Parameters.Select(y => (x.Path, x.Operation, Parameter: y)))
            .Where(x => x.Parameter.Schema.Type == "object")
            .Select(x => ModelData.FromSchema(
                x.Parameter.Schema.WithKey(x.Operation.Value.GetMethodName(path: x.Path, operationType: x.Operation.Key, settings.MethodNamingConvention, settings.MethodNamingConventionFallback) + x.Parameter.Name.ToPropertyName()),
                settings) with
                {
                    Schema = default,
                })
            .ToImmutableArray();
        var bodies = openApiDocument.Paths
            .SelectMany(path => path.Value.Operations
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
                .Select(operation => (Path: path.Key, Operation: operation)))
            .SelectMany(x =>
                ((x.Operation.Value?.RequestBody?.Reference?.HostDocument?.ResolveReference(x.Operation.Value?.RequestBody?.Reference) as OpenApiRequestBody)?.Content ??
                 x.Operation.Value?.RequestBody?.Content)
                ?.Values.Select(y => (x.Path, x.Operation, Parameter: y)) ?? [])
            .Where(x => x.Parameter.Schema.Type == "object" || x.Parameter.Schema.Type == "array") //&& x.Parameter.Schema.Items?.Type == "object"
            .Select(x => ModelData.FromSchema(
                    x.Parameter.Schema.Type == "object"
                        ? x.Parameter.Schema.WithKey(x.Operation.Value.GetMethodName(path: x.Path, operationType: x.Operation.Key, settings.MethodNamingConvention, settings.MethodNamingConventionFallback) + "Request")
                        : x.Parameter.Schema.Items.WithKey(x.Operation.Value.GetMethodName(path: x.Path, operationType: x.Operation.Key, settings.MethodNamingConvention, settings.MethodNamingConventionFallback) + "Request"),
                    settings) with
                {
                    Schema = default,
                })
            .SelectMany(model => model.WithAdditionalModels())
            .ToImmutableArray();
        var enumParameters = openApiDocument.Paths
            .SelectMany(path => path.Value.Operations.Select(operation => (operation.Value.OperationId, Operation: operation)))
            .SelectMany(x => x.Operation.Value.Parameters.Select(y => (x.OperationId, Parameter: y)))
            .Where(x => x.Parameter.Schema.Enum?.Any() == true || x.Parameter.Schema.Items?.Enum?.Any() == true)
            .Select(x => ModelData.FromSchema(
                    x.Parameter.Schema.WithKey(x.OperationId + x.Parameter.Name.ToPropertyName()),
                    settings) with
                {
                    Style = ModelStyle.Enumeration,
                    Properties = (x.Parameter.Schema.Enum?.Any() == true
                        ? x.Parameter.Schema.Enum
                        : x.Parameter.Schema.Items.Enum)
                        .Select(value => value.ToEnumValue())
                        .Where(value => !string.IsNullOrWhiteSpace(value.Name))
                        .ToImmutableArray(),
                    Schema = default,
                })
            .ToImmutableArray();
        
        return ImmutableArray
            .Create([
                ..components,
                ..objectParameters,
                ..enumParameters,
                ..bodies,
            ])
            .GroupBy(x => x.FileNameWithoutExtension)
            .Select(x => x.First())
            .ToImmutableArray();
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

    #endregion
}
