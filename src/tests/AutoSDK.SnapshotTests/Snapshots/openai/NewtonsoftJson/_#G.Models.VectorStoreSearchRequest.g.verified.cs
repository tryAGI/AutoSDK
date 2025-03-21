//HintName: G.Models.VectorStoreSearchRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreSearchRequest
    {
        /// <summary>
        /// A query string for a search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>> Query { get; set; } = default!;

        /// <summary>
        /// Whether to rewrite the natural language query for vector search.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rewrite_query")]
        public bool? RewriteQuery { get; set; }

        /// <summary>
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// A filter to apply based on file attributes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>? Filters { get; set; }

        /// <summary>
        /// Ranking options for search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranking_options")]
        public global::G.VectorStoreSearchRequestRankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// A query string for a search
        /// </param>
        /// <param name="rewriteQuery">
        /// Whether to rewrite the natural language query for vector search.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxNumResults">
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filters">
        /// A filter to apply based on file attributes.
        /// </param>
        /// <param name="rankingOptions">
        /// Ranking options for search.
        /// </param>
        public VectorStoreSearchRequest(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> query,
            bool? rewriteQuery,
            int? maxNumResults,
            global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>? filters,
            global::G.VectorStoreSearchRequestRankingOptions? rankingOptions)
        {
            this.Query = query;
            this.RewriteQuery = rewriteQuery;
            this.MaxNumResults = maxNumResults;
            this.Filters = filters;
            this.RankingOptions = rankingOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchRequest" /> class.
        /// </summary>
        public VectorStoreSearchRequest()
        {
        }
    }
}