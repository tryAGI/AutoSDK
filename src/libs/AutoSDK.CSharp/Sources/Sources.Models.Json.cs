using AutoSDK.Extensions;
using AutoSDK.Models;
namespace AutoSDK.Generation;

public static partial class Sources
{
    private static readonly string SerializeWithJsonContextSummary =
        "Serializes the current instance to a JSON string using the provided JsonSerializerContext."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string SerializeWithDefaultJsonContextSummary =
        "Serializes the current instance to a JSON string using the generated default JsonSerializerContext."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string SerializeWithJsonOptionsSummary =
        "Serializes the current instance to a JSON string using the provided JsonSerializerOptions."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string DeserializeWithJsonContextSummary =
        "Deserializes a JSON string using the provided JsonSerializerContext."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string DeserializeWithDefaultJsonContextSummary =
        "Deserializes a JSON string using the generated default JsonSerializerContext."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string DeserializeWithJsonOptionsSummary =
        "Deserializes a JSON string using the provided JsonSerializerOptions."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string SerializeRawWithJsonContextSummary =
        "Serializes the current instance to raw JSON using the provided JsonSerializerContext."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string SerializeRawWithDefaultJsonContextSummary =
        "Serializes the current instance to raw JSON using the generated default JsonSerializerContext."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string SerializeRawWithJsonOptionsSummary =
        "Serializes the current instance to raw JSON using the provided JsonSerializerOptions."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string DeserializeRawSummary =
        "Deserializes raw JSON while preserving unknown JSON properties."
            .ToXmlDocumentationSummary(level: 8);
    private static readonly string DeserializeRawWithDefaultJsonContextSummary =
        "Deserializes raw JSON while preserving unknown JSON properties using the generated default JsonSerializerContext."
            .ToXmlDocumentationSummary(level: 8);

    public static string GenerateClassFromToJsonMethods(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        if (modelData.IsDerivedClass)
        {
            return string.Empty;
        }

        return GenerateModelFromToJsonMethods(
            @namespace: modelData.Namespace,
            className: modelData.ClassName,
            settings: modelData.Settings,
            isValueType: false,
            baseClassName: modelData.BaseClass,
            isBaseClass: modelData.IsBaseClass,
            cancellationToken);
    }
    
    public static string GenerateAnyOfFromToJsonMethods(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var types = $"<{string.Join(", ", Enumerable.Range(1, anyOfData.Count).Select(x => $"T{x}"))}>";
        var className = !anyOfData.IsNamed
            ? $"{anyOfData.SubType}{types}"
            : anyOfData.Name;
        
        return GenerateModelFromToJsonMethods(
            @namespace: anyOfData.Namespace,
            className: className,
            settings: anyOfData.Settings,
            isValueType: true,
            baseClassName: string.Empty,
            isBaseClass: false,
            cancellationToken);
    }

    public static string GenerateModelFromToJsonMethods(
        string @namespace,
        string className,
        EmitterSettings settings,
        bool isValueType,
        string baseClassName,
        bool isBaseClass,
        CancellationToken cancellationToken = default)
    {
        var typeName = $"global::{@namespace}.{className}";
        var modifiers = isValueType
            ? "readonly partial struct"
            : $"{(isBaseClass ? "" : "sealed ")}partial class";
        var hasJsonSerializerContext = settings.HasJsonSerializerContext();
        var defaultJsonSerializerContext = hasJsonSerializerContext
            ? $"global::{settings.JsonSerializerContext}.Default"
            : string.Empty;
        var rawModelDataMethods = settings.GenerateRawModelData && !isValueType
            ? settings.UsesSystemTextJson()
                ? GenerateSystemTextJsonRawModelDataMethods(typeName, className, isBaseClass, defaultJsonSerializerContext)
                : GenerateNewtonsoftRawModelDataMethods(typeName)
            : TrimmedLine;

        if (settings.UsesSystemTextJson())
        {
            return GenerateSystemTextJsonModelFromToJsonMethods(
                @namespace,
                className,
                typeName,
                modifiers,
                isValueType,
                isBaseClass,
                hasJsonSerializerContext,
                defaultJsonSerializerContext,
                settings.GenerateRawModelData && !isValueType,
                rawModelDataMethods);
        }

        return NormalizedString.Create(@$"#nullable enable

namespace {@namespace}
{{
    public {modifiers} {className}
    {{
        {SerializeWithJsonOptionsSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {{
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }}

        {DeserializeWithJsonOptionsSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static {typeName}? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {{
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<{typeName}>(
                json,
                jsonSerializerOptions);
        }}

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static global::System.Threading.Tasks.ValueTask<{typeName}?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {{
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<{typeName}?>(serializer.Deserialize<{typeName}>(jsonReader));
        }}
{rawModelDataMethods}
    }}
}}
");
    }

    private static string GenerateSystemTextJsonRawModelDataMethods(
        string typeName,
        string className,
        bool isBaseClass,
        string defaultJsonSerializerContext)
    {
        var contextReturnType = isBaseClass ? "T" : typeName;
        var contextGenericSuffix = isBaseClass ? "<T>" : string.Empty;
        var contextWhereClause = isBaseClass ? $"where T : {className}" : string.Empty;
        var hasJsonSerializerContext = !string.IsNullOrWhiteSpace(defaultJsonSerializerContext);

        return $@"

        {SerializeRawWithJsonContextSummary}
        public string ToRawJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {{
            return ToJson(jsonSerializerContext);
        }}
{(hasJsonSerializerContext ? $@"
        {SerializeRawWithDefaultJsonContextSummary}
        public string ToRawJson()
        {{
            return ToRawJson({defaultJsonSerializerContext});
        }}" : TrimmedLine)}

        {SerializeRawWithJsonOptionsSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public string ToRawJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {{
{(hasJsonSerializerContext ? $@"            if (jsonSerializerOptions is null)
            {{
                return ToRawJson({defaultJsonSerializerContext});
            }}
" : TrimmedLine)}
            return ToJson(jsonSerializerOptions);
        }}

        {DeserializeRawSummary}
        public static {contextReturnType}? FromRawUnchecked{contextGenericSuffix}(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
            {contextWhereClause}
        {{
            return FromJson{contextGenericSuffix}(json, jsonSerializerContext);
        }}
{(hasJsonSerializerContext ? $@"
        {DeserializeRawWithDefaultJsonContextSummary}
        public static {contextReturnType}? FromRawUnchecked{contextGenericSuffix}(
            string json)
            {contextWhereClause}
        {{
            return FromRawUnchecked{contextGenericSuffix}(
                json,
                {defaultJsonSerializerContext});
        }}" : TrimmedLine)}

        {DeserializeRawSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static {contextReturnType}? FromRawUnchecked{contextGenericSuffix}(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
            {contextWhereClause}
        {{
{(hasJsonSerializerContext ? $@"            if (jsonSerializerOptions is null)
            {{
                return FromRawUnchecked{contextGenericSuffix}(
                    json,
                    {defaultJsonSerializerContext});
            }}
" : TrimmedLine)}
            return FromJson{contextGenericSuffix}(json, jsonSerializerOptions);
        }}";
    }

    private static string GenerateNewtonsoftRawModelDataMethods(
        string typeName)
    {
        return $@"

        {SerializeRawWithJsonOptionsSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public string ToRawJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {{
            return ToJson(jsonSerializerOptions);
        }}

        {DeserializeRawSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static {typeName}? FromRawUnchecked(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {{
            return FromJson(json, jsonSerializerOptions);
        }}";
    }
}
