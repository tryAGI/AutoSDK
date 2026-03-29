//HintName: G.Models.FluxKontextProInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FluxKontextProInputs
    {
        /// <summary>
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </summary>
        /// <example>ein fantastisches bild</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Base64 encoded image or URL to use with Kontext.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image")]
        public string? InputImage { get; set; }

        /// <summary>
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_2")]
        public string? InputImage2 { get; set; }

        /// <summary>
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_3")]
        public string? InputImage3 { get; set; }

        /// <summary>
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_4")]
        public string? InputImage4 { get; set; }

        /// <summary>
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Aspect ratio of the image between 21:9 and 9:21
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: png
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
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_upsampling")]
        public bool? PromptUpsampling { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxKontextProInputs" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="inputImage">
        /// Base64 encoded image or URL to use with Kontext.
        /// </param>
        /// <param name="inputImage2">
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </param>
        /// <param name="inputImage3">
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </param>
        /// <param name="inputImage4">
        /// Base64 encoded image or URL to use with Kontext. *Experimental Multiref*
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the image between 21:9 and 9:21
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FluxKontextProInputs(
            string prompt,
            string? inputImage,
            string? inputImage2,
            string? inputImage3,
            string? inputImage4,
            int? seed,
            string? aspectRatio,
            global::G.OutputFormat? outputFormat,
            string? webhookUrl,
            string? webhookSecret,
            bool? promptUpsampling,
            int? safetyTolerance)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.InputImage = inputImage;
            this.InputImage2 = inputImage2;
            this.InputImage3 = inputImage3;
            this.InputImage4 = inputImage4;
            this.Seed = seed;
            this.AspectRatio = aspectRatio;
            this.OutputFormat = outputFormat;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
            this.PromptUpsampling = promptUpsampling;
            this.SafetyTolerance = safetyTolerance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxKontextProInputs" /> class.
        /// </summary>
        public FluxKontextProInputs()
        {
        }
    }
}