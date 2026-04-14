using System.Collections.Immutable;
using AutoSDK.Generation;
using AutoSDK.Models;
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

        var data = context.AdditionalTextsProvider
            .Combine(context.AnalyzerConfigOptionsProvider)
            .Where(static pair =>
                pair.Right.GetOption(pair.Left, "OpenApiSpecification", prefix: "AutoSDK")?.ToUpperInvariant() == "TRUE" ||
                pair.Right.GetOption(pair.Left, "AsyncApiSpecification", prefix: "AutoSDK")?.ToUpperInvariant() == "TRUE")
            .Select((pair, cancellationToken) => (
                GetContent(pair.Left, cancellationToken),
                pair.Right.GetSettings(prefix: "AutoSDK", additionalText: pair.Left)))
            .Combine(settings)
            .SelectAndReportExceptions(CSharpPipeline.PrepareAndEnrich, context, Id);

        var supportData = settings.Combine(data.Collect());

        supportData
            .SelectAndReportExceptions((x, c) => ShouldGeneratePolyfills(x.Right)
                ? Sources.Polyfills(x.Left, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);
        supportData
            .SelectAndReportExceptions((x, c) => ShouldGenerateExceptions(x.Right)
                ? Sources.Exceptions(x.Left, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);
        supportData
            .SelectAndReportExceptions((x, c) => ShouldGeneratePathBuilder(x.Right)
                ? Sources.PathBuilder(x.Left, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectAndReportExceptions((x, c) => x.Clients.Any(static y => y.UsesServerSelectionSupport) ||
                                                x.Methods.Any(static y => y.ClientUsesServerSelectionSupport)
                ? Sources.ServerSelectionSupport(x.Converters.Settings, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .Collect()
            .SelectMany(static (x, _) => GetOptionsSupportSettings(x))
            .SelectAndReportExceptions((x, c) => Sources.OptionsSupport(
                x.Settings,
                includePollingSupport: x.IncludePollingSupport,
                cancellationToken: c), context, Id)
            .AddSource(context);
        supportData
            .SelectAndReportExceptions((x, c) => ShouldGenerateSecuritySupport(x.Right)
                ? Sources.SecuritySupport(x.Left, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);
        supportData
            .SelectAndReportExceptions((x, c) => ShouldGenerateUnixTimestampJsonConverter(x.Right)
                ? Sources.UnixTimestampJsonConverter(x.Left, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);

        data
            .SelectAndReportExceptions((x, c) => x.Methods.Any(y => y.RawStream)
                ? Sources.ResponseStream(x.Converters.Settings, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectAndReportExceptions((x, c) => x.Methods.Any(y => y.GenerateResponseWrapper && !y.EnumerableStream)
                ? Sources.HttpResponse(x.Converters.Settings, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectAndReportExceptions((x, c) => x.Methods.Any(y => y.HasPagination)
                ? Sources.PaginationSupport(x.Converters.Settings, c)
                : FileWithName.Empty
                .AsFileWithName(), context, Id)
            .AddSource(context);
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
            .Select(static (x, _) => (Converters: x.Converters, Types: x.Types))
            .SelectAndReportExceptions((x, c) => Sources.JsonSerializerContextTypes(x.Converters, x.Types, c)
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

        // WebSocket client generation (from AsyncAPI specs)
        data
            .SelectMany(static (x, _) => x.WebSocketClients)
            .SelectAndReportExceptions((x, c) => Sources.WebSocketClient(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.WebSocketOperations)
            .Where(static x => x.Direction == AutoSDK.Models.WebSocketDirection.Send)
            .SelectAndReportExceptions((x, c) => Sources.WebSocketSendMethod(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
        data
            .SelectMany(static (x, _) => x.WebSocketClients)
            .SelectAndReportExceptions((x, c) => Sources.WebSocketReceiveMethod(x, c)
                .AsFileWithName(), context, Id)
            .AddSource(context);
    }

    private static string GetContent(AdditionalText additionalText, CancellationToken cancellationToken = default)
    {
        return additionalText.Path.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? Task.Run(() => new HttpClient().GetStringAsync(new Uri(additionalText.Path)), cancellationToken).Result
            : additionalText.GetText(cancellationToken)?.ToString() ?? string.Empty;
    }

    private static bool ShouldGeneratePolyfills(ImmutableArray<AutoSDK.Models.Data> data)
    {
        return data.Any(static x =>
            x.Converters.Settings.GeneratePolyfills &&
            !x.Methods.IsEmpty);
    }

    private static bool ShouldGenerateExceptions(ImmutableArray<AutoSDK.Models.Data> data)
    {
        return data.Any(static x =>
            x.Converters.Settings.GenerateExceptions &&
            (!x.Methods.IsEmpty || !x.Clients.IsEmpty));
    }

    private static bool ShouldGeneratePathBuilder(ImmutableArray<AutoSDK.Models.Data> data)
    {
        return data.Any(static x =>
            !x.Methods.IsEmpty ||
            !x.Clients.IsEmpty ||
            !x.WebSocketClients.IsEmpty);
    }

    private static bool ShouldGenerateOptionsSupport(ImmutableArray<AutoSDK.Models.Data> data)
    {
        return data.Any(static x =>
            !x.Methods.IsEmpty ||
            !x.Clients.IsEmpty);
    }

    private static IEnumerable<(CSharpSettings Settings, bool IncludePollingSupport)> GetOptionsSupportSettings(ImmutableArray<AutoSDK.Models.Data> data)
    {
        return data
            .Where(static x =>
                !x.Methods.IsEmpty ||
                !x.Clients.IsEmpty)
            .GroupBy(static x => x.Converters.Settings.Namespace, StringComparer.Ordinal)
            .Select(static x => (
                Settings: CSharpSettings.FromSettings(x.First().Converters.Settings),
                IncludePollingSupport: x.Any(static y => y.Methods.Any(static z => !z.PollingOperations.IsEmpty))));
    }

    private static bool ShouldGenerateSecuritySupport(ImmutableArray<AutoSDK.Models.Data> data)
    {
        return data.Any(static x => !x.Authorizations.IsEmpty);
    }

    private static bool ShouldGenerateUnixTimestampJsonConverter(ImmutableArray<AutoSDK.Models.Data> data)
    {
        return data.Any(static x =>
            x.Converters.Settings.GenerateJsonSerializerContextTypes ||
            (!x.Clients.IsEmpty &&
             x.Clients.Any(client => !client.Settings.HasJsonSerializerContext())));
    }
    
    #endregion
}
