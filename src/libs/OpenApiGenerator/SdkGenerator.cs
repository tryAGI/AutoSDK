using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using OpenApiGenerator.Core.Generation;

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
            .SelectAndReportExceptions((x, c) => Sources.Method(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        
        data
            .SelectMany(static (x, _) => x.Models)
            .SelectAndReportExceptions((x, c) => Sources.Model(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .Select(static (x, _) => x.Types)
            .SelectAndReportExceptions((x, c) => Sources.JsonSerializerContextTypes(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
    
        data
            .SelectMany(static (x, _) => x.Models)
            .SelectAndReportExceptions((x, c) => Sources.EnumJsonConverter(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.Models)
            .SelectAndReportExceptions((x, c) => Sources.EnumNullableJsonConverter(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        
        data
            .SelectMany(static (x, _) => x.AnyOfs)
            .SelectAndReportExceptions((x, c) => Sources.AnyOf(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.AnyOfs)
            .SelectAndReportExceptions((x, c) => Sources.AnyOfJsonConverter(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.AnyOfs)
            .SelectAndReportExceptions((x, c) => Sources.AnyOfJsonConverterFactory(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        
        data
            .Select(static (x, _) => x.Converters)
            .SelectAndReportExceptions((x, c) => Sources.JsonSerializerContextConverters(x, c)
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
