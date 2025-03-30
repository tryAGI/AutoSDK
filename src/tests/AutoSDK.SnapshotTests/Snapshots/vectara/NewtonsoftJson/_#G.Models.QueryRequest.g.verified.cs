//HintName: G.Models.QueryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query one or more corpora.
    /// </summary>
    public sealed partial class QueryRequest
    {
        /// <summary>
        /// The search query string, which is the question the user is asking.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </summary>
        /// <example>Am I allowed to bring pets to work?</example>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// The parameters to search one or more corpora.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SearchCorporaParameters Search { get; set; } = default!;

        /// <summary>
        /// The parameters to control generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation")]
        public global::G.GenerationParameters? Generation { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Indicates whether to save the query to query history.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("save_history")]
        public bool? SaveHistory { get; set; }

        /// <summary>
        /// Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to<br/>
        /// extract metadata filter and rewrite the query to improve search results.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("intelligent_query_rewriting")]
        public bool? IntelligentQueryRewriting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to<br/>
        /// extract metadata filter and rewrite the query to improve search results.<br/>
        /// Default Value: false
        /// </param>
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