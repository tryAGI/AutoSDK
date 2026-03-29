//HintName: G.Models.SearchResponseSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResponseSearch
    {
        /// <summary>
        /// Total results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Search results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.SearchResultItem>? Results { get; set; }

        /// <summary>
        /// The original search request query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Confidence score in the search results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The actual search query, if the search request query was re-written
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchQuery")]
        public string? SearchQuery { get; set; }

        /// <summary>
        /// Suggested context for LLM completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// For paginated results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextToken")]
        public string? NextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseSearch" /> class.
        /// </summary>
        /// <param name="count">
        /// Total results
        /// </param>
        /// <param name="results">
        /// Search results
        /// </param>
        /// <param name="query">
        /// The original search request query
        /// </param>
        /// <param name="score">
        /// Confidence score in the search results
        /// </param>
        /// <param name="searchQuery">
        /// The actual search query, if the search request query was re-written
        /// </param>
        /// <param name="text">
        /// Suggested context for LLM completion
        /// </param>
        /// <param name="nextToken">
        /// For paginated results
        /// </param>
        public SearchResponseSearch(
            int? count,
            global::System.Collections.Generic.IList<global::G.SearchResultItem>? results,
            string? query,
            double? score,
            string? searchQuery,
            string? text,
            string? nextToken)
        {
            this.Count = count;
            this.Results = results;
            this.Query = query;
            this.Score = score;
            this.SearchQuery = searchQuery;
            this.Text = text;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseSearch" /> class.
        /// </summary>
        public SearchResponseSearch()
        {
        }
    }
}