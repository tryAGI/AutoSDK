//HintName: G.Models.ScholarSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from a Google Scholar search query.
    /// </summary>
    public sealed partial class ScholarSearchResponse
    {
        /// <summary>
        /// Echo of the search parameters used for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchParameters")]
        public global::G.SearchParameters? SearchParameters { get; set; }

        /// <summary>
        /// List of scholar/academic results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organic")]
        public global::System.Collections.Generic.IList<global::G.ScholarResult>? Organic { get; set; }

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
        /// Initializes a new instance of the <see cref="ScholarSearchResponse" /> class.
        /// </summary>
        /// <param name="searchParameters">
        /// Echo of the search parameters used for the request.
        /// </param>
        /// <param name="organic">
        /// List of scholar/academic results.
        /// </param>
        /// <param name="credits">
        /// Number of API credits consumed by this request.
        /// </param>
        public ScholarSearchResponse(
            global::G.SearchParameters? searchParameters,
            global::System.Collections.Generic.IList<global::G.ScholarResult>? organic,
            int? credits)
        {
            this.SearchParameters = searchParameters;
            this.Organic = organic;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScholarSearchResponse" /> class.
        /// </summary>
        public ScholarSearchResponse()
        {
        }
    }
}