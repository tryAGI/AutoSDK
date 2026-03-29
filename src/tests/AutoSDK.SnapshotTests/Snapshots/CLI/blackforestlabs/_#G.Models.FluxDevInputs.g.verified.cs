//HintName: G.Models.FluxDevInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FluxDevInputs
    {
        /// <summary>
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </summary>
        /// <example>ein fantastisches bild</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Optional base64 encoded image to use as a prompt for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_prompt")]
        public string? ImagePrompt { get; set; }

        /// <summary>
        /// Width of the generated image in pixels. Must be a multiple of 32.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the generated image in pixels. Must be a multiple of 32.<br/>
        /// Default Value: 768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Number of steps for the image generation process.<br/>
        /// Default Value: 28<br/>
        /// Example: 28
        /// </summary>
        /// <example>28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_upsampling")]
        public bool? PromptUpsampling { get; set; }

        /// <summary>
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.<br/>
        /// Default Value: 3F<br/>
        /// Example: 3F
        /// </summary>
        /// <example>3F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public double? Guidance { get; set; }

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
        /// Initializes a new instance of the <see cref="FluxDevInputs" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="imagePrompt">
        /// Optional base64 encoded image to use as a prompt for generation.
        /// </param>
        /// <param name="width">
        /// Width of the generated image in pixels. Must be a multiple of 32.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Height of the generated image in pixels. Must be a multiple of 32.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="steps">
        /// Number of steps for the image generation process.<br/>
        /// Default Value: 28<br/>
        /// Example: 28
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="guidance">
        /// Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.<br/>
        /// Default Value: 3F<br/>
        /// Example: 3F
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
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FluxDevInputs(
            string? prompt,
            string? imagePrompt,
            int? width,
            int? height,
            int? steps,
            bool? promptUpsampling,
            int? seed,
            double? guidance,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.Prompt = prompt;
            this.ImagePrompt = imagePrompt;
            this.Width = width;
            this.Height = height;
            this.Steps = steps;
            this.PromptUpsampling = promptUpsampling;
            this.Seed = seed;
            this.Guidance = guidance;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxDevInputs" /> class.
        /// </summary>
        public FluxDevInputs()
        {
        }
    }
}