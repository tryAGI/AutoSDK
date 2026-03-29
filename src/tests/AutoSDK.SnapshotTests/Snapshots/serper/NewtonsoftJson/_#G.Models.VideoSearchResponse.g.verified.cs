//HintName: G.Models.VideoSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from a video search query.
    /// </summary>
    public sealed partial class VideoSearchResponse
    {
        /// <summary>
        /// Echo of the search parameters used for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchParameters")]
        public global::G.SearchParameters? SearchParameters { get; set; }

        /// <summary>
        /// List of video results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("videos")]
        public global::System.Collections.Generic.IList<global::G.VideoResult>? Videos { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoSearchResponse" /> class.
        /// </summary>
        /// <param name="searchParameters">
        /// Echo of the search parameters used for the request.
        /// </param>
        /// <param name="videos">
        /// List of video results.
        /// </param>
        /// <param name="credits">
        /// Number of API credits consumed by this request.
        /// </param>
        public VideoSearchResponse(
            global::G.SearchParameters? searchParameters,
            global::System.Collections.Generic.IList<global::G.VideoResult>? videos,
            int? credits)
        {
            this.SearchParameters = searchParameters;
            this.Videos = videos;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchResponse" /> class.
        /// </summary>
        public VideoSearchResponse()
        {
        }
    }
}