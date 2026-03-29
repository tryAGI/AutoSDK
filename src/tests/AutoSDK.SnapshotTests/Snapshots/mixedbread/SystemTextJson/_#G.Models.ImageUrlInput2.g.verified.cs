//HintName: G.Models.ImageUrlInput2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for image input validation.
    /// </summary>
    public sealed partial class ImageUrlInput2
    {
        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: image_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The image input specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageUrlInput ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlInput2" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The image input specification.
        /// </param>
        /// <param name="type">
        /// Input type identifier<br/>
        /// Default Value: image_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageUrlInput2(
            global::G.ImageUrlInput imageUrl,
            string? type)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlInput2" /> class.
        /// </summary>
        public ImageUrlInput2()
        {
        }
    }
}