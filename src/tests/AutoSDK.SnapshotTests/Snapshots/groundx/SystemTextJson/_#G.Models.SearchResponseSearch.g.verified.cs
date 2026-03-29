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
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.SearchResultItem>? Results { get; set; }

        /// <summary>
        /// The original search request query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Confidence score in the search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The actual search query, if the search request query was re-written
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchQuery")]
        public string? SearchQuery { get; set; }

        /// <summary>
        /// Suggested context for LLM completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// For paginated results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextToken")]
        public string? NextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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