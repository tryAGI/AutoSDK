//HintName: G.Models.FluxProExpandInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FluxProExpandInputs
    {
        /// <summary>
        /// A Base64-encoded string representing the image you wish to expand.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Number of pixels to expand at the top of the image<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        public int? Top { get; set; }

        /// <summary>
        /// Number of pixels to expand at the bottom of the image<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom")]
        public int? Bottom { get; set; }

        /// <summary>
        /// Number of pixels to expand on the left side of the image<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        public int? Left { get; set; }

        /// <summary>
        /// Number of pixels to expand on the right side of the image<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        public int? Right { get; set; }

        /// <summary>
        /// The description of the changes you want to make. This text guides the expansion process, allowing you to specify features, styles, or modifications for the expanded areas.<br/>
        /// Example: ein fantastisches bild
        /// </summary>
        /// <example>ein fantastisches bild</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Number of steps for the image generation process<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_upsampling")]
        public bool? PromptUpsampling { get; set; }

        /// <summary>
        /// Optional seed for reproducibility
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Guidance strength for the image generation process<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::G.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

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
        /// Initializes a new instance of the <see cref="FluxProExpandInputs" /> class.
        /// </summary>
        /// <param name="image">
        /// A Base64-encoded string representing the image you wish to expand.
        /// </param>
        /// <param name="top">
        /// Number of pixels to expand at the top of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="bottom">
        /// Number of pixels to expand at the bottom of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="left">
        /// Number of pixels to expand on the left side of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="right">
        /// Number of pixels to expand on the right side of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="prompt">
        /// The description of the changes you want to make. This text guides the expansion process, allowing you to specify features, styles, or modifications for the expanded areas.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FluxProExpandInputs(
            string image,
            int? top,
            int? bottom,
            int? left,
            int? right,
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
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
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
        /// Initializes a new instance of the <see cref="FluxProExpandInputs" /> class.
        /// </summary>
        public FluxProExpandInputs()
        {
        }
    }
}