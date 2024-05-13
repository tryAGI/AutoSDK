using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using OpenApiGenerator.Core.Generators;
using OpenApiGenerator.Core.Models;
using FileWithName = H.Generators.Extensions.FileWithName;

namespace OpenApiGenerator.Generators;

[Generator]
public class ClientGenerator : IIncrementalGenerator
{
    #region Constants

    private const string Id = "OACG";

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

    private static Core.Models.EquatableArray<EndPoint> PrepareData(
        (AdditionalText text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        var yaml = text.GetText(cancellationToken)?.ToString() ?? string.Empty;
        
        return ClientGeneratorMethods.PrepareData((yaml, settings), cancellationToken);
    }
    
    private static FileWithName GetSourceCode(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        var fileWithName = ClientGeneratorMethods.GetSourceCode(endPoint, cancellationToken);
        
        return new FileWithName(
            Name: fileWithName.Name,
            Text: fileWithName.Text);
    }

    #endregion
}
