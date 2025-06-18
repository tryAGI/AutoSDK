//HintName: G.Models.ImageGenToolInputImageMask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional mask for inpainting. Contains `image_url` <br/>
    /// (string, optional) and `file_id` (string, optional).
    /// </summary>
    public sealed partial class ImageGenToolInputImageMask
    {
        /// <summary>
        /// Base64-encoded mask image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// File ID for the mask image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolInputImageMask" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Base64-encoded mask image.
        /// </param>
        /// <param name="fileId">
        /// File ID for the mask image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenToolInputImageMask(
            string? imageUrl,
            string? fileId)
        {
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolInputImageMask" /> class.
        /// </summary>
        public ImageGenToolInputImageMask()
        {
        }
    }
}