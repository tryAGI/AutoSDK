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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The media type of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageBlockSourceMediaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageBlockSourceMediaType MediaType { get; set; }

        /// <summary>
        /// The type of image source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageBlockSourceTypeJsonConverter))]
        public global::G.ImageBlockSourceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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