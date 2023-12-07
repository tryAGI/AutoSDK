using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Models;

namespace OpenApiGenerator;

[Generator]
public class ModelGenerator : IIncrementalGenerator
{
    #region Constants

    private const string Id = "OAMG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var settings = context.DetectSettings();
        
        context.AdditionalTextsProvider
            .Where(static text => text.Path.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase))
            .Combine(settings)
            .SelectAndReportExceptions(PrepareData, context, Id)
            .SelectMany(static (x, _) => x)
            .SelectAndReportExceptions(GetSourceCode, context, Id)
            .AddSource(context);
    }

    private static EquatableArray<Model> PrepareData(
        (AdditionalText text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        if (settings.UseNSwag)
        {
            return ImmutableArray<Model>.Empty;
        }
        
        var openApiDocument = text.GetOpenApiDocument(cancellationToken);
        
        var includeModels = new HashSet<string>(settings.IncludeModels);
        var referencesOfIncludedModels = includeModels.Count == 0
            ? new HashSet<string>()
            : new HashSet<string>(openApiDocument.Components.Schemas
                .Where(schema =>
                    includeModels.Count == 0 ||
                    includeModels.Contains(schema.Key))
                .SelectMany(schema => schema.GetReferences())
                .Select(reference => reference.Id));
        
        return openApiDocument.Components.Schemas
            .Where(schema =>
                includeModels.Count == 0 ||
                includeModels.Contains(schema.Key) ||
                referencesOfIncludedModels.Contains(schema.Key))
            .Select(schema => schema.ToModel(settings))
            .SelectMany(model => model.WithAdditionalModels())
            .ToImmutableArray();
    }
    
    private static FileWithName GetSourceCode(
        Model model,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{model.Namespace}.Models.{(model.Parent != null ? $"{model.Parent}." : "")}{model.Name}.g.cs",
            Text: Sources.GenerateModel(model, cancellationToken: cancellationToken));
    }

    #endregion
}
