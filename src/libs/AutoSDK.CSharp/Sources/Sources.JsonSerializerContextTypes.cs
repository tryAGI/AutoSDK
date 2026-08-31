using AutoSDK.Extensions;
using AutoSDK.Models;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateJsonSerializerContextTypes(
        string @namespace,
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        return GenerateJsonSerializerContextTypes(
            @namespace,
            types,
            new JsonSerializerContextGenerationState(),
            cancellationToken);
    }

    internal static string GenerateJsonSerializerContextTypes(
        string @namespace,
        EquatableArray<TypeData> types,
        JsonSerializerContextGenerationState generationState,
        CancellationToken cancellationToken = default)
    {
        if (types.IsEmpty)
        {
            return string.Empty;
        }

        var allDistinctTypes = types
            .Select(x => x.CSharpTypeWithNullability)
            .Distinct()
            .ToArray();
        var typeInfoNames = generationState.TypeInfoNames;
        var concreteListTypes = GetConcreteListTypes(allDistinctTypes);
        var typeComponents = generationState.GetJsonSerializableTypeComponents(types);
        var skippedContextTypes = GetCollidingJsonSerializerContextTypes(
            types,
            allDistinctTypes,
            concreteListTypes,
            typeInfoNames,
            typeComponents);
        var distinctTypes = allDistinctTypes
            .Where(ShouldIncludeInJsonSerializerContextTypes)
            .Where(x => !skippedContextTypes.Contains(x))
            .ToArray();

        concreteListTypes = concreteListTypes
            .Where(ShouldIncludeInJsonSerializerContextTypes)
            .Where(x => !skippedContextTypes.Contains(x))
            .ToArray();

        var initialCapacity = 2048;
        foreach (var type in distinctTypes)
        {
            initialCapacity = checked(initialCapacity + type.Length + 128);
        }
        foreach (var type in concreteListTypes)
        {
            initialCapacity = checked(initialCapacity + type.Length + 128);
        }

        using var builder = new PooledStringBuilder(initialCapacity);
        builder.Append($@"
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace {@namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    public sealed partial class JsonSerializerContextTypes
    {{
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary {{ get; set; }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary {{ get; set; }}

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList {{ get; set; }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public global::System.Text.Json.JsonElement? JsonElement {{ get; set; }}
");
        for (var index = 0; index < distinctTypes.Length; index++)
        {
            builder.Append("\n        ");
            AppendXmlDocumentationSummary(builder, string.Empty, level: 8);
            builder.Append($@"
        public {distinctTypes[index]} Type{index} {{ get; set; }}");
        }

        builder.Append('\n');
        for (var index = 0; index < concreteListTypes.Length; index++)
        {
            builder.Append("\n        ");
            AppendXmlDocumentationSummary(builder, string.Empty, level: 8);
            builder.Append($@"
        public {concreteListTypes[index]} ListType{index} {{ get; set; }}");
        }

        builder.Append(@"
    }
}");
        return builder.ToString();
    }
}
