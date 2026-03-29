//HintName: G.Models.SparseVectorIndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SparseVectorIndexConfig
    {
        /// <summary>
        /// Whether this embedding is BM25
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bm25")]
        public bool? Bm25 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_function")]
        public global::G.OneOf<object, global::G.EmbeddingFunctionConfiguration?>? EmbeddingFunction { get; set; }

        /// <summary>
        /// Key to source the sparse vector from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_key")]
        public string? SourceKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorIndexConfig" /> class.
        /// </summary>
        /// <param name="bm25">
        /// Whether this embedding is BM25
        /// </param>
        /// <param name="embeddingFunction"></param>
        /// <param name="sourceKey">
        /// Key to source the sparse vector from
        /// </param>
        public SparseVectorIndexConfig(
            bool? bm25,
            global::G.OneOf<object, global::G.EmbeddingFunctionConfiguration?>? embeddingFunction,
            string? sourceKey)
        {
            this.Bm25 = bm25;
            this.EmbeddingFunction = embeddingFunction;
            this.SourceKey = sourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorIndexConfig" /> class.
        /// </summary>
        public SparseVectorIndexConfig()
        {
        }
    }
}