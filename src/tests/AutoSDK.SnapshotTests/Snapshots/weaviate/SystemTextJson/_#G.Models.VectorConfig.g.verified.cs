//HintName: G.Models.VectorConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration of each named vector.
    /// </summary>
    public sealed partial class VectorConfig
    {
        /// <summary>
        /// Vectorizer for this collection (e.g. `text2vec-transformers`). This will override any cluster-wide default set by an environment variable. &lt;br/&gt;&lt;br/&gt;If `none`, you must import a vector with each object yourself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorizerJsonConverter))]
        public global::G.Vectorizer? Vectorizer { get; set; }

        /// <summary>
        /// Name of the vector index to use, eg. (HNSW)<br/>
        /// Default Value: hnsw
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorIndexType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorIndexTypeJsonConverter))]
        public global::G.VectorIndexType? VectorIndexType { get; set; }

        /// <summary>
        /// Vector index type specific settings. See the [vector index configuration page](https://weaviate.io/developers/weaviate/config-refs/schema/vector-index) for more details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorIndexConfig")]
        public object? VectorIndexConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorConfig" /> class.
        /// </summary>
        /// <param name="vectorizer">
        /// Vectorizer for this collection (e.g. `text2vec-transformers`). This will override any cluster-wide default set by an environment variable. &lt;br/&gt;&lt;br/&gt;If `none`, you must import a vector with each object yourself.
        /// </param>
        /// <param name="vectorIndexType">
        /// Name of the vector index to use, eg. (HNSW)<br/>
        /// Default Value: hnsw
        /// </param>
        /// <param name="vectorIndexConfig">
        /// Vector index type specific settings. See the [vector index configuration page](https://weaviate.io/developers/weaviate/config-refs/schema/vector-index) for more details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorConfig(
            global::G.Vectorizer? vectorizer,
            global::G.VectorIndexType? vectorIndexType,
            object? vectorIndexConfig)
        {
            this.Vectorizer = vectorizer;
            this.VectorIndexType = vectorIndexType;
            this.VectorIndexConfig = vectorIndexConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorConfig" /> class.
        /// </summary>
        public VectorConfig()
        {
        }
    }
}