//HintName: G.Models.Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chunk from image search.
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// The web page URI for attribution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceUri")]
        public string? SourceUri { get; set; }

        /// <summary>
        /// The image asset URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageUri")]
        public string? ImageUri { get; set; }

        /// <summary>
        /// The title of the web page that the image is from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The root domain of the web page that the image is from, e.g. "example.com".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="sourceUri">
        /// The web page URI for attribution.
        /// </param>
        /// <param name="imageUri">
        /// The image asset URL.
        /// </param>
        /// <param name="title">
        /// The title of the web page that the image is from.
        /// </param>
        /// <param name="domain">
        /// The root domain of the web page that the image is from, e.g. "example.com".
        /// </param>
        public Image(
            string? sourceUri,
            string? imageUri,
            string? title,
            string? domain)
        {
            this.SourceUri = sourceUri;
            this.ImageUri = imageUri;
            this.Title = title;
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}