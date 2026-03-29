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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenerationServerToolTypeJsonConverter))]
        public global::G.ImageGenerationServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenerationServerToolBackgroundJsonConverter))]
        public global::G.ImageGenerationServerToolBackground? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_fidelity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ImageGenerationServerToolInputFidelity?, object>))]
        public global::G.OneOf<global::G.ImageGenerationServerToolInputFidelity?, object>? InputFidelity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_mask")]
        public global::G.ImageGenerationServerToolInputImageMask? InputImageMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenerationServerToolModelJsonConverter))]
        public global::G.ImageGenerationServerToolModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenerationServerToolModerationJsonConverter))]
        public global::G.ImageGenerationServerToolModeration? Moderation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public double? OutputCompression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenerationServerToolOutputFormatJsonConverter))]
        public global::G.ImageGenerationServerToolOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_images")]
        public double? PartialImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenerationServerToolQualityJsonConverter))]
        public global::G.ImageGenerationServerToolQuality? Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenerationServerToolSizeJsonConverter))]
        public global::G.ImageGenerationServerToolSize? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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