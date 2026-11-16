//HintName: G.Models.ImageUrlInput2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for image URL validation.
    /// </summary>
    public sealed partial class ImageUrlInput2
    {
        /// <summary>
        /// The image URL. Can be either a URL or a Data URI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The image format/mimetype
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlInput2" /> class.
        /// </summary>
        /// <param name="url">
        /// The image URL. Can be either a URL or a Data URI.
        /// </param>
        /// <param name="format">
        /// The image format/mimetype
        /// </param>
        public ImageUrlInput2(
            string url,
            string? format)
        {
            this.Url = url;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlInput2" /> class.
        /// </summary>
        public ImageUrlInput2()
        {
        }

    }
}