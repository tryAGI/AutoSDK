using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
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
        
        return openApiDocument.Components.Schemas
            .Select(schema => new Model(
                Name: schema.Key.ToPropertyName(),
                Namespace: settings.Namespace,
                Style: settings.ModelStyle,
                Properties: Array.Empty<Property>().ToImmutableArray()))
            .ToImmutableArray();
    }
    
    private static FileWithName GetSourceCode(
        Model model,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{model.Namespace}.Models.{model.Name}.g.cs",
            Text: Sources.GenerateModel(model, cancellationToken: cancellationToken));
    }

    #endregion
}
