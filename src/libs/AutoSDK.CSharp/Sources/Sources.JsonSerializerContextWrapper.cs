using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName JsonSerializerContextWrapper(
        Client client,
        CancellationToken cancellationToken = default)
    {
        if (client.Settings.FromCli ||
            client.Settings.GenerateJsonSerializerContextTypes ||
            !client.Settings.HasJsonSerializerContext() ||
            !client.Settings.UsesSystemTextJson())
        {
            return FileWithName.Empty;
        }

        var className = GetJsonSerializerContextWrapperClassName(client.Settings);

        return new FileWithName(
            Name: $"{client.Settings.Namespace}.{className}.g.cs",
            Text: GenerateJsonSerializerContextWrapper(client, className));
    }

    public static string GetDefaultJsonSerializerContextExpression(Settings settings)
    {
        return settings.FromCli || settings.GenerateJsonSerializerContextTypes
            ? $"global::{settings.JsonSerializerContext}.Default"
            : $"global::{settings.Namespace}.{GetJsonSerializerContextWrapperClassName(settings)}.Default";
    }

    public static string GenerateJsonSerializerContextWrapper(
        Client client,
        string? className = null)
    {
        className ??= GetJsonSerializerContextWrapperClassName(client.Settings);

        return $@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace {client.Settings.Namespace}
{{
    {"Composes the user-provided source-generated JSON resolver with AutoSDK's generated converters.".ToXmlDocumentationSummary(level: 4)}
    internal sealed class {className} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver =
            global::{client.Settings.JsonSerializerContext}.Default;

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        internal static {className} Default {{ get; }} = new(DefaultOptions);

        private {className}(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {{
        }}

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {{
            return Resolver.GetTypeInfo(type, Options);
        }}

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {{
            var options = new global::System.Text.Json.JsonSerializerOptions(
                global::{client.Settings.JsonSerializerContext}.Default.Options)
            {{
                TypeInfoResolver = Resolver,
            }};
{client.Converters
    .Distinct(StringComparer.Ordinal)
    .Select(x => $@"
            options.Converters.Add(new {x}());")
    .Inject()}

            return options;
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GetJsonSerializerContextWrapperClassName(Settings settings)
    {
        var contextName = settings.JsonSerializerContext;
        var separatorIndex = contextName.LastIndexOf('.');
        if (separatorIndex >= 0)
        {
            contextName = contextName.Substring(separatorIndex + 1);
        }

        return $"{contextName.Replace("+", string.Empty)}AutoSDKWrapper";
    }
}
