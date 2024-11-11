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

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsIMAGEGENERATION" /> class.
        /// </summary>
        /// <param name="imageHeight">
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </param>
        /// <param name="imageWidth">
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate. Must be between 1 and 8. If either width or height is over 768, must be between 1 and 4.
        /// </param>
        /// <param name="inferenceSteps">
        /// The Step Count to use for the generation. Must be between 10 and 60.
        /// </param>
        /// <param name="promptMagic">
        /// Enable to use Prompt Magic.
        /// </param>
        /// <param name="promptMagicStrength">
        /// Strength of prompt magic. Must be a float between 0.1 and 1.0
        /// </param>
        /// <param name="promptMagicVersion">
        /// Prompt magic version v2 or v3, for use when promptMagic: true
        /// </param>
        /// <param name="alchemyMode">
        /// Enable to use Alchemy.
        /// </param>
        /// <param name="highResolution">
        /// Enable to use high resolution.
        /// </param>
        /// <param name="loraCount">
        /// The number of elements used for the generation.
        /// </param>
        /// <param name="isModelCustom">
        /// Enable to use custom model.
        /// </param>
        /// <param name="controlnetsCost">
        /// The total cost of controlnets input.
        /// </param>
        /// <param name="isSDXL">
        /// Enable to use SDXL model.
        /// </param>
        /// <param name="isSDXLLightning">
        /// Enable to use SDXL Lightning model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PricingCalculatorRequestServiceParamsIMAGEGENERATION(
            int? imageHeight,
            int? imageWidth,
            int? numImages,
            int? inferenceSteps,
            bool? promptMagic,
            double? promptMagicStrength,
            string? promptMagicVersion,
            bool? alchemyMode,
            bool? highResolution,
            int? loraCount,
            bool? isModelCustom,
            int? controlnetsCost,
            bool? isSDXL,
            bool? isSDXLLightning)
        {
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
            this.NumImages = numImages;
            this.InferenceSteps = inferenceSteps;
            this.PromptMagic = promptMagic;
            this.PromptMagicStrength = promptMagicStrength;
            this.PromptMagicVersion = promptMagicVersion;
            this.AlchemyMode = alchemyMode;
            this.HighResolution = highResolution;
            this.LoraCount = loraCount;
            this.IsModelCustom = isModelCustom;
            this.ControlnetsCost = controlnetsCost;
            this.IsSDXL = isSDXL;
            this.IsSDXLLightning = isSDXLLightning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsIMAGEGENERATION" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsIMAGEGENERATION()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION),
                jsonSerializerContext) as global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}