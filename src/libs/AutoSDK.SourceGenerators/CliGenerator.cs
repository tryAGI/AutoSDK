using System.Collections.Immutable;
using AutoSDK.Generation;
using Microsoft.CodeAnalysis;

namespace AutoSDK.SourceGenerators;

[Generator]
public class CliGenerator : IIncrementalGenerator
{
    #region Constants

    private const string Id = "CLIG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var settings = context.DetectSettings();
        
        var data = context.AdditionalTextsProvider
            .Combine(context.AnalyzerConfigOptionsProvider)
            .Where(static pair =>
                pair.Right.GetOption(pair.Left, "OpenApiSpecification", prefix: "AutoSDK")?.ToUpperInvariant() == "TRUE")
            .Select((pair, cancellationToken) => (
                GetContent(pair.Left, cancellationToken),
                pair.Right.GetSettings(prefix: "AutoSDK", additionalText: pair.Left)))
            .Combine(settings)
            .Where(x => x.Right.GenerateCli)
            .SelectAndReportExceptions(Data.Prepare, context, Id);
        
        data
            .SelectMany(static (x, _) => x.Methods.GroupBy(x => x.Tag))
            .SelectAndReportExceptions((x, c) => Sources.TagCommand(x.Key, x.ToImmutableArray(), c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.Methods)
            .SelectAndReportExceptions((x, c) => Sources.Command(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .Select(static (x, _) => x.Tags)
            .SelectAndReportExceptions((x, c) => Sources.MainCommand(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .Select(static (x, _) => (x.Methods, x.Tags))
            .SelectAndReportExceptions((x, c) => Sources.AddCommands(x.Methods, x.Tags, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
    }

    private static string GetContent(AdditionalText additionalText, CancellationToken cancellationToken = default)
    {
        return additionalText.Path.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? Task.Run(() => new HttpClient().GetStringAsync(new Uri(additionalText.Path)), cancellationToken).Result
            : additionalText.GetText(cancellationToken)?.ToString() ?? string.Empty;
    }
    
    #endregion
}
