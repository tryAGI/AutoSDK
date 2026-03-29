//HintName: G.Models.NewsSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from a news search query.
    /// </summary>
    public sealed partial class NewsSearchResponse
    {
        /// <summary>
        /// Echo of the search parameters used for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchParameters")]
        public global::G.SearchParameters? SearchParameters { get; set; }

        /// <summary>
        /// List of news results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("news")]
        public global::System.Collections.Generic.IList<global::G.NewsResult>? News { get; set; }

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
        /// Initializes a new instance of the <see cref="NewsSearchResponse" /> class.
        /// </summary>
        /// <param name="searchParameters">
        /// Echo of the search parameters used for the request.
        /// </param>
        /// <param name="news">
        /// List of news results.
        /// </param>
        /// <param name="credits">
        /// Number of API credits consumed by this request.
        /// </param>
        public NewsSearchResponse(
            global::G.SearchParameters? searchParameters,
            global::System.Collections.Generic.IList<global::G.NewsResult>? news,
            int? credits)
        {
            this.SearchParameters = searchParameters;
            this.News = news;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsSearchResponse" /> class.
        /// </summary>
        public NewsSearchResponse()
        {
        }
    }
}