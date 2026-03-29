//HintName: G.Models.ImageSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from the image search endpoint.
    /// </summary>
    public sealed partial class ImageSearchResponse
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Information about the original search query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public global::G.Query? Query { get; set; }

        /// <summary>
        /// List of image results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.ImageResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="query">
        /// Information about the original search query.
        /// </param>
        /// <param name="results">
        /// List of image results.
        /// </param>
        public ImageSearchResponse(
            string? type,
            global::G.Query? query,
            global::System.Collections.Generic.IList<global::G.ImageResult>? results)
        {
            this.Type = type;
            this.Query = query;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResponse" /> class.
        /// </summary>
        public ImageSearchResponse()
        {
        }
    }
}