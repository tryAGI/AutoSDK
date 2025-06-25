//HintName: G.Models.EmbedImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image content of the input. Supported with Embed v3.0 and newer models.
    /// </summary>
    public sealed partial class EmbedImage
    {
        /// <summary>
        /// Base64 url of image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::G.EmbedImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbedContentTypeJsonConverter))]
        public global::G.EmbedContentType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Base64 url of image.
        /// </param>
        /// <param name="type">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedImage(
            global::G.EmbedImageUrl? imageUrl,
            global::G.EmbedContentType? type)
        {
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedImage" /> class.
        /// </summary>
        public EmbedImage()
        {
        }
    }
}