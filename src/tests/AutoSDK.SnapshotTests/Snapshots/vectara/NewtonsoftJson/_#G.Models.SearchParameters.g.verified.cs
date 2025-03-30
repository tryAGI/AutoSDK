//HintName: G.Models.SearchParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search parameters to retrieve knowledge for the query.
    /// </summary>
    public sealed partial class SearchParameters
    {
        /// <summary>
        /// Specifies how many results into the result to skip. This is useful for pagination.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// The maximum number of results returned.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Configuration on the presentation of each document part in the result set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_configuration")]
        public global::G.ContextConfiguration? ContextConfiguration { get; set; }

        /// <summary>
        /// Rerank results of the search. Rerankers are very powerful tools to improve the order of search results.<br/>
        /// By default the search will use the most powerful reranker available to the customer's plan.<br/>
        /// To disable reranking, set the reranker `type` to `"none"`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reranker")]
        public global::G.SearchReranker? Reranker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParameters" /> class.
        /// </summary>
        /// <param name="offset">
        /// Specifies how many results into the result to skip. This is useful for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// The maximum number of results returned.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="contextConfiguration">
        /// Configuration on the presentation of each document part in the result set.
        /// </param>
        /// <param name="reranker">
        /// Rerank results of the search. Rerankers are very powerful tools to improve the order of search results.<br/>
        /// By default the search will use the most powerful reranker available to the customer's plan.<br/>
        /// To disable reranking, set the reranker `type` to `"none"`.
        /// </param>
        public SearchParameters(
            int? offset,
            int? limit,
            global::G.ContextConfiguration? contextConfiguration,
            global::G.SearchReranker? reranker)
        {
            this.Offset = offset;
            this.Limit = limit;
            this.ContextConfiguration = contextConfiguration;
            this.Reranker = reranker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParameters" /> class.
        /// </summary>
        public SearchParameters()
        {
        }
    }
}