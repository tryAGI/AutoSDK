//HintName: G.Models.QueryFullResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The full response to a RAG query when the result is not streamed.
    /// </summary>
    public sealed partial class QueryFullResponse
    {
        /// <summary>
        /// The summary of the search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_language")]
        public global::G.Language? ResponseLanguage { get; set; }

        /// <summary>
        /// The ranked search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_results")]
        public global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// Indicates the probability that the summary is factually consistent with the results.<br/>
        /// The system excludes this property if it encounters excessively large outputs or search<br/>
        /// results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("factual_consistency_score")]
        public float? FactualConsistencyScore { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_template` templates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// Non-fatal warnings that occurred during request processing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warnings")]
        public global::System.Collections.Generic.IList<global::G.QueryWarning>? Warnings { get; set; }

        /// <summary>
        /// The rewritten queries for the corpora that were searched. Only populated when <br/>
        /// intelligent_query_rewriting is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rewritten_queries")]
        public global::System.Collections.Generic.IList<global::G.RewrittenQuery>? RewrittenQueries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFullResponse" /> class.
        /// </summary>
        /// <param name="summary">
        /// The summary of the search results.
        /// </param>
        /// <param name="responseLanguage">
        /// Languages that the Vectara platform supports.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="searchResults">
        /// The ranked search results.
        /// </param>
        /// <param name="factualConsistencyScore">
        /// Indicates the probability that the summary is factually consistent with the results.<br/>
        /// The system excludes this property if it encounters excessively large outputs or search<br/>
        /// results.
        /// </param>
        /// <param name="renderedPrompt">
        /// The rendered prompt sent to the LLM. Useful when creating customer `prompt_template` templates.
        /// </param>
        /// <param name="warnings">
        /// Non-fatal warnings that occurred during request processing
        /// </param>
        /// <param name="rewrittenQueries">
        /// The rewritten queries for the corpora that were searched. Only populated when <br/>
        /// intelligent_query_rewriting is enabled.
        /// </param>
        public QueryFullResponse(
            string? summary,
            global::G.Language? responseLanguage,
            global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? searchResults,
            float? factualConsistencyScore,
            string? renderedPrompt,
            global::System.Collections.Generic.IList<global::G.QueryWarning>? warnings,
            global::System.Collections.Generic.IList<global::G.RewrittenQuery>? rewrittenQueries)
        {
            this.Summary = summary;
            this.ResponseLanguage = responseLanguage;
            this.SearchResults = searchResults;
            this.FactualConsistencyScore = factualConsistencyScore;
            this.RenderedPrompt = renderedPrompt;
            this.Warnings = warnings;
            this.RewrittenQueries = rewrittenQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFullResponse" /> class.
        /// </summary>
        public QueryFullResponse()
        {
        }
    }
}