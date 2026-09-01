using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static string GenerateSystemTextJsonModelFromToJsonMethods(
        string @namespace,
        string className,
        string typeName,
        string modifiers,
        bool isValueType,
        bool isBaseClass,
        bool hasJsonSerializerContext,
        string defaultJsonSerializerContext,
        bool generateRawModelData,
        string rawModelDataMethods)
    {
        using var builder = new NormalizedPooledStringBuilder(8192);
        builder.Append($@"#nullable enable

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
");

        if (hasJsonSerializerContext)
        {
            builder.Append($@"
        {SerializeWithDefaultJsonContextSummary}
        public string ToJson()
        {{
            return ToJson({defaultJsonSerializerContext});
        }}
");
        }

        builder.Append($@"
        {SerializeWithJsonOptionsSummary}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {{
");
        if (hasJsonSerializerContext)
        {
            builder.Append($@"            if (jsonSerializerOptions is null)
            {{
                return ToJson({defaultJsonSerializerContext});
            }}
");
            builder.Append('\n');
        }
        builder.Append($@"            return global::System.Text.Json.JsonSerializer.Serialize(
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
");

        if (hasJsonSerializerContext)
        {
            builder.Append($@"
        {DeserializeWithDefaultJsonContextSummary}
        public static {(isBaseClass ? "T" : typeName)}? FromJson{(isBaseClass ? "<T>" : string.Empty)}(
            string json)
            {(isBaseClass ? $"where T : {className}" : string.Empty)}
        {{
            return FromJson{(isBaseClass ? "<T>" : string.Empty)}(
                json,
                {defaultJsonSerializerContext});
        }}
");
        }

        builder.Append($@"
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
");
        if (hasJsonSerializerContext)
        {
            builder.Append($@"            if (jsonSerializerOptions is null)
            {{
                return FromJson{(isBaseClass ? "<T>" : string.Empty)}(
                    json,
                    {defaultJsonSerializerContext});
            }}
");
            builder.Append('\n');
        }
        builder.Append($@"            return global::System.Text.Json.JsonSerializer.Deserialize<{(isBaseClass ? className : typeName)}>(
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
");

        if (hasJsonSerializerContext)
        {
            builder.Append($@"
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
        }}
");
        }

        builder.Append('\n');

        if (isBaseClass)
        {
            builder.Append($@"        /// <summary>
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
");
            if (hasJsonSerializerContext)
            {
                builder.Append($@"            if (jsonSerializerOptions is null)
            {{
                return await FromJsonStreamAsync<T>(
                    jsonStream,
                    {defaultJsonSerializerContext}).ConfigureAwait(false);
            }}
");
                builder.Append('\n');
            }
            builder.Append($@"            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync<{className}?>(
                jsonStream,
                jsonSerializerOptions).ConfigureAwait(false)) as T{(isValueType ? "?" : "")};
        }}");
        }
        else
        {
            builder.Append($@"        /// <summary>
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
");
            if (hasJsonSerializerContext)
            {
                builder.Append($@"            if (jsonSerializerOptions is null)
            {{
                return FromJsonStreamAsync(
                    jsonStream,
                    {defaultJsonSerializerContext});
            }}
");
                builder.Append('\n');
            }
            builder.Append($@"            return global::System.Text.Json.JsonSerializer.DeserializeAsync<{typeName}?>(
                jsonStream,
                jsonSerializerOptions);
        }}");
        }

        if (generateRawModelData)
        {
            builder.Append(rawModelDataMethods);
        }
        builder.Append(@"
    }
}
");
        return builder.ToString();
    }
}
