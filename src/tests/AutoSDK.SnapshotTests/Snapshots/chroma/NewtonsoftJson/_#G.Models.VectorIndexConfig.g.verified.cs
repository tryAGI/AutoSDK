//HintName: G.Models.VectorIndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorIndexConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_function")]
        public global::G.OneOf<object, global::G.EmbeddingFunctionConfiguration?>? EmbeddingFunction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hnsw")]
        public global::G.OneOf<object, global::G.HnswIndexConfig>? Hnsw { get; set; }

        /// <summary>
        /// Key to source the vector from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_key")]
        public string? SourceKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space")]
        public global::G.OneOf<object, global::G.Space2?>? Space { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spann")]
        public global::G.OneOf<object, global::G.SpannIndexConfig>? Spann { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexConfig" /> class.
        /// </summary>
        /// <param name="embeddingFunction"></param>
        /// <param name="hnsw"></param>
        /// <param name="sourceKey">
        /// Key to source the vector from
        /// </param>
        /// <param name="space"></param>
        /// <param name="spann"></param>
        public VectorIndexConfig(
            global::G.OneOf<object, global::G.EmbeddingFunctionConfiguration?>? embeddingFunction,
            global::G.OneOf<object, global::G.HnswIndexConfig>? hnsw,
            string? sourceKey,
            global::G.OneOf<object, global::G.Space2?>? space,
            global::G.OneOf<object, global::G.SpannIndexConfig>? spann)
        {
            this.EmbeddingFunction = embeddingFunction;
            this.Hnsw = hnsw;
            this.SourceKey = sourceKey;
            this.Space = space;
            this.Spann = spann;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexConfig" /> class.
        /// </summary>
        public VectorIndexConfig()
        {
        }
    }
}