//HintName: G.Models.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey.Json.g.cs
#nullable enable

namespace G
{
    public sealed partial class GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey
    {
        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey),
                jsonSerializerContext) as global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.GetAPlsFileWithAPronunciationDictionaryVersionRulesV1PronunciationDictionariesDictionaryIdVersionIdDownloadGetXiApiKey?>(
                jsonStream,
                jsonSerializerOptions);
        }
    }
}
