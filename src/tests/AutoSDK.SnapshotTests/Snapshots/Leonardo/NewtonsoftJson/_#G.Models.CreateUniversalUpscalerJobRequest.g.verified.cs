//HintName: G.Models.CreateUniversalUpscalerJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUniversalUpscalerJobRequest
    {
        /// <summary>
        /// The ID of the init image uploaded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initImageId")]
        public string? InitImageId { get; set; }

        /// <summary>
        /// The ID of the generated image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generatedImageId")]
        public string? GeneratedImageId { get; set; }

        /// <summary>
        /// The ID of the variation image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variationId")]
        public string? VariationId { get; set; }

        /// <summary>
        /// The style to upscale images using universal upscaler with.<br/>
        /// Default Value: GENERAL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upscalerStyle")]
        public global::G.UniversalUpscalerStyle? UpscalerStyle { get; set; } = global::G.UniversalUpscalerStyle.GENERAL;

        /// <summary>
        /// The creativity strength of the universal upscaler, must be integer between 1 and 10<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creativityStrength")]
        public int? CreativityStrength { get; set; } = 5;

        /// <summary>
        /// The upscale multiplier of the universal upscaler, must be number between 1.00 and 2.00<br/>
        /// Default Value: 1.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upscaleMultiplier")]
        public double? UpscaleMultiplier { get; set; } = 1.5;

        /// <summary>
        /// The prompt for the universal upscaler
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateUniversalUpscalerJobRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateUniversalUpscalerJobRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}