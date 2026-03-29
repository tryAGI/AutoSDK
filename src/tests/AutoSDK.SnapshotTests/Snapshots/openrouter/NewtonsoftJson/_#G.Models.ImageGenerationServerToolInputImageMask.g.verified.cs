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
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerToolInputImageMask" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="fileId"></param>
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