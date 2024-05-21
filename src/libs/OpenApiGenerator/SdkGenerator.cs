using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using OpenApiGenerator.Core.Generators;
using OpenApiGenerator.Core.Models;
using FileWithName = H.Generators.Extensions.FileWithName;

namespace OpenApiGenerator;

[Generator]
public class SdkGenerator : IIncrementalGenerator
{
    #region Constants

    private const string Id = "OAG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var settings = context.DetectSettings();
        
        var filesAndSettings = context.AdditionalTextsProvider
            .Where(static text => text.Path.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase) ||
                                  text.Path.EndsWith(".json", StringComparison.InvariantCultureIgnoreCase))
            .Select(static (text, cancellationToken) => GetContent(text, cancellationToken))
            .Combine(settings);
        
        filesAndSettings
            .SelectAndReportExceptions(ClientGeneratorMethods.PrepareData, context, Id)
            .SelectMany(static (x, _) => x)
            .SelectAndReportExceptions(GetMethodSourceCode, context, Id)
            .AddSource(context);
        
        var models = filesAndSettings
            .SelectAndReportExceptions(ModelGeneratorMethods.PrepareData, context, Id);
        
        models
            .SelectMany(static (x, _) => x)
            .SelectAndReportExceptions(GetModelSourceCode, context, Id)
            .AddSource(context);
        models
            .Select(static (x, _) => x)
            .SelectAndReportExceptions(GetSuperTypeSourceCode, context, Id)
            .AddSource(context);
    }

    private static string GetContent(AdditionalText additionalText, CancellationToken cancellationToken = default)
    {
        return additionalText.Path.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? Task.Run(() => new HttpClient().GetStringAsync(new Uri(additionalText.Path)), cancellationToken).Result
            : additionalText.GetText(cancellationToken)?.ToString() ?? string.Empty;;
    }
    
    private static FileWithName GetMethodSourceCode(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        var fileWithName = ClientGeneratorMethods.GetSourceCode(endPoint, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }
    
    private static FileWithName GetModelSourceCode(
        ModelData model,
        CancellationToken cancellationToken = default)
    {
        var fileWithName = ModelGeneratorMethods.GetSourceCode(model, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }
    
    private static FileWithName GetSuperTypeSourceCode(
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
