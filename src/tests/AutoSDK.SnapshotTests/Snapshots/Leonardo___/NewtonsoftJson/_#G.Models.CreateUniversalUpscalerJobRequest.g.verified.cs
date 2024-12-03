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
        public global::G.UniversalUpscalerStyle? UpscalerStyle { get; set; }

        /// <summary>
        /// The creativity strength of the universal upscaler, must be integer between 1 and 10<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creativityStrength")]
        public int? CreativityStrength { get; set; }

        /// <summary>
        /// The upscale multiplier of the universal upscaler, must be number between 1.00 and 2.00<br/>
        /// Default Value: 1.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upscaleMultiplier")]
        public double? UpscaleMultiplier { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniversalUpscalerJobRequest" /> class.
        /// </summary>
        /// <param name="initImageId">
        /// The ID of the init image uploaded
        /// </param>
        /// <param name="generatedImageId">
        /// The ID of the generated image
        /// </param>
        /// <param name="variationId">
        /// The ID of the variation image
        /// </param>
        /// <param name="upscalerStyle">
        /// The style to upscale images using universal upscaler with.<br/>
        /// Default Value: GENERAL
        /// </param>
        /// <param name="creativityStrength">
        /// The creativity strength of the universal upscaler, must be integer between 1 and 10<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="upscaleMultiplier">
        /// The upscale multiplier of the universal upscaler, must be number between 1.00 and 2.00<br/>
        /// Default Value: 1.5
        /// </param>
        /// <param name="prompt">
        /// The prompt for the universal upscaler
        /// </param>
        public CreateUniversalUpscalerJobRequest(
            string? initImageId,
            string? generatedImageId,
            string? variationId,
            global::G.UniversalUpscalerStyle? upscalerStyle,
            int? creativityStrength,
            double? upscaleMultiplier,
            string? prompt)
        {
            this.InitImageId = initImageId;
            this.GeneratedImageId = generatedImageId;
            this.VariationId = variationId;
            this.UpscalerStyle = upscalerStyle;
            this.CreativityStrength = creativityStrength;
            this.UpscaleMultiplier = upscaleMultiplier;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniversalUpscalerJobRequest" /> class.
        /// </summary>
        public CreateUniversalUpscalerJobRequest()
        {
        }
    }
}