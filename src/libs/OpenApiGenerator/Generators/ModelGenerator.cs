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
        
        return openApiDocument.Components.Schemas
            .Select(schema => new Model(
                Name: schema.Key.ToPropertyName(),
                Namespace: settings.Namespace,
                Style: settings.ModelStyle,
                Properties: schema.Value.Properties
                    .Select(x => new Property(
                        Id: x.Key,
                        Name: x.Key.ToPropertyName()
                            .FixClassName(schema.Key.ToPropertyName())
                            .FixUnderscore(),
                        Type: x.Value.GetCSharpType(),
                        IsRequired: x.Value.Required.Contains(x.Key),
                        DefaultValue: x.Value.GetDefaultValue(),
                        Summary: x.Value.GetSummary()))
                    .ToImmutableArray(),
                Summary: schema.Value.GetSummary()))
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
