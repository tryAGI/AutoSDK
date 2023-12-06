using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using OpenApiGenerator.Models;
using OpenApiGenerator.Sources;

namespace H.Generators;

[Generator]
public class OpenApiGenerator : IIncrementalGenerator
{
    #region Constants

    private const string Id = "OAG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var settings = context.AnalyzerConfigOptionsProvider
            .Select((options, _) => new Settings(
                UseNSwag: bool.Parse(options.GetGlobalOption("UseNSwag") ?? bool.FalseString)));
        
        context.AdditionalTextsProvider
            .Where(static text => text.Path.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase))
            .Combine(settings)
            .SelectAndReportExceptions(GetSourceCode, context, Id)
            .AddSource(context);
    }

    private static EquatableArray<FileWithName> GetSourceCode(
        (AdditionalText text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        
        return Sources.GenerateUsingNSwag(text, settings, cancellationToken);
    }


    #endregion
}
