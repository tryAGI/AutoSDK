using System.Collections.Immutable;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Generation;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generators;

public static class ModelGeneratorMethods
{
    #region Methods

    public static ImmutableArray<ModelData> PrepareData(
        (string text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        
        var openApiDocument = text.GetOpenApiDocument(cancellationToken);
        
        var includedModels = new HashSet<string>(settings.IncludeModels);
        var referencesOfIncludedModels = includedModels.Count == 0
            ? []
            : new HashSet<string>(openApiDocument.Components.Schemas
                .Where(schema =>
                    includedModels.Count == 0 ||
                    includedModels.Contains(schema.Key))
                .SelectMany(schema => schema.GetReferences())
                .Select(reference => reference.Id));
        
        return openApiDocument.Components.Schemas
            .Where(schema =>
                includedModels.Count == 0 ||
                includedModels.Contains(schema.Key) ||
                referencesOfIncludedModels.Contains(schema.Key))
            .Select(schema => ModelData.FromSchema(schema, settings))
            .SelectMany(model => model.WithAdditionalModels())
            .Select(model => model with
            {
                Schema = default,
            })
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

    #endregion
}
