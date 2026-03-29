//HintName: G.Models.ImageFragment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an image content fragment within a chat message. Note: This content type is only supported with the Palmyra X5 model.
    /// </summary>
    public sealed partial class ImageFragment
    {
        /// <summary>
        /// The type of content fragment. Must be `image_url` for image fragments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageFragmentTypeJsonConverter))]
        public global::G.ImageFragmentType Type { get; set; }

        /// <summary>
        /// The image URL object containing the location of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageFragmentImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFragment" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The image URL object containing the location of the image.
        /// </param>
        /// <param name="type">
        /// The type of content fragment. Must be `image_url` for image fragments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageFragment(
            global::G.ImageFragmentImageUrl imageUrl,
            global::G.ImageFragmentType type)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFragment" /> class.
        /// </summary>
        public ImageFragment()
        {
        }
    }
}