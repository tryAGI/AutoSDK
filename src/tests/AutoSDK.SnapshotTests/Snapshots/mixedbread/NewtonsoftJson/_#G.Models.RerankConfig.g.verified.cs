//HintName: G.Models.RerankConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a reranking configuration.
    /// </summary>
    public sealed partial class RerankConfig
    {
        /// <summary>
        /// The name of the reranking model<br/>
        /// Default Value: mixedbread-ai/mxbai-rerank-large-v2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Whether to include metadata in the reranked results<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_metadata")]
        public global::G.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? WithMetadata { get; set; }

        /// <summary>
        /// Maximum number of results to return after reranking. If None, returns all reranked results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the reranking model<br/>
        /// Default Value: mixedbread-ai/mxbai-rerank-large-v2
        /// </param>
        /// <param name="withMetadata">
        /// Whether to include metadata in the reranked results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topK">
        /// Maximum number of results to return after reranking. If None, returns all reranked results.
        /// </param>
        public RerankConfig(
            string? model,
            global::G.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? withMetadata,
            int? topK)
        {
            this.Model = model;
            this.WithMetadata = withMetadata;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankConfig" /> class.
        /// </summary>
        public RerankConfig()
        {
        }
    }
}