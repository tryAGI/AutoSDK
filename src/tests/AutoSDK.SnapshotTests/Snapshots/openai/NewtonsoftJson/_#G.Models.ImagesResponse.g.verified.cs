//HintName: G.Models.ImagesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response from the image generation endpoint.
    /// </summary>
    public sealed partial class ImagesResponse
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the image was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset Created { get; set; } = default!;

        /// <summary>
        /// The list of generated images.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.Image2>? Data { get; set; }

        /// <summary>
        /// For `gpt-image-1` only, the token usage information for the image generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.ImagesResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// The Unix timestamp (in seconds) of when the image was created.
        /// </param>
        /// <param name="data">
        /// The list of generated images.
        /// </param>
        /// <param name="usage">
        /// For `gpt-image-1` only, the token usage information for the image generation.
        /// </param>
        public ImagesResponse(
            global::System.DateTimeOffset created,
            global::System.Collections.Generic.IList<global::G.Image2>? data,
            global::G.ImagesResponseUsage? usage)
        {
            this.Created = created;
            this.Data = data;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesResponse" /> class.
        /// </summary>
        public ImagesResponse()
        {
        }
    }
}