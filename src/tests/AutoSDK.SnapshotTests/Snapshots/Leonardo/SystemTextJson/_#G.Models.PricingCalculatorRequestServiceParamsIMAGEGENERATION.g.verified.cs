//HintName: G.Models.PricingCalculatorRequestServiceParamsIMAGEGENERATION.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for IMAGE_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsIMAGEGENERATION
    {
        /// <summary>
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageHeight")]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageWidth")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 8. If either width or height is over 768, must be between 1 and 4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numImages")]
        public int? NumImages { get; set; }

        /// <summary>
        /// The Step Count to use for the generation. Must be between 10 and 60.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferenceSteps")]
        public int? InferenceSteps { get; set; }

        /// <summary>
        /// Enable to use Prompt Magic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagic")]
        public bool? PromptMagic { get; set; }

        /// <summary>
        /// Strength of prompt magic. Must be a float between 0.1 and 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagicStrength")]
        public double? PromptMagicStrength { get; set; }

        /// <summary>
        /// Prompt magic version v2 or v3, for use when promptMagic: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagicVersion")]
        public string? PromptMagicVersion { get; set; }

        /// <summary>
        /// Enable to use Alchemy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alchemyMode")]
        public bool? AlchemyMode { get; set; }

        /// <summary>
        /// Enable to use high resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highResolution")]
        public bool? HighResolution { get; set; }

        /// <summary>
        /// The number of elements used for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loraCount")]
        public int? LoraCount { get; set; }

        /// <summary>
        /// Enable to use custom model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isModelCustom")]
        public bool? IsModelCustom { get; set; }

        /// <summary>
        /// The total cost of controlnets input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlnetsCost")]
        public int? ControlnetsCost { get; set; }

        /// <summary>
        /// Enable to use SDXL model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSDXL")]
        public bool? IsSDXL { get; set; }

        /// <summary>
        /// Enable to use SDXL Lightning model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSDXLLightning")]
        public bool? IsSDXLLightning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION),
                jsonSerializerContext) as global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION>(
                json,
                jsonSerializerOptions);
        }

    }
}