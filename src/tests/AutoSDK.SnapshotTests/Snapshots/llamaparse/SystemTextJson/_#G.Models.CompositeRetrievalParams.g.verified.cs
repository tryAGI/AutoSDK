//HintName: G.Models.CompositeRetrievalParams.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompositeRetrievalParams
    {
        /// <summary>
        /// The mode of composite retrieval.<br/>
        /// Default Value: full
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompositeRetrievalModeJsonConverter))]
        public global::G.CompositeRetrievalMode? Mode { get; set; }

        /// <summary>
        /// (use rerank_config.top_n instead) The number of nodes to retrieve after reranking over retrieved nodes from all retrieval tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank_top_n")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? RerankTopN { get; set; }

        /// <summary>
        /// The rerank configuration for composite retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank_config")]
        public global::G.ReRankConfig? RerankConfig { get; set; }

        /// <summary>
        /// The query to retrieve against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievalParams" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to retrieve against.
        /// </param>
        /// <param name="mode">
        /// The mode of composite retrieval.<br/>
        /// Default Value: full
        /// </param>
        /// <param name="rerankConfig">
        /// The rerank configuration for composite retrieval.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositeRetrievalParams(
            string query,
            global::G.CompositeRetrievalMode? mode,
            global::G.ReRankConfig? rerankConfig)
        {
            this.Mode = mode;
            this.RerankConfig = rerankConfig;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRetrievalParams" /> class.
        /// </summary>
        public CompositeRetrievalParams()
        {
        }
    }
}