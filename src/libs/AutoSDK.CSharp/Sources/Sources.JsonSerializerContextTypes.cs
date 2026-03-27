using AutoSDK.Extensions;
using AutoSDK.Models;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContextTypes(
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (types.IsEmpty)
        {
            return string.Empty;
        }

        var distinctTypes = types
            .Select(x => x.CSharpTypeWithNullability)
            .Distinct()
            .ToArray();

        var concreteListTypes = GetConcreteListTypes(distinctTypes);

        return $@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace {types[0].Namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    public sealed partial class JsonSerializerContextTypes
    {{
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary {{ get; set; }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary {{ get; set; }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public global::System.Text.Json.JsonElement? JsonElement {{ get; set; }}

{distinctTypes.Select((type, i) => @$"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {type} Type{i} {{ get; set; }}").Inject()}

{concreteListTypes.Select((type, i) => @$"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {type} ListType{i} {{ get; set; }}").Inject()}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
