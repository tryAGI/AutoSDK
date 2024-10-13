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
        [global::Newtonsoft.Json.JsonProperty("cleanupIntervalSeconds")]
        public double? CleanupIntervalSeconds { get; set; } = 60;

        /// <summary>
        /// tuning parameters for the BM25 algorithm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bm25")]
        public global::G.BM25Config? Bm25 { get; set; }

        /// <summary>
        /// fine-grained control over stopword list usage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stopwords")]
        public global::G.StopwordConfig? Stopwords { get; set; }

        /// <summary>
        /// Index each object by its internal timestamps<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexTimestamps")]
        public bool? IndexTimestamps { get; set; } = false;

        /// <summary>
        /// Index each object with the null state<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexNullState")]
        public bool? IndexNullState { get; set; } = false;

        /// <summary>
        /// Index length of properties<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexPropertyLength")]
        public bool? IndexPropertyLength { get; set; } = false;

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
        public static global::G.InvertedIndexConfig? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.InvertedIndexConfig>(
                json,
                jsonSerializerOptions);
        }

    }
}