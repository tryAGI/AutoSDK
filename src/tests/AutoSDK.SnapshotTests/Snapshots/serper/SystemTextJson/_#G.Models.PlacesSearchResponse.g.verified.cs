//HintName: G.Models.PlacesSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from a places search query.
    /// </summary>
    public sealed partial class PlacesSearchResponse
    {
        /// <summary>
        /// Echo of the search parameters used for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchParameters")]
        public global::G.SearchParameters? SearchParameters { get; set; }

        /// <summary>
        /// List of place results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("places")]
        public global::System.Collections.Generic.IList<global::G.PlaceResult>? Places { get; set; }

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
        /// Initializes a new instance of the <see cref="PlacesSearchResponse" /> class.
        /// </summary>
        /// <param name="searchParameters">
        /// Echo of the search parameters used for the request.
        /// </param>
        /// <param name="places">
        /// List of place results.
        /// </param>
        /// <param name="credits">
        /// Number of API credits consumed by this request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlacesSearchResponse(
            global::G.SearchParameters? searchParameters,
            global::System.Collections.Generic.IList<global::G.PlaceResult>? places,
            int? credits)
        {
            this.SearchParameters = searchParameters;
            this.Places = places;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlacesSearchResponse" /> class.
        /// </summary>
        public PlacesSearchResponse()
        {
        }
    }
}