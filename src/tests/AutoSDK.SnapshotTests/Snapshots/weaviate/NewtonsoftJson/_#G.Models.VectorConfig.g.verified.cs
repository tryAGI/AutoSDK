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
        [global::Newtonsoft.Json.JsonProperty("vectorizer")]
        public global::G.Vectorizer? Vectorizer { get; set; }

        /// <summary>
        /// Name of the vector index to use, eg. (HNSW)<br/>
        /// Default Value: hnsw
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectorIndexType")]
        public global::G.VectorIndexType? VectorIndexType { get; set; } = global::G.VectorIndexType.Hnsw;

        /// <summary>
        /// Vector index type specific settings. See the [vector index configuration page](https://weaviate.io/developers/weaviate/config-refs/schema/vector-index) for more details
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectorIndexConfig")]
        public global::G.VectorIndexConfig? VectorIndexConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}