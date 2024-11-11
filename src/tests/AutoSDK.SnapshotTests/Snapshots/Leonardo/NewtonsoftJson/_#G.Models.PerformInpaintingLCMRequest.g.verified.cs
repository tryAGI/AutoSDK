//HintName: G.Models.PerformInpaintingLCMRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformInpaintingLCMRequest
    {
        /// <summary>
        /// Image data used to generate image. In base64 format. Prefix: `data:image/jpeg;base64,`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageDataUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageDataUrl { get; set; } = default!;

        /// <summary>
        /// Image data of the mask layer used for inpainting. In base64 format. Prefix: `data:image/jpeg;base64,`. Mask should be white on black where generation is applied to the white area.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskDataUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string MaskDataUrl { get; set; } = default!;

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
        public int? Width { get; set; }

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformInpaintingLCMRequest" /> class.
        /// </summary>
        /// <param name="imageDataUrl">
        /// Image data used to generate image. In base64 format. Prefix: `data:image/jpeg;base64,`
        /// </param>
        /// <param name="maskDataUrl">
        /// Image data of the mask layer used for inpainting. In base64 format. Prefix: `data:image/jpeg;base64,`. Mask should be white on black where generation is applied to the white area.
        /// </param>
        /// <param name="prompt">
        /// The prompt used to generate images
        /// </param>
        /// <param name="guidance">
        /// How strongly the generation should reflect the prompt. Must be a float between 0.5 and 20.
        /// </param>
        /// <param name="strength">
        /// Creativity strength of generation. Higher strength will deviate more from the original image supplied in imageDataUrl. Must be a float between 0.1 and 1.
        /// </param>
        /// <param name="requestTimestamp"></param>
        /// <param name="style">
        /// The style to generate LCM images with.
        /// </param>
        /// <param name="steps">
        /// The number of steps to use for the generation. Must be between 4 and 16.
        /// </param>
        /// <param name="width">
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="height">
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="seed"></param>
        public PerformInpaintingLCMRequest(
            string imageDataUrl,
            string maskDataUrl,
            string prompt,
            double? guidance,
            double? strength,
            string? requestTimestamp,
            global::G.LcmGenerationStyle? style,
            int? steps,
            int? width,
            int? height,
            int? seed)
        {
            this.ImageDataUrl = imageDataUrl ?? throw new global::System.ArgumentNullException(nameof(imageDataUrl));
            this.MaskDataUrl = maskDataUrl ?? throw new global::System.ArgumentNullException(nameof(maskDataUrl));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Guidance = guidance;
            this.Strength = strength;
            this.RequestTimestamp = requestTimestamp;
            this.Style = style;
            this.Steps = steps;
            this.Width = width;
            this.Height = height;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformInpaintingLCMRequest" /> class.
        /// </summary>
        public PerformInpaintingLCMRequest()
        {
        }
    }
}