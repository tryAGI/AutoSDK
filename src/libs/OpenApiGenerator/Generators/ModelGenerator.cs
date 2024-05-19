using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using OpenApiGenerator.Core.Generators;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;
using FileWithName = H.Generators.Extensions.FileWithName;

namespace OpenApiGenerator.Generators;

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
        
        var models = context.AdditionalTextsProvider
            .Where(static text => text.Path.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase))
            .Combine(settings)
            .SelectAndReportExceptions(PrepareData, context, Id);
        
        models
            .SelectMany(static (x, _) => x)
            .SelectAndReportExceptions(GetSourceCode, context, Id)
            .AddSource(context);
        models
            .Select(static (x, _) => x)
            .SelectAndReportExceptions(GetSourceCodeForSuperType, context, Id)
            .AddSource(context);
    }

    private static Core.Models.EquatableArray<ModelData> PrepareData(
        (AdditionalText text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        var yaml = text.GetText(cancellationToken)?.ToString() ?? string.Empty;
        
        return ModelGeneratorMethods.PrepareData((yaml, settings), cancellationToken);
    }
    
    private static FileWithName GetSourceCode(
        ModelData model,
        CancellationToken cancellationToken = default)
    {
        var fileWithName = ModelGeneratorMethods.GetSourceCode(model, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }
    
    private static FileWithName GetSourceCodeForSuperType(
        Core.Models.EquatableArray<ModelData> models,
        CancellationToken cancellationToken = default)
    {
        if (models.IsEmpty)
        {
            return FileWithName.Empty;
        }
        
        var fileWithName = ModelGeneratorMethods.GetSourceCodeForSuperClass(models, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }

    #endregion
}
