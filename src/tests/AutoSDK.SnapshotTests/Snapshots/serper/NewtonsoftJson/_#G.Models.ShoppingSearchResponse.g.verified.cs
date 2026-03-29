//HintName: G.Models.ShoppingSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from a shopping search query.
    /// </summary>
    public sealed partial class ShoppingSearchResponse
    {
        /// <summary>
        /// Echo of the search parameters used for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchParameters")]
        public global::G.SearchParameters? SearchParameters { get; set; }

        /// <summary>
        /// List of shopping results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shopping")]
        public global::System.Collections.Generic.IList<global::G.ShoppingResult>? Shopping { get; set; }

        /// <summary>
        /// Number of API credits consumed by this request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits")]
        public int? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingSearchResponse" /> class.
        /// </summary>
        /// <param name="searchParameters">
        /// Echo of the search parameters used for the request.
        /// </param>
        /// <param name="shopping">
        /// List of shopping results.
        /// </param>
        /// <param name="credits">
        /// Number of API credits consumed by this request.
        /// </param>
        public ShoppingSearchResponse(
            global::G.SearchParameters? searchParameters,
            global::System.Collections.Generic.IList<global::G.ShoppingResult>? shopping,
            int? credits)
        {
            this.SearchParameters = searchParameters;
            this.Shopping = shopping;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingSearchResponse" /> class.
        /// </summary>
        public ShoppingSearchResponse()
        {
        }
    }
}