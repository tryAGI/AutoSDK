//HintName: G.Models.Flux2KleinInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Input model for FLUX.2 Klein (non-base) - like Pro but max 4 images.
    /// </summary>
    public sealed partial class Flux2KleinInputs
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
        /// Path to the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image")]
        public string? InputImage { get; set; }

        /// <summary>
        /// Path to the second input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_2")]
        public string? InputImage2 { get; set; }

        /// <summary>
        /// Path to the third input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_3")]
        public string? InputImage3 { get; set; }

        /// <summary>
        /// Path to the fourth input image.
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
        /// Width of the image<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the image<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
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
        /// Remove the background from the generated image, returning a transparent RGBA PNG.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transparent_bg")]
        public bool? TransparentBg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2KleinInputs" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="inputImage">
        /// Path to the input image.
        /// </param>
        /// <param name="inputImage2">
        /// Path to the second input image.
        /// </param>
        /// <param name="inputImage3">
        /// Path to the third input image.
        /// </param>
        /// <param name="inputImage4">
        /// Path to the fourth input image.
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="width">
        /// Width of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="height">
        /// Height of the image<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: jpeg
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
        /// <param name="transparentBg">
        /// Remove the background from the generated image, returning a transparent RGBA PNG.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux2KleinInputs(
            string prompt,
            string? inputImage,
            string? inputImage2,
            string? inputImage3,
            string? inputImage4,
            int? seed,
            int? width,
            int? height,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
            string? webhookUrl,
            string? webhookSecret,
            bool? transparentBg)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.InputImage = inputImage;
            this.InputImage2 = inputImage2;
            this.InputImage3 = inputImage3;
            this.InputImage4 = inputImage4;
            this.Seed = seed;
            this.Width = width;
            this.Height = height;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
            this.TransparentBg = transparentBg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2KleinInputs" /> class.
        /// </summary>
        public Flux2KleinInputs()
        {
        }
    }
}