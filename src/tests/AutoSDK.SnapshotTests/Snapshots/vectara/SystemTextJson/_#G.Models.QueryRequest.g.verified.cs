//HintName: G.Models.QueryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query one or more corpora.<br/>
    /// Example: {"query":"Summarize risk exposure and QA issues across divisions","search":{"corpora":[{"corpus_key":"ops_manuals","metadata_filter":"doc.topic = \u0027QA\u0027 AND doc.severity = \u0027high\u0027","lexical_interpolation":0.005},{"corpus_key":"fin_docs","metadata_filter":"doc.region = \u0027EMEA\u0027 AND doc.type = \u0027risk_report\u0027","lexical_interpolation":0.005}],"context_configuration":{"sentences_before":2,"sentences_after":2,"start_tag":"\u003Cem\u003E","end_tag":"\u003C/em\u003E"},"reranker":{"type":"customer_reranker","reranker_name":"Rerank_Multilingual_v1"}},"generation":{"generation_preset_name":"vectara-summary-ext-24-05-med-omni","response_language":"eng","enable_factual_consistency_score":true},"stream_response":false}
    /// </summary>
    public sealed partial class QueryRequest
    {
        /// <summary>
        /// The search query string, which is the question the user is asking.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </summary>
        /// <example>Am I allowed to bring pets to work?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The parameters to search one or more corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchCorporaParametersJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SearchCorporaParameters Search { get; set; }

        /// <summary>
        /// The parameters to control generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public global::G.GenerationParameters? Generation { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Indicates whether to save the query to query history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_history")]
        public bool? SaveHistory { get; set; }

        /// <summary>
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to extract metadata filter and rewrite the query to improve search results. Read [here](https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligent_query_rewriting")]
        public bool? IntelligentQueryRewriting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query string, which is the question the user is asking.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </param>
        /// <param name="search">
        /// The parameters to search one or more corpora.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save the query to query history.
        /// </param>
        /// <param name="intelligentQueryRewriting">
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to extract metadata filter and rewrite the query to improve search results. Read [here](https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting) for more details.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRequest(
            string query,
            global::G.SearchCorporaParameters search,
            global::G.GenerationParameters? generation,
            bool? streamResponse,
            bool? saveHistory,
            bool? intelligentQueryRewriting)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Search = search;
            this.Generation = generation;
            this.StreamResponse = streamResponse;
            this.SaveHistory = saveHistory;
            this.IntelligentQueryRewriting = intelligentQueryRewriting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequest" /> class.
        /// </summary>
        public QueryRequest()
        {
        }
    }
}