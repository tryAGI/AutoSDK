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
        
        return settings.UsesSystemTextJson()
            ? NormalizedString.Create(@$"#nullable enable

namespace {@namespace}
{{
    public {modifiers} {className}
    {{
        {SerializeWithJsonContextSummary}
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {{
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                {(isBaseClass ? $"typeof({className})" : "this.GetType()")},
                jsonSerializerContext);
        }}
{(hasJsonSerializerContext ? $@"
        {SerializeWithDefaultJsonContextSummary}
        public string ToJson()
        {{
            return ToJson({defaultJsonSerializerContext});
        }}" : TrimmedLine)}

        {SerializeWithJsonOptionsSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {{
{(hasJsonSerializerContext ? $@"            if (jsonSerializerOptions is null)
            {{
                return ToJson({defaultJsonSerializerContext});
            }}
" : TrimmedLine)}
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                {(isBaseClass ? $"typeof({className})," : string.Empty)}
                jsonSerializerOptions);
        }}

        {DeserializeWithJsonContextSummary}
        public static {(isBaseClass ? "T" : typeName)}? FromJson{(isBaseClass ? "<T>" : string.Empty)}(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
            {(isBaseClass ? $"where T : {className}" : string.Empty)}
        {{
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof({(isBaseClass ? className : typeName)}),
                jsonSerializerContext) as {(isBaseClass ? "T" : typeName)}{(isValueType ? "?" : "")};
        }}
{(hasJsonSerializerContext ? $@"
        {DeserializeWithDefaultJsonContextSummary}
        public static {(isBaseClass ? "T" : typeName)}? FromJson{(isBaseClass ? "<T>" : string.Empty)}(
            string json)
            {(isBaseClass ? $"where T : {className}" : string.Empty)}
        {{
            return FromJson{(isBaseClass ? "<T>" : string.Empty)}(
                json,
                {defaultJsonSerializerContext});
        }}" : TrimmedLine)}

        {DeserializeWithJsonOptionsSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static {(isBaseClass ? "T" : typeName)}? FromJson{(isBaseClass ? "<T>" : string.Empty)}(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
            {(isBaseClass ? $"where T : {className}" : string.Empty)}
        {{
{(hasJsonSerializerContext ? $@"            if (jsonSerializerOptions is null)
            {{
                return FromJson{(isBaseClass ? "<T>" : string.Empty)}(
                    json,
                    {defaultJsonSerializerContext});
            }}
" : TrimmedLine)}
            return global::System.Text.Json.JsonSerializer.Deserialize<{(isBaseClass ? className : typeName)}>(
                json,
                jsonSerializerOptions){(isBaseClass ? " as T" : string.Empty)};
        }}

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<{(isBaseClass ? "T?" : $"{typeName}?")}> FromJsonStreamAsync{(isBaseClass ? "<T>" : string.Empty)}(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
            {(isBaseClass ? $"where T : {className}" : string.Empty)}
        {{
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof({(isBaseClass ? className : typeName)}),
                jsonSerializerContext).ConfigureAwait(false)) as {(isBaseClass ? "T" : typeName)}{(isValueType ? "?" : "")};
        }}
{(hasJsonSerializerContext ? $@"
        /// <summary>
        /// Deserializes a JSON stream using the generated default JsonSerializerContext.
        /// </summary>
        public static global::System.Threading.Tasks.ValueTask<{(isBaseClass ? "T?" : $"{typeName}?")}> FromJsonStreamAsync{(isBaseClass ? "<T>" : string.Empty)}(
            global::System.IO.Stream jsonStream)
            {(isBaseClass ? $"where T : {className}" : string.Empty)}
        {{
            return FromJsonStreamAsync{(isBaseClass ? "<T>" : string.Empty)}(
                jsonStream,
                {defaultJsonSerializerContext});
        }}" : TrimmedLine)}

{(isBaseClass ? $@" 
        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static async global::System.Threading.Tasks.ValueTask<T?> FromJsonStreamAsync<T>(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
            where T : {className}
        {{
{(hasJsonSerializerContext ? $@"            if (jsonSerializerOptions is null)
            {{
                return await FromJsonStreamAsync<T>(
                    jsonStream,
                    {defaultJsonSerializerContext}).ConfigureAwait(false);
            }}
" : TrimmedLine)}
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync<{className}?>(
                jsonStream,
                jsonSerializerOptions).ConfigureAwait(false)) as T{(isValueType ? "?" : "")};
        }}" : $@" 
        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static global::System.Threading.Tasks.ValueTask<{typeName}?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {{
{(hasJsonSerializerContext ? $@"            if (jsonSerializerOptions is null)
            {{
                return FromJsonStreamAsync(
                    jsonStream,
                    {defaultJsonSerializerContext});
            }}
" : TrimmedLine)}
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<{typeName}?>(
                jsonStream,
                jsonSerializerOptions);
        }}")}
{rawModelDataMethods}
    }}
}}
")
            : NormalizedString.Create(@$"#nullable enable

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
