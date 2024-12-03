//HintName: G.Models.ImageBlockSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source of an image block.
    /// </summary>
    public sealed partial class ImageBlockSource
    {
        /// <summary>
        /// The base64-encoded image data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// The media type of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageBlockSourceMediaType MediaType { get; set; } = default!;

        /// <summary>
        /// The type of image source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ImageBlockSourceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBlockSource" /> class.
        /// </summary>
        /// <param name="data">
        /// The base64-encoded image data.
        /// </param>
        /// <param name="mediaType">
        /// The media type of the image.
        /// </param>
        /// <param name="type">
        /// The type of image source.
        /// </param>
        public ImageBlockSource(
            string data,
            global::G.ImageBlockSourceMediaType mediaType,
            global::G.ImageBlockSourceType type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MediaType = mediaType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBlockSource" /> class.
        /// </summary>
        public ImageBlockSource()
        {
        }
    }
}