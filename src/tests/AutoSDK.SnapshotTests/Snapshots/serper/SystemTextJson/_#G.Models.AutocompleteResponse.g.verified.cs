//HintName: G.Models.AutocompleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from an autocomplete query.
    /// </summary>
    public sealed partial class AutocompleteResponse
    {
        /// <summary>
        /// Echo of the search parameters used for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchParameters")]
        public global::G.SearchParameters? SearchParameters { get; set; }

        /// <summary>
        /// List of autocomplete suggestions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestions")]
        public global::System.Collections.Generic.IList<global::G.AutocompleteSuggestion>? Suggestions { get; set; }

        /// <summary>
        /// Number of API credits consumed by this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public int? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteResponse" /> class.
        /// </summary>
        /// <param name="searchParameters">
        /// Echo of the search parameters used for the request.
        /// </param>
        /// <param name="suggestions">
        /// List of autocomplete suggestions.
        /// </param>
        /// <param name="credits">
        /// Number of API credits consumed by this request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutocompleteResponse(
            global::G.SearchParameters? searchParameters,
            global::System.Collections.Generic.IList<global::G.AutocompleteSuggestion>? suggestions,
            int? credits)
        {
            this.SearchParameters = searchParameters;
            this.Suggestions = suggestions;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteResponse" /> class.
        /// </summary>
        public AutocompleteResponse()
        {
        }
    }
}