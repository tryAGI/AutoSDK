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
        [global::Newtonsoft.Json.JsonProperty("imageDataUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageDataUrl { get; set; } = default!;

        /// <summary>
        /// The prompt used to generate images
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// How strongly the generation should reflect the prompt. Must be a float between 0.5 and 20.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// Creativity strength of generation. Higher strength will deviate more from the original image supplied in imageDataUrl. Must be a float between 0.1 and 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestTimestamp")]
        public string? RequestTimestamp { get; set; }

        /// <summary>
        /// The style to generate LCM images with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public global::G.LcmGenerationStyle? Style { get; set; }

        /// <summary>
        /// The number of steps to use for the generation. Must be between 4 and 16.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; } = 512;

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; } = 512;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Refine creative
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refineCreative")]
        public bool? RefineCreative { get; set; }

        /// <summary>
        /// Must be a float between 0.5 and 0.9.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refineStrength")]
        public double? RefineStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PerformAlchemyUpscaleLCMRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PerformAlchemyUpscaleLCMRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}