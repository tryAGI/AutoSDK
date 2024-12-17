using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
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
        Settings settings,
        bool isValueType,
        string baseClassName,
        bool isBaseClass,
        CancellationToken cancellationToken = default)
    {
        var typeName = $"global::{@namespace}.{className}";
        var modifiers = isValueType
            ? "readonly partial struct"
            : $"{(isBaseClass ? "" : "sealed ")}partial class";
        var isDerivedClass = !string.IsNullOrWhiteSpace(baseClassName);
        
        return settings.JsonSerializerType == JsonSerializerType.SystemTextJson
            ? @$"#nullable enable

namespace {@namespace}
{{
    public {modifiers} {className}
    {{
        {"Serializes the current instance to a JSON string using the provided JsonSerializerContext.".ToXmlDocumentationSummary(level: 8)}
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {{
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                {(isDerivedClass ? $"typeof({baseClassName})" : "this.GetType()")},
                jsonSerializerContext);
        }}

        {"Serializes the current instance to a JSON string using the provided JsonSerializerOptions.".ToXmlDocumentationSummary(level: 8)}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {{
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                {(isDerivedClass ? $"typeof({baseClassName})," : string.Empty)}
                jsonSerializerOptions);
        }}

        {"Deserializes a JSON string using the provided JsonSerializerContext.".ToXmlDocumentationSummary(level: 8)}
        public static {typeName}? FromJson{(isDerivedClass ? "<T>" : string.Empty)}(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
            {(isDerivedClass ? $"where T : {baseClassName}" : string.Empty)}
        {{
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof({(isDerivedClass ? baseClassName : typeName)}),
                jsonSerializerContext) as {(isDerivedClass ? "T" : typeName)}{(isValueType ? "?" : "")};
        }}

        {"Deserializes a JSON string using the provided JsonSerializerOptions.".ToXmlDocumentationSummary(level: 8)}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static {typeName}? FromJson{(isDerivedClass ? "<T>" : string.Empty)}(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
            {(isDerivedClass ? $"where T : {baseClassName}" : string.Empty)}
        {{
            return global::System.Text.Json.JsonSerializer.Deserialize<{(isDerivedClass ? baseClassName : typeName)}>(
                json,
                jsonSerializerOptions){(isDerivedClass ? " as T" : string.Empty)};
        }}

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<{typeName}?> FromJsonStreamAsync{(isDerivedClass ? "<T>" : string.Empty)}(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
            {(isDerivedClass ? $"where T : {baseClassName}" : string.Empty)}
        {{
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof({(isDerivedClass ? baseClassName : typeName)}),
                jsonSerializerContext).ConfigureAwait(false)) as {(isDerivedClass ? "T" : typeName)}{(isValueType ? "?" : "")};
        }}

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static global::System.Threading.Tasks.ValueTask<{typeName}?> FromJsonStreamAsync{(isDerivedClass ? "<T>" : string.Empty)}(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
            {(isDerivedClass ? $"where T : {baseClassName}" : string.Empty)}
        {{
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<{typeName}?>(
                jsonStream,
                jsonSerializerOptions){(isDerivedClass ? " as T" : string.Empty)};
        }}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces()
            : @$"#nullable enable

namespace {@namespace}
{{
    public {modifiers} {className}
    {{
        {"Serializes the current instance to a JSON string using the provided JsonSerializerOptions.".ToXmlDocumentationSummary(level: 8)}
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

        {"Deserializes a JSON string using the provided JsonSerializerOptions.".ToXmlDocumentationSummary(level: 8)}
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
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}