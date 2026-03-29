//HintName: G.Models.FinetuneFluxUltraInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneFluxUltraInput
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
        /// Default Value: 1.2F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_strength")]
        public double? FinetuneStrength { get; set; }

        /// <summary>
        /// The prompt to use for image generation.<br/>
        /// Example: A beautiful landscape with mountains and a lake
        /// </summary>
        /// <example>A beautiful landscape with mountains and a lake</example>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Optional seed for reproducibility. If not provided, a random seed will be used.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Aspect ratio of the image between 21:9 and 9:21<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: jpeg
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public global::G.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Optional image to remix in base64 format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_prompt")]
        public string? ImagePrompt { get; set; }

        /// <summary>
        /// Blend between the prompt and the image prompt<br/>
        /// Default Value: 0.1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_prompt_strength")]
        public double? ImagePromptStrength { get; set; }

        /// <summary>
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_upsampling")]
        public bool? PromptUpsampling { get; set; }

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
        /// Initializes a new instance of the <see cref="FinetuneFluxUltraInput" /> class.
        /// </summary>
        /// <param name="finetuneId">
        /// ID of the fine-tuned model you want to use.<br/>
        /// Example: my-finetune
        /// </param>
        /// <param name="finetuneStrength">
        /// Strength of the fine-tuned model. 0.0 means no influence, 1.0 means full influence. Allowed values up to 2.0<br/>
        /// Default Value: 1.2F
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for image generation.<br/>
        /// Example: A beautiful landscape with mountains and a lake
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility. If not provided, a random seed will be used.<br/>
        /// Example: 42
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the image between 21:9 and 9:21<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="imagePrompt">
        /// Optional image to remix in base64 format
        /// </param>
        /// <param name="imagePromptStrength">
        /// Blend between the prompt and the image prompt<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        public FinetuneFluxUltraInput(
            string finetuneId,
            double? finetuneStrength,
            string? prompt,
            int? seed,
            string? aspectRatio,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
            string? imagePrompt,
            double? imagePromptStrength,
            bool? promptUpsampling,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.FinetuneId = finetuneId ?? throw new global::System.ArgumentNullException(nameof(finetuneId));
            this.FinetuneStrength = finetuneStrength;
            this.Prompt = prompt;
            this.Seed = seed;
            this.AspectRatio = aspectRatio;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.ImagePrompt = imagePrompt;
            this.ImagePromptStrength = imagePromptStrength;
            this.PromptUpsampling = promptUpsampling;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneFluxUltraInput" /> class.
        /// </summary>
        public FinetuneFluxUltraInput()
        {
        }
    }
}