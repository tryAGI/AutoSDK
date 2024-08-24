//HintName: G.Models.PerformAlchemyUpscaleLCMRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformAlchemyUpscaleLCMRequest
    {
        /// <summary>
        /// Image data used to generate image. In base64 format. Prefix: `data:image/jpeg;base64,`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageDataUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageDataUrl { get; set; }

        /// <summary>
        /// The prompt used to generate images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// How strongly the generation should reflect the prompt. Must be a float between 0.5 and 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// Creativity strength of generation. Higher strength will deviate more from the original image supplied in imageDataUrl. Must be a float between 0.1 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestTimestamp")]
        public string? RequestTimestamp { get; set; }

        /// <summary>
        /// The style to generate LCM images with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.LcmGenerationStyleJsonConverter))]
        public global::G.LcmGenerationStyle? Style { get; set; }

        /// <summary>
        /// The number of steps to use for the generation. Must be between 4 and 16.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; } = 512;

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; } = 512;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Refine creative
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refineCreative")]
        public bool? RefineCreative { get; set; }

        /// <summary>
        /// Must be a float between 0.5 and 0.9.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refineStrength")]
        public double? RefineStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}