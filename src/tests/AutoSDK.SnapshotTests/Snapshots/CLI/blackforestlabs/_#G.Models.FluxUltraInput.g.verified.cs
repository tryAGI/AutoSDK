//HintName: G.Models.FluxUltraInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FluxUltraInput
    {
        /// <summary>
        /// The prompt to use for image generation.<br/>
        /// Example: A beautiful landscape with mountains and a lake
        /// </summary>
        /// <example>A beautiful landscape with mountains and a lake</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_upsampling")]
        public bool? PromptUpsampling { get; set; }

        /// <summary>
        /// Optional seed for reproducibility. If not provided, a random seed will be used.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Aspect ratio of the image between 21:9 and 9:21<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::G.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Generate less processed, more natural-looking images<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public bool? Raw { get; set; }

        /// <summary>
        /// Optional image to remix in base64 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_prompt")]
        public string? ImagePrompt { get; set; }

        /// <summary>
        /// Blend between the prompt and the image prompt<br/>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_prompt_strength")]
        public double? ImagePromptStrength { get; set; }

        /// <summary>
        /// URL to receive webhook notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Optional secret for webhook signature verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxUltraInput" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use for image generation.<br/>
        /// Example: A beautiful landscape with mountains and a lake
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
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
        /// <param name="raw">
        /// Generate less processed, more natural-looking images<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="imagePrompt">
        /// Optional image to remix in base64 format
        /// </param>
        /// <param name="imagePromptStrength">
        /// Blend between the prompt and the image prompt<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FluxUltraInput(
            string? prompt,
            bool? promptUpsampling,
            int? seed,
            string? aspectRatio,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
            bool? raw,
            string? imagePrompt,
            double? imagePromptStrength,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.Prompt = prompt;
            this.PromptUpsampling = promptUpsampling;
            this.Seed = seed;
            this.AspectRatio = aspectRatio;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.Raw = raw;
            this.ImagePrompt = imagePrompt;
            this.ImagePromptStrength = imagePromptStrength;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxUltraInput" /> class.
        /// </summary>
        public FluxUltraInput()
        {
        }
    }
}