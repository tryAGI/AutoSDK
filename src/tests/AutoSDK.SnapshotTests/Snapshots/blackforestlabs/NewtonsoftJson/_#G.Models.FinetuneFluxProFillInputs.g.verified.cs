//HintName: G.Models.FinetuneFluxProFillInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneFluxProFillInputs
    {
        /// <summary>
        /// ID of the fine-tuned model you want to use.<br/>
        /// Example: my-finetune
        /// </summary>
        /// <example>my-finetune</example>
        [global::Newtonsoft.Json.JsonProperty("finetune_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FinetuneId { get; set; } = default!;

        /// <summary>
        /// Strength of the fine-tuned model. 0.0 means no influence, 1.0 means full influence. Allowed values up to 2.0<br/>
        /// Default Value: 1.1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_strength")]
        public double? FinetuneStrength { get; set; }

        /// <summary>
        /// A Base64-encoded string representing the image you wish to modify. Can contain alpha mask if desired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public string Image { get; set; } = default!;

        /// <summary>
        /// A Base64-encoded string representing a mask for the areas you want to modify in the image. The mask should be the same dimensions as the image and in black and white. Black areas (0%) indicate no modification, while white areas (100%) specify areas for inpainting. Optional if you provide an alpha mask in the original image. Validation: The endpoint verifies that the dimensions of the mask match the original image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask")]
        public string? Mask { get; set; }

        /// <summary>
        /// The description of the changes you want to make. This text guides the inpainting process, allowing you to specify features, styles, or modifications for the masked area.<br/>
        /// Example: ein fantastisches bild
        /// </summary>
        /// <example>ein fantastisches bild</example>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Number of steps for the image generation process<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_upsampling")]
        public bool? PromptUpsampling { get; set; }

        /// <summary>
        /// Optional seed for reproducibility
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Guidance strength for the image generation process<br/>
        /// Default Value: 60
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: jpeg
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public global::G.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// URL to receive webhook notifications
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Optional secret for webhook signature verification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneFluxProFillInputs" /> class.
        /// </summary>
        /// <param name="finetuneId">
        /// ID of the fine-tuned model you want to use.<br/>
        /// Example: my-finetune
        /// </param>
        /// <param name="image">
        /// A Base64-encoded string representing the image you wish to modify. Can contain alpha mask if desired.
        /// </param>
        /// <param name="finetuneStrength">
        /// Strength of the fine-tuned model. 0.0 means no influence, 1.0 means full influence. Allowed values up to 2.0<br/>
        /// Default Value: 1.1F
        /// </param>
        /// <param name="mask">
        /// A Base64-encoded string representing a mask for the areas you want to modify in the image. The mask should be the same dimensions as the image and in black and white. Black areas (0%) indicate no modification, while white areas (100%) specify areas for inpainting. Optional if you provide an alpha mask in the original image. Validation: The endpoint verifies that the dimensions of the mask match the original image.
        /// </param>
        /// <param name="prompt">
        /// The description of the changes you want to make. This text guides the inpainting process, allowing you to specify features, styles, or modifications for the masked area.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="steps">
        /// Number of steps for the image generation process<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility
        /// </param>
        /// <param name="guidance">
        /// Guidance strength for the image generation process<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        public FinetuneFluxProFillInputs(
            string finetuneId,
            string image,
            double? finetuneStrength,
            string? mask,
            string? prompt,
            int? steps,
            bool? promptUpsampling,
            int? seed,
            double? guidance,
            global::G.OutputFormat? outputFormat,
            int? safetyTolerance,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.FinetuneId = finetuneId ?? throw new global::System.ArgumentNullException(nameof(finetuneId));
            this.FinetuneStrength = finetuneStrength;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Mask = mask;
            this.Prompt = prompt;
            this.Steps = steps;
            this.PromptUpsampling = promptUpsampling;
            this.Seed = seed;
            this.Guidance = guidance;
            this.OutputFormat = outputFormat;
            this.SafetyTolerance = safetyTolerance;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneFluxProFillInputs" /> class.
        /// </summary>
        public FinetuneFluxProFillInputs()
        {
        }
    }
}