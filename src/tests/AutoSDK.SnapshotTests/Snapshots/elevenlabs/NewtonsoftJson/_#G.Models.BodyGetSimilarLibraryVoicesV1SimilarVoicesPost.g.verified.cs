//HintName: G.Models.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGetSimilarLibraryVoicesV1SimilarVoicesPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_file")]
        public byte[]? AudioFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_filename")]
        public string? AudioFilename { get; set; }

        /// <summary>
        /// Threshold for voice similarity between provided sample and library voices. Must be in range &lt;0, 2&gt;. The smaller the value the more similar voices will be returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarity_threshold")]
        public double? SimilarityThreshold { get; set; }

        /// <summary>
        /// Number of most similar voices to return. If similarity_threshold is provided, less than this number of voices may be returned. Must be in range &lt;1, 100&gt;.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGetSimilarLibraryVoicesV1SimilarVoicesPost" /> class.
        /// </summary>
        /// <param name="audioFile"></param>
        /// <param name="audioFilename"></param>
        /// <param name="similarityThreshold">
        /// Threshold for voice similarity between provided sample and library voices. Must be in range &lt;0, 2&gt;. The smaller the value the more similar voices will be returned.
        /// </param>
        /// <param name="topK">
        /// Number of most similar voices to return. If similarity_threshold is provided, less than this number of voices may be returned. Must be in range &lt;1, 100&gt;.
        /// </param>
        public BodyGetSimilarLibraryVoicesV1SimilarVoicesPost(
            byte[]? audioFile,
            string? audioFilename,
            double? similarityThreshold,
            int? topK)
        {
            this.AudioFile = audioFile;
            this.AudioFilename = audioFilename;
            this.SimilarityThreshold = similarityThreshold;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGetSimilarLibraryVoicesV1SimilarVoicesPost" /> class.
        /// </summary>
        public BodyGetSimilarLibraryVoicesV1SimilarVoicesPost()
        {
        }


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
        public static global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost?>(serializer.Deserialize<global::G.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost>(jsonReader));
        }

    }
}