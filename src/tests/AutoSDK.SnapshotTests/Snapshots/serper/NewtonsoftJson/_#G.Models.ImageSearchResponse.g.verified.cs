//HintName: G.Models.ImageSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from an image search query.
    /// </summary>
    public sealed partial class ImageSearchResponse
    {
        /// <summary>
        /// Echo of the search parameters used for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchParameters")]
        public global::G.SearchParameters? SearchParameters { get; set; }

        /// <summary>
        /// List of image results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public global::System.Collections.Generic.IList<global::G.ImageResult>? Images { get; set; }

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
        /// Initializes a new instance of the <see cref="ImageSearchResponse" /> class.
        /// </summary>
        /// <param name="searchParameters">
        /// Echo of the search parameters used for the request.
        /// </param>
        /// <param name="images">
        /// List of image results.
        /// </param>
        /// <param name="credits">
        /// Number of API credits consumed by this request.
        /// </param>
        public ImageSearchResponse(
            global::G.SearchParameters? searchParameters,
            global::System.Collections.Generic.IList<global::G.ImageResult>? images,
            int? credits)
        {
            this.SearchParameters = searchParameters;
            this.Images = images;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResponse" /> class.
        /// </summary>
        public ImageSearchResponse()
        {
        }
    }
}