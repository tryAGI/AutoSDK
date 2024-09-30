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
        public string? Type { get; set; } = "search_results";

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
    }
}