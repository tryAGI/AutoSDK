using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using OpenApiGenerator.Core.Generation;
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
        
        var data = context.AdditionalTextsProvider
            .Where(static text => text.Path.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase) ||
                                  text.Path.EndsWith(".json", StringComparison.InvariantCultureIgnoreCase))
            .Select(static (text, cancellationToken) => GetContent(text, cancellationToken))
            .Combine(settings)
            .SelectAndReportExceptions(Data.Prepare, context, Id);
        
        data
            .SelectMany(static (x, _) => x.Methods)
            .SelectAndReportExceptions(GetMethodSourceCode, context, Id)
            .AddSource(context);
        
        data
            .SelectMany(static (x, _) => x.Models)
            .SelectAndReportExceptions(GetModelSourceCode, context, Id)
            .AddSource(context);
        data
            .Select(static (x, _) => x.Models)
            .SelectAndReportExceptions(GetSuperTypeSourceCode, context, Id)
            .AddSource(context);
        
        data
            .SelectMany(static (x, _) => x.AnyOfs)
            .SelectAndReportExceptions(GetAnyOfSourceCode, context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.AnyOfs)
            .SelectAndReportExceptions(GetAnyOfConverterSourceCode, context, Id)
            .AddSource(context);
    }

    private static string GetContent(AdditionalText additionalText, CancellationToken cancellationToken = default)
    {
        return additionalText.Path.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? Task.Run(() => new HttpClient().GetStringAsync(new Uri(additionalText.Path)), cancellationToken).Result
            : additionalText.GetText(cancellationToken)?.ToString() ?? string.Empty;
    }
    
    private static FileWithName GetMethodSourceCode(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        var fileWithName = Data.GetSourceCode(endPoint, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }
    
    private static FileWithName GetModelSourceCode(
        ModelData model,
        CancellationToken cancellationToken = default)
    {
        var fileWithName = Data.GetSourceCode(model, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }
    
    private static FileWithName GetAnyOfSourceCode(
        AnyOfData model,
        CancellationToken cancellationToken = default)
    {
        var fileWithName = Data.GetSourceCodeForType(model, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }
    
    private static FileWithName GetAnyOfConverterSourceCode(
        AnyOfData model,
        CancellationToken cancellationToken = default)
    {
        var fileWithName = Data.GetSourceCodeForConverter(model, cancellationToken);
        
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
        
        var fileWithName = Data.GetSourceCodeForSuperClass(models, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }

    #endregion
}
