//HintName: G.Models.ImageGenerationServerToolInputImageMask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationServerToolInputImageMask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerToolInputImageMask" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="fileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationServerToolInputImageMask(
            string? imageUrl,
            string? fileId)
        {
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerToolInputImageMask" /> class.
        /// </summary>
        public ImageGenerationServerToolInputImageMask()
        {
        }
    }
}