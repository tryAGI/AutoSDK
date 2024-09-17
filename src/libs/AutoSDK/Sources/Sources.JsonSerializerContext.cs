using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContext(
        Client client,
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (!client.Settings.FromCli ||
            !client.Settings.GenerateJsonSerializerContextTypes ||
            client.Settings.JsonSerializerType != JsonSerializerType.SystemTextJson)
        {
            return string.Empty;
        }

        return $@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace {client.Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        {{ 
{client.Converters.Select(x => $@" 
            typeof({x}),
").Inject()}
        }})]
{(types.IsEmpty ? " " : $@"
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::{client.Namespace}.JsonSerializerContextTypes))]")}
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}