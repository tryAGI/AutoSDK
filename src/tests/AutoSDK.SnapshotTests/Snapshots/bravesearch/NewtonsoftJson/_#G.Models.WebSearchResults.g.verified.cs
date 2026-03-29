//HintName: G.Models.WebSearchResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container for web search results.
    /// </summary>
    public sealed partial class WebSearchResults
    {
        /// <summary>
        /// The type identifier (always "search").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of web search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.WebSearchResult>? Results { get; set; }

        /// <summary>
        /// Whether the results are family-friendly.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("family_friendly")]
        public bool? FamilyFriendly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResults" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier (always "search").
        /// </param>
        /// <param name="results">
        /// List of web search results.
        /// </param>
        /// <param name="familyFriendly">
        /// Whether the results are family-friendly.
        /// </param>
        public WebSearchResults(
            string? type,
            global::System.Collections.Generic.IList<global::G.WebSearchResult>? results,
            bool? familyFriendly)
        {
            this.Type = type;
            this.Results = results;
            this.FamilyFriendly = familyFriendly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResults" /> class.
        /// </summary>
        public WebSearchResults()
        {
        }
    }
}