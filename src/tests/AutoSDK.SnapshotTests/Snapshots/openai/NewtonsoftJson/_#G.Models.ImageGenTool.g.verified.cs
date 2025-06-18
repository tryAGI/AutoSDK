//HintName: G.Models.ImageGenTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that generates images using a model like `gpt-image-1`.
    /// </summary>
    public sealed partial class ImageGenTool
    {
        /// <summary>
        /// The type of the image generation tool. Always `image_generation`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ImageGenToolType Type { get; set; }

        /// <summary>
        /// The image generation model to use. Default: `gpt-image-1`.<br/>
        /// Default Value: gpt-image-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.ImageGenToolModel? Model { get; set; }

        /// <summary>
        /// The quality of the generated image. One of `low`, `medium`, `high`, <br/>
        /// or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality")]
        public global::G.ImageGenToolQuality? Quality { get; set; }

        /// <summary>
        /// The size of the generated image. One of `1024x1024`, `1024x1536`, <br/>
        /// `1536x1024`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public global::G.ImageGenToolSize? Size { get; set; }

        /// <summary>
        /// The output format of the generated image. One of `png`, `webp`, or <br/>
        /// `jpeg`. Default: `png`.<br/>
        /// Default Value: png
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public global::G.ImageGenToolOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Compression level for the output image. Default: 100.<br/>
        /// Default Value: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// Moderation level for the generated image. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderation")]
        public global::G.ImageGenToolModeration? Moderation { get; set; }

        /// <summary>
        /// Background type for the generated image. One of `transparent`, <br/>
        /// `opaque`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.ImageGenToolBackground? Background { get; set; }

        /// <summary>
        /// Optional mask for inpainting. Contains `image_url` <br/>
        /// (string, optional) and `file_id` (string, optional).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_image_mask")]
        public global::G.ImageGenToolInputImageMask? InputImageMask { get; set; }

        /// <summary>
        /// Number of partial images to generate in streaming mode, from 0 (default value) to 3.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partial_images")]
        public int? PartialImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the image generation tool. Always `image_generation`.
        /// </param>
        /// <param name="model">
        /// The image generation model to use. Default: `gpt-image-1`.<br/>
        /// Default Value: gpt-image-1
        /// </param>
        /// <param name="quality">
        /// The quality of the generated image. One of `low`, `medium`, `high`, <br/>
        /// or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="size">
        /// The size of the generated image. One of `1024x1024`, `1024x1536`, <br/>
        /// `1536x1024`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="outputFormat">
        /// The output format of the generated image. One of `png`, `webp`, or <br/>
        /// `jpeg`. Default: `png`.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="outputCompression">
        /// Compression level for the output image. Default: 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="moderation">
        /// Moderation level for the generated image. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="background">
        /// Background type for the generated image. One of `transparent`, <br/>
        /// `opaque`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="inputImageMask">
        /// Optional mask for inpainting. Contains `image_url` <br/>
        /// (string, optional) and `file_id` (string, optional).
        /// </param>
        /// <param name="partialImages">
        /// Number of partial images to generate in streaming mode, from 0 (default value) to 3.<br/>
        /// Default Value: 0
        /// </param>
        public ImageGenTool(
            global::G.ImageGenToolType type,
            global::G.ImageGenToolModel? model,
            global::G.ImageGenToolQuality? quality,
            global::G.ImageGenToolSize? size,
            global::G.ImageGenToolOutputFormat? outputFormat,
            int? outputCompression,
            global::G.ImageGenToolModeration? moderation,
            global::G.ImageGenToolBackground? background,
            global::G.ImageGenToolInputImageMask? inputImageMask,
            int? partialImages)
        {
            this.Type = type;
            this.Model = model;
            this.Quality = quality;
            this.Size = size;
            this.OutputFormat = outputFormat;
            this.OutputCompression = outputCompression;
            this.Moderation = moderation;
            this.Background = background;
            this.InputImageMask = inputImageMask;
            this.PartialImages = partialImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenTool" /> class.
        /// </summary>
        public ImageGenTool()
        {
        }
    }
}