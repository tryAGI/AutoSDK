using System.Collections.Immutable;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Generation;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generators;

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
        
        var includedModels = new HashSet<string>(settings.IncludeModels);
        var excludedModels = new HashSet<string>(settings.ExcludeModels);
        foreach (var tag in settings.IncludeTags)
        {
            includedModels.UnionWith(openApiDocument.FindAllModelsForTag(tag));
        }
        foreach (var tag in settings.ExcludeTags)
        {
            includedModels.UnionWith(openApiDocument.FindAllModelsForTag(tag));
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
            .SelectMany(path => path.Value.Operations.Select(operation => (operation.Value.OperationId, Operation: operation)))
            .SelectMany(x => x.Operation.Value.Parameters.Select(y => (x.OperationId, Parameter: y)))
            .Where(x => x.Parameter.Schema.Type == "object")
            .Select(x => ModelData.FromSchema(
                x.Parameter.Schema.WithKey(x.OperationId + x.Parameter.Name.ToPropertyName()),
                settings) with
                {
                    Schema = default,
                })
            .ToImmutableArray();
        var enumParameters = openApiDocument.Paths
            .SelectMany(path => path.Value.Operations.Select(operation => (operation.Value.OperationId, Operation: operation)))
            .SelectMany(x => x.Operation.Value.Parameters.Select(y => (x.OperationId, Parameter: y)))
            .Where(x => x.Parameter.Schema.Enum?.Any() == true)
            .Select(x => ModelData.FromSchema(
                    x.Parameter.Schema.WithKey(x.OperationId + x.Parameter.Name.ToPropertyName()),
                    settings) with
                {
                    Style = ModelStyle.Enumeration,
                    Properties = x.Parameter.Schema.Enum
                        .Select(value => value.ToEnumValue())
                        .ToImmutableArray(),
                    Schema = default,
                })
            .ToImmutableArray();
        
        return ImmutableArray.Create([
            ..components,
            ..objectParameters,
            ..enumParameters
        ]);
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
