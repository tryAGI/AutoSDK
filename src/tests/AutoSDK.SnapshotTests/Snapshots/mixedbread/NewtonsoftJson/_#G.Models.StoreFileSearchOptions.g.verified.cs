//HintName: G.Models.StoreFileSearchOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for configuring store file searches.
    /// </summary>
    public sealed partial class StoreFileSearchOptions
    {
        /// <summary>
        /// Minimum similarity score threshold<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Whether to rewrite the query. Ignored when agentic is enabled (the agent handles query decomposition).<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rewrite_query")]
        public bool? RewriteQuery { get; set; }

        /// <summary>
        /// Whether to rerank results and optional reranking configuration. Ignored when agentic is enabled (the agent handles ranking).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rerank")]
        public global::G.AnyOf<bool?, global::G.RerankConfig, object>? Rerank { get; set; }

        /// <summary>
        /// Whether to use agentic multi-query search with automatic query decomposition and ranking. When enabled, rewrite_query and rerank options are ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agentic")]
        public global::G.AnyOf<bool?, global::G.AgenticSearchConfig, object>? Agentic { get; set; }

        /// <summary>
        /// Whether to return file metadata<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_metadata")]
        public bool? ReturnMetadata { get; set; }

        /// <summary>
        /// Whether to return matching text chunks<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_chunks")]
        public bool? ReturnChunks { get; set; }

        /// <summary>
        /// Number of chunks to return for each file<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunks_per_file")]
        public int? ChunksPerFile { get; set; }

        /// <summary>
        /// Whether to apply search rules<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_search_rules")]
        public bool? ApplySearchRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileSearchOptions" /> class.
        /// </summary>
        /// <param name="scoreThreshold">
        /// Minimum similarity score threshold<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="rewriteQuery">
        /// Whether to rewrite the query. Ignored when agentic is enabled (the agent handles query decomposition).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rerank">
        /// Whether to rerank results and optional reranking configuration. Ignored when agentic is enabled (the agent handles ranking).
        /// </param>
        /// <param name="agentic">
        /// Whether to use agentic multi-query search with automatic query decomposition and ranking. When enabled, rewrite_query and rerank options are ignored.
        /// </param>
        /// <param name="returnMetadata">
        /// Whether to return file metadata<br/>
        /// Default Value: true
        /// </param>
        /// <param name="returnChunks">
        /// Whether to return matching text chunks<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chunksPerFile">
        /// Number of chunks to return for each file<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="applySearchRules">
        /// Whether to apply search rules<br/>
        /// Default Value: true
        /// </param>
        public StoreFileSearchOptions(
            double? scoreThreshold,
            bool? rewriteQuery,
            global::G.AnyOf<bool?, global::G.RerankConfig, object>? rerank,
            global::G.AnyOf<bool?, global::G.AgenticSearchConfig, object>? agentic,
            bool? returnMetadata,
            bool? returnChunks,
            int? chunksPerFile,
            bool? applySearchRules)
        {
            this.ScoreThreshold = scoreThreshold;
            this.RewriteQuery = rewriteQuery;
            this.Rerank = rerank;
            this.Agentic = agentic;
            this.ReturnMetadata = returnMetadata;
            this.ReturnChunks = returnChunks;
            this.ChunksPerFile = chunksPerFile;
            this.ApplySearchRules = applySearchRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileSearchOptions" /> class.
        /// </summary>
        public StoreFileSearchOptions()
        {
        }
    }
}