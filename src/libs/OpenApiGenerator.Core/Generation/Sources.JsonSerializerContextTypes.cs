using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContextTypes(
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (types.IsEmpty ||
            !types[0].GenerateJsonSerializerContextTypes ||
            types[0].JsonSerializerType != JsonSerializerType.SystemTextJson)
        {
            return string.Empty;
        }
        
        return $@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace {types[0].Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    public sealed partial class JsonSerializerContextTypes
    {{
{types.Select((type, i) => @$"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {type.CSharpTypeWithNullability} Type{i} {{ get; set; }}").Inject()}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}