using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContext(
        EndPoint endPoint,
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (!endPoint.Settings.FromCli ||
            !endPoint.Settings.GenerateJsonSerializerContextTypes ||
            endPoint.Settings.JsonSerializerType != JsonSerializerType.SystemTextJson)
        {
            return string.Empty;
        }

        return $@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace {endPoint.Namespace}
{{
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        {{ 
{endPoint.Converters.Select(x => $@" 
            typeof({x}),
").Inject()}
        }})]
{(types.IsEmpty ? " " : $@"
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::{endPoint.Namespace}.JsonSerializerContextTypes))]")}
    internal sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}