//HintName: G.Models.ImageConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config for image generation features.
    /// </summary>
    public sealed partial class ImageConfig
    {
        /// <summary>
        /// Optional. The aspect ratio of the image to generate. Supported aspect ratios: `1:1`, `1:4`, `4:1`, `1:8`, `8:1`, `2:3`, `3:2`, `3:4`, `4:3`, `4:5`, `5:4`, `9:16`, `16:9`, or `21:9`. If not specified, the model will choose a default aspect ratio based on any reference images provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspectRatio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Optional. Specifies the size of generated images. Supported values are `512`, `1K`, `2K`, `4K`. If not specified, the model will use default value `1K`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageSize")]
        public string? ImageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageConfig" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// Optional. The aspect ratio of the image to generate. Supported aspect ratios: `1:1`, `1:4`, `4:1`, `1:8`, `8:1`, `2:3`, `3:2`, `3:4`, `4:3`, `4:5`, `5:4`, `9:16`, `16:9`, or `21:9`. If not specified, the model will choose a default aspect ratio based on any reference images provided.
        /// </param>
        /// <param name="imageSize">
        /// Optional. Specifies the size of generated images. Supported values are `512`, `1K`, `2K`, `4K`. If not specified, the model will use default value `1K`.
        /// </param>
        public ImageConfig(
            string? aspectRatio,
            string? imageSize)
        {
            this.AspectRatio = aspectRatio;
            this.ImageSize = imageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageConfig" /> class.
        /// </summary>
        public ImageConfig()
        {
        }
    }
}