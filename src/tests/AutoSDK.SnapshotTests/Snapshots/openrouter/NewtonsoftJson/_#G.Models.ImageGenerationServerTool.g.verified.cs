//HintName: G.Models.ImageGenerationServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image generation tool configuration
    /// </summary>
    public sealed partial class ImageGenerationServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ImageGenerationServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.ImageGenerationServerToolBackground? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_fidelity")]
        public global::G.OneOf<global::G.ImageGenerationServerToolInputFidelity?, object>? InputFidelity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_image_mask")]
        public global::G.ImageGenerationServerToolInputImageMask? InputImageMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.ImageGenerationServerToolModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderation")]
        public global::G.ImageGenerationServerToolModeration? Moderation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_compression")]
        public double? OutputCompression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public global::G.ImageGenerationServerToolOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partial_images")]
        public double? PartialImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality")]
        public global::G.ImageGenerationServerToolQuality? Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public global::G.ImageGenerationServerToolSize? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="background"></param>
        /// <param name="inputFidelity"></param>
        /// <param name="inputImageMask"></param>
        /// <param name="model"></param>
        /// <param name="moderation"></param>
        /// <param name="outputCompression"></param>
        /// <param name="outputFormat"></param>
        /// <param name="partialImages"></param>
        /// <param name="quality"></param>
        /// <param name="size"></param>
        public ImageGenerationServerTool(
            global::G.ImageGenerationServerToolType type,
            global::G.ImageGenerationServerToolBackground? background,
            global::G.OneOf<global::G.ImageGenerationServerToolInputFidelity?, object>? inputFidelity,
            global::G.ImageGenerationServerToolInputImageMask? inputImageMask,
            global::G.ImageGenerationServerToolModel? model,
            global::G.ImageGenerationServerToolModeration? moderation,
            double? outputCompression,
            global::G.ImageGenerationServerToolOutputFormat? outputFormat,
            double? partialImages,
            global::G.ImageGenerationServerToolQuality? quality,
            global::G.ImageGenerationServerToolSize? size)
        {
            this.Type = type;
            this.Background = background;
            this.InputFidelity = inputFidelity;
            this.InputImageMask = inputImageMask;
            this.Model = model;
            this.Moderation = moderation;
            this.OutputCompression = outputCompression;
            this.OutputFormat = outputFormat;
            this.PartialImages = partialImages;
            this.Quality = quality;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerTool" /> class.
        /// </summary>
        public ImageGenerationServerTool()
        {
        }
    }
}