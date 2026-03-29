//HintName: G.Models.CreateImageGenerationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageGenerationRequest
    {
        /// <summary>
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageGenerationRequestModelNameJsonConverter))]
        public global::G.CreateImageGenerationRequestModelName? ModelName { get; set; }

        /// <summary>
        /// Text prompt for image generation. Max 2500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Reference image as Base64 string or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Type of image reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_reference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageGenerationRequestImageReferenceJsonConverter))]
        public global::G.CreateImageGenerationRequestImageReference? ImageReference { get; set; }

        /// <summary>
        /// Fidelity to the reference image. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_fidelity")]
        public double? ImageFidelity { get; set; }

        /// <summary>
        /// Fidelity to human features. Range [0, 1]. Default 0.45.<br/>
        /// Default Value: 0.45
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_fidelity")]
        public double? HumanFidelity { get; set; }

        /// <summary>
        /// Number of images to generate. Range [1, 9].<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Aspect ratio of the output image.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageGenerationRequestAspectRatioJsonConverter))]
        public global::G.CreateImageGenerationRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Resolution of the output image.<br/>
        /// Default Value: 1k
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageGenerationRequestResolutionJsonConverter))]
        public global::G.CreateImageGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// External task ID for tracking purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_task_id")]
        public string? ExternalTaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for image generation. Max 2500 characters.
        /// </param>
        /// <param name="modelName">
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
        /// </param>
        /// <param name="negativePrompt">
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </param>
        /// <param name="image">
        /// Reference image as Base64 string or URL.
        /// </param>
        /// <param name="imageReference">
        /// Type of image reference.
        /// </param>
        /// <param name="imageFidelity">
        /// Fidelity to the reference image. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="humanFidelity">
        /// Fidelity to human features. Range [0, 1]. Default 0.45.<br/>
        /// Default Value: 0.45
        /// </param>
        /// <param name="n">
        /// Number of images to generate. Range [1, 9].<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the output image.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Resolution of the output image.<br/>
        /// Default Value: 1k
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="externalTaskId">
        /// External task ID for tracking purposes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageGenerationRequest(
            string prompt,
            global::G.CreateImageGenerationRequestModelName? modelName,
            string? negativePrompt,
            string? image,
            global::G.CreateImageGenerationRequestImageReference? imageReference,
            double? imageFidelity,
            double? humanFidelity,
            int? n,
            global::G.CreateImageGenerationRequestAspectRatio? aspectRatio,
            global::G.CreateImageGenerationRequestResolution? resolution,
            string? callbackUrl,
            string? externalTaskId)
        {
            this.ModelName = modelName;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.Image = image;
            this.ImageReference = imageReference;
            this.ImageFidelity = imageFidelity;
            this.HumanFidelity = humanFidelity;
            this.N = n;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.CallbackUrl = callbackUrl;
            this.ExternalTaskId = externalTaskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageGenerationRequest" /> class.
        /// </summary>
        public CreateImageGenerationRequest()
        {
        }
    }
}