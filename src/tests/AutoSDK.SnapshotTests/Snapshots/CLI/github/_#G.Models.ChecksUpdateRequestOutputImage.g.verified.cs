//HintName: G.Models.ChecksUpdateRequestOutputImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksUpdateRequestOutputImage
    {
        /// <summary>
        /// The alternative text for the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alt { get; set; }

        /// <summary>
        /// The full URL of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// A short image description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksUpdateRequestOutputImage" /> class.
        /// </summary>
        /// <param name="alt">
        /// The alternative text for the image.
        /// </param>
        /// <param name="imageUrl">
        /// The full URL of the image.
        /// </param>
        /// <param name="caption">
        /// A short image description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChecksUpdateRequestOutputImage(
            string alt,
            string imageUrl,
            string? caption)
        {
            this.Alt = alt ?? throw new global::System.ArgumentNullException(nameof(alt));
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Caption = caption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksUpdateRequestOutputImage" /> class.
        /// </summary>
        public ChecksUpdateRequestOutputImage()
        {
        }
    }
}