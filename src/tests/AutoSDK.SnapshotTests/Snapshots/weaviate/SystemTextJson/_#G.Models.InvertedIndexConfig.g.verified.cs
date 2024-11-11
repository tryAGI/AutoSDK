//HintName: G.Models.InvertedIndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configure the inverted index built into Weaviate
    /// </summary>
    public sealed partial class InvertedIndexConfig
    {
        /// <summary>
        /// Asynchronous index clean up happens every n seconds<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleanupIntervalSeconds")]
        public double? CleanupIntervalSeconds { get; set; }

        /// <summary>
        /// tuning parameters for the BM25 algorithm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bm25")]
        public global::G.BM25Config? Bm25 { get; set; }

        /// <summary>
        /// fine-grained control over stopword list usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        public global::G.StopwordConfig? Stopwords { get; set; }

        /// <summary>
        /// Index each object by its internal timestamps<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexTimestamps")]
        public bool? IndexTimestamps { get; set; }

        /// <summary>
        /// Index each object with the null state<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexNullState")]
        public bool? IndexNullState { get; set; }

        /// <summary>
        /// Index length of properties<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexPropertyLength")]
        public bool? IndexPropertyLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvertedIndexConfig" /> class.
        /// </summary>
        /// <param name="cleanupIntervalSeconds">
        /// Asynchronous index clean up happens every n seconds<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="bm25">
        /// tuning parameters for the BM25 algorithm
        /// </param>
        /// <param name="stopwords">
        /// fine-grained control over stopword list usage
        /// </param>
        /// <param name="indexTimestamps">
        /// Index each object by its internal timestamps<br/>
        /// Default Value: false
        /// </param>
        /// <param name="indexNullState">
        /// Index each object with the null state<br/>
        /// Default Value: false
        /// </param>
        /// <param name="indexPropertyLength">
        /// Index length of properties<br/>
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InvertedIndexConfig(
            double? cleanupIntervalSeconds,
            global::G.BM25Config? bm25,
            global::G.StopwordConfig? stopwords,
            bool? indexTimestamps,
            bool? indexNullState,
            bool? indexPropertyLength)
        {
            this.CleanupIntervalSeconds = cleanupIntervalSeconds;
            this.Bm25 = bm25;
            this.Stopwords = stopwords;
            this.IndexTimestamps = indexTimestamps;
            this.IndexNullState = indexNullState;
            this.IndexPropertyLength = indexPropertyLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvertedIndexConfig" /> class.
        /// </summary>
        public InvertedIndexConfig()
        {
        }


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
        public static global::G.InvertedIndexConfig? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.InvertedIndexConfig),
                jsonSerializerContext) as global::G.InvertedIndexConfig;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.InvertedIndexConfig? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.InvertedIndexConfig>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.InvertedIndexConfig?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.InvertedIndexConfig),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.InvertedIndexConfig;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.InvertedIndexConfig?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.InvertedIndexConfig?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}