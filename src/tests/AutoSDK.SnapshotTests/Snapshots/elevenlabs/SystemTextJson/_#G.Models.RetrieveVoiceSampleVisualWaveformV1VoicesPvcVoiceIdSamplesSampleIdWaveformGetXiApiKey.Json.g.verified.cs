//HintName: G.Models.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey.Json.g.cs
#nullable enable

namespace G
{
    public sealed partial class RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey
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
        public static global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey),
                jsonSerializerContext) as global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.RetrieveVoiceSampleVisualWaveformV1VoicesPvcVoiceIdSamplesSampleIdWaveformGetXiApiKey?>(
                jsonStream,
                jsonSerializerOptions);
        }
    }
}
