//HintName: G.Models.SearchRequestsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request search results with pagination
    /// </summary>
    public sealed partial class SearchRequestsResponse
    {
        /// <summary>
        /// Cursor for the next page of results, null if no more pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Array of matching request results, ordered by relevance or recency
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SearchRequestsResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestsResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="results">
        /// Array of matching request results, ordered by relevance or recency
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
        public SearchRequestsResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::G.SearchRequestsResponseResult> results,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestsResponse" /> class.
        /// </summary>
        public SearchRequestsResponse()
        {
        }
    }
}