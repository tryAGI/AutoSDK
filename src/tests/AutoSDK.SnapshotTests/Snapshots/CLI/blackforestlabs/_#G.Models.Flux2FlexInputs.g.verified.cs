//HintName: G.Models.Flux2FlexInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Flux2FlexInputs
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
        /// Whether to use prompt upsampling.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_upsampling")]
        public bool? PromptUpsampling { get; set; }

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
        /// Path to the fifth input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_5")]
        public string? InputImage5 { get; set; }

        /// <summary>
        /// Path to the sixth input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_6")]
        public string? InputImage6 { get; set; }

        /// <summary>
        /// Path to the seventh input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_7")]
        public string? InputImage7 { get; set; }

        /// <summary>
        /// Path to the eighth input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_8")]
        public string? InputImage8 { get; set; }

        /// <summary>
        /// Blob path to the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_blob_path")]
        public string? InputImageBlobPath { get; set; }

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
        /// Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.<br/>
        /// Default Value: 5F<br/>
        /// Example: 5F
        /// </summary>
        /// <example>5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// Number of steps for image generation. Higher steps lead to more detailed and realistic images.<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2FlexInputs" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation.<br/>
        /// Example: ein fantastisches bild
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to use prompt upsampling.<br/>
        /// Default Value: true
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
        /// <param name="inputImage5">
        /// Path to the fifth input image.
        /// </param>
        /// <param name="inputImage6">
        /// Path to the sixth input image.
        /// </param>
        /// <param name="inputImage7">
        /// Path to the seventh input image.
        /// </param>
        /// <param name="inputImage8">
        /// Path to the eighth input image.
        /// </param>
        /// <param name="inputImageBlobPath">
        /// Blob path to the input image.
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
        /// <param name="guidance">
        /// Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.<br/>
        /// Default Value: 5F<br/>
        /// Example: 5F
        /// </param>
        /// <param name="steps">
        /// Number of steps for image generation. Higher steps lead to more detailed and realistic images.<br/>
        /// Default Value: 50<br/>
        /// Example: 50
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux2FlexInputs(
            string prompt,
            bool? promptUpsampling,
            string? inputImage,
            string? inputImage2,
            string? inputImage3,
            string? inputImage4,
            string? inputImage5,
            string? inputImage6,
            string? inputImage7,
            string? inputImage8,
            string? inputImageBlobPath,
            int? seed,
            int? width,
            int? height,
            double? guidance,
            int? steps,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.PromptUpsampling = promptUpsampling;
            this.InputImage = inputImage;
            this.InputImage2 = inputImage2;
            this.InputImage3 = inputImage3;
            this.InputImage4 = inputImage4;
            this.InputImage5 = inputImage5;
            this.InputImage6 = inputImage6;
            this.InputImage7 = inputImage7;
            this.InputImage8 = inputImage8;
            this.InputImageBlobPath = inputImageBlobPath;
            this.Seed = seed;
            this.Width = width;
            this.Height = height;
            this.Guidance = guidance;
            this.Steps = steps;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2FlexInputs" /> class.
        /// </summary>
        public Flux2FlexInputs()
        {
        }
    }
}