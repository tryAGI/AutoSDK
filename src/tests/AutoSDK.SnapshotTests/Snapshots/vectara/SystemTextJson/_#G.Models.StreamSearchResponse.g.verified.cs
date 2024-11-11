//HintName: G.Models.StreamSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The search response results.
    /// </summary>
    public sealed partial class StreamSearchResponse
    {
        /// <summary>
        /// When the streaming event has the search results, the<br/>
        /// type will be `search_results`.<br/>
        /// Default Value: search_results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ranked search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSearchResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// When the streaming event has the search results, the<br/>
        /// type will be `search_results`.<br/>
        /// Default Value: search_results
        /// </param>
        /// <param name="searchResults">
        /// The ranked search results.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StreamSearchResponse(
            string? type,
            global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? searchResults)
        {
            this.Type = type;
            this.SearchResults = searchResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSearchResponse" /> class.
        /// </summary>
        public StreamSearchResponse()
        {
        }
    }
}