//HintName: G.Models.GraphQueryConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for Knowledge Graph queries.
    /// </summary>
    public sealed partial class GraphQueryConfig
    {
        /// <summary>
        /// Maximum number of subquestions to generate when processing complex queries. Set higher to improve detail, set lower to reduce response time. Range: 1-10, Default: 6.<br/>
        /// Default Value: 6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_subquestions")]
        public int? MaxSubquestions { get; set; }

        /// <summary>
        /// Weight given to search results when ranking and selecting relevant information. Higher values (closer to 100) prioritize keyword-based matching, while lower values (closer to 0) prioritize semantic similarity matching. Use higher values for exact keyword searches, lower values for conceptual similarity searches. Range: 0-100, Default: 50.<br/>
        /// Default Value: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_weight")]
        public int? SearchWeight { get; set; }

        /// <summary>
        /// Level of grounding required for responses, controlling how closely answers must be tied to source material. Set lower for grounded outputs, higher for creativity. Higher values (closer to 1.0) allow more creative interpretation, while lower values (closer to 0.0) stick more closely to source material. Range: 0.0-1.0, Default: 0.0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grounding_level")]
        public double? GroundingLevel { get; set; }

        /// <summary>
        /// Maximum number of text snippets to retrieve from the Knowledge Graph for context. Works in concert with `search_weight` to control best matches vs broader coverage. While technically supports 1-60, values below 5 may return no results due to RAG implementation. Recommended range: 5-25. Due to RAG system behavior, you may see more snippets than requested. Range: 1-60, Default: 30.<br/>
        /// Default Value: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_snippets")]
        public int? MaxSnippets { get; set; }

        /// <summary>
        /// Maximum number of tokens the model can generate in the response. This controls the length of the AI's answer. Set higher for longer answers, set lower for shorter, faster answers. Range: 100-8000, Default: 4000.<br/>
        /// Default Value: 4000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Threshold for keyword-based matching when searching Knowledge Graph content. Set higher for stricter relevance, lower for broader range. Higher values (closer to 1.0) require stronger keyword matches, while lower values (closer to 0.0) allow more lenient matching. Range: 0.0-1.0, Default: 0.7.<br/>
        /// Default Value: 0.7
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyword_threshold")]
        public double? KeywordThreshold { get; set; }

        /// <summary>
        /// Threshold for semantic similarity matching when searching Knowledge Graph content. Set higher for stricter relevance, lower for broader range. Higher values (closer to 1.0) require stronger semantic similarity, while lower values (closer to 0.0) allow more lenient semantic matching. Range: 0.0-1.0, Default: 0.7.<br/>
        /// Default Value: 0.7
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("semantic_threshold")]
        public double? SemanticThreshold { get; set; }

        /// <summary>
        /// Whether to include inline citations in the response, showing which Knowledge Graph sources were used. Default: false.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inline_citations")]
        public bool? InlineCitations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQueryConfig" /> class.
        /// </summary>
        /// <param name="maxSubquestions">
        /// Maximum number of subquestions to generate when processing complex queries. Set higher to improve detail, set lower to reduce response time. Range: 1-10, Default: 6.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="searchWeight">
        /// Weight given to search results when ranking and selecting relevant information. Higher values (closer to 100) prioritize keyword-based matching, while lower values (closer to 0) prioritize semantic similarity matching. Use higher values for exact keyword searches, lower values for conceptual similarity searches. Range: 0-100, Default: 50.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="groundingLevel">
        /// Level of grounding required for responses, controlling how closely answers must be tied to source material. Set lower for grounded outputs, higher for creativity. Higher values (closer to 1.0) allow more creative interpretation, while lower values (closer to 0.0) stick more closely to source material. Range: 0.0-1.0, Default: 0.0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxSnippets">
        /// Maximum number of text snippets to retrieve from the Knowledge Graph for context. Works in concert with `search_weight` to control best matches vs broader coverage. While technically supports 1-60, values below 5 may return no results due to RAG implementation. Recommended range: 5-25. Due to RAG system behavior, you may see more snippets than requested. Range: 1-60, Default: 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens the model can generate in the response. This controls the length of the AI's answer. Set higher for longer answers, set lower for shorter, faster answers. Range: 100-8000, Default: 4000.<br/>
        /// Default Value: 4000
        /// </param>
        /// <param name="keywordThreshold">
        /// Threshold for keyword-based matching when searching Knowledge Graph content. Set higher for stricter relevance, lower for broader range. Higher values (closer to 1.0) require stronger keyword matches, while lower values (closer to 0.0) allow more lenient matching. Range: 0.0-1.0, Default: 0.7.<br/>
        /// Default Value: 0.7
        /// </param>
        /// <param name="semanticThreshold">
        /// Threshold for semantic similarity matching when searching Knowledge Graph content. Set higher for stricter relevance, lower for broader range. Higher values (closer to 1.0) require stronger semantic similarity, while lower values (closer to 0.0) allow more lenient semantic matching. Range: 0.0-1.0, Default: 0.7.<br/>
        /// Default Value: 0.7
        /// </param>
        /// <param name="inlineCitations">
        /// Whether to include inline citations in the response, showing which Knowledge Graph sources were used. Default: false.<br/>
        /// Default Value: false
        /// </param>
        public GraphQueryConfig(
            int? maxSubquestions,
            int? searchWeight,
            double? groundingLevel,
            int? maxSnippets,
            int? maxTokens,
            double? keywordThreshold,
            double? semanticThreshold,
            bool? inlineCitations)
        {
            this.MaxSubquestions = maxSubquestions;
            this.SearchWeight = searchWeight;
            this.GroundingLevel = groundingLevel;
            this.MaxSnippets = maxSnippets;
            this.MaxTokens = maxTokens;
            this.KeywordThreshold = keywordThreshold;
            this.SemanticThreshold = semanticThreshold;
            this.InlineCitations = inlineCitations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQueryConfig" /> class.
        /// </summary>
        public GraphQueryConfig()
        {
        }
    }
}