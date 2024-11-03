//HintName: G.Models.TranscriptionSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionSegment
    {
        /// <summary>
        /// Unique identifier of the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Seek offset of the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seek", Required = global::Newtonsoft.Json.Required.Always)]
        public int Seek { get; set; } = default!;

        /// <summary>
        /// Start time of the segment in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public float Start { get; set; } = default!;

        /// <summary>
        /// End time of the segment in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public float End { get; set; } = default!;

        /// <summary>
        /// Text content of the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Array of token IDs for the text content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Tokens { get; set; } = default!;

        /// <summary>
        /// Temperature parameter used for generating the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature", Required = global::Newtonsoft.Json.Required.Always)]
        public float Temperature { get; set; } = default!;

        /// <summary>
        /// Average logprob of the segment. If the value is lower than -1, consider the logprobs failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_logprob", Required = global::Newtonsoft.Json.Required.Always)]
        public float AvgLogprob { get; set; } = default!;

        /// <summary>
        /// Compression ratio of the segment. If the value is greater than 2.4, consider the compression failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compression_ratio", Required = global::Newtonsoft.Json.Required.Always)]
        public float CompressionRatio { get; set; } = default!;

        /// <summary>
        /// Probability of no speech in the segment. If the value is higher than 1.0 and the `avg_logprob` is below -1, consider this segment silent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("no_speech_prob", Required = global::Newtonsoft.Json.Required.Always)]
        public float NoSpeechProb { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.TranscriptionSegment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TranscriptionSegment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.TranscriptionSegment?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.TranscriptionSegment?>(serializer.Deserialize<global::G.TranscriptionSegment>(jsonReader));
        }

    }
}