using AutoSDK.Generation;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;

namespace AutoSDK.SourceGenerators;

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
        settings
            .SelectAndReportExceptions((x, c) => Sources.Polyfills(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        settings
            .SelectAndReportExceptions((x, c) => Sources.Exceptions(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        settings
            .SelectAndReportExceptions((x, c) => Sources.PathBuilder(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        settings
            .SelectAndReportExceptions((x, c) => Sources.UnixTimestampJsonConverter(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        
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
            .SelectMany(static (x, _) => x.Methods)
            .SelectAndReportExceptions((x, c) => Sources.MethodInterface(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.Clients)
            .SelectAndReportExceptions((x, c) => Sources.Client(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.Clients)
            .SelectAndReportExceptions((x, c) => Sources.ClientInterface(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.Authorizations)
            .SelectAndReportExceptions((x, c) => Sources.Authorization(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.Authorizations)
            .SelectAndReportExceptions((x, c) => Sources.AuthorizationInterface(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .Select(static (x, _) => x.Authorizations)
            .SelectAndReportExceptions((x, c) => Sources.MainAuthorizationConstructor(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        
        data
            .SelectMany(static (x, _) => x.Classes)
            .SelectAndReportExceptions((x, c) => Sources.Class(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.Classes)
            .SelectAndReportExceptions((x, c) => Sources.ClassJsonExtensions(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        
        data
            .SelectMany(static (x, _) => x.Enums)
            .SelectAndReportExceptions((x, c) => Sources.Enum(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .Select(static (x, _) => x.Types)
            .SelectAndReportExceptions((x, c) => Sources.JsonSerializerContextTypes(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
    
        data
            .SelectMany(static (x, _) => x.Enums)
            .SelectAndReportExceptions((x, c) => Sources.EnumJsonConverter(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.Enums)
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
            .SelectAndReportExceptions((x, c) => Sources.AnyOfJsonExtensions(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.AnyOfs)
            .SelectAndReportExceptions((x, c) => Sources.AnyOfJsonConverter(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        // data
        //     .SelectMany(static (x, _) => x.AnyOfs)
        //     .SelectAndReportExceptions((x, c) => Sources.AnyOfJsonConverterFactory(x, c)
        //         .AsFileWithName(), context, Id)
        //     .AddSource(context);
        
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
