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
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateImageGenerationRequestModelNameJsonConverter))]
        public global::G.CreateImageGenerationRequestModelName? ModelName { get; set; }

        /// <summary>
        /// Text prompt for image generation. Max 2500 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Reference image as Base64 string or URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Type of image reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_reference")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateImageGenerationRequestImageReferenceJsonConverter))]
        public global::G.CreateImageGenerationRequestImageReference? ImageReference { get; set; }

        /// <summary>
        /// Fidelity to the reference image. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_fidelity")]
        public double? ImageFidelity { get; set; }

        /// <summary>
        /// Fidelity to human features. Range [0, 1]. Default 0.45.<br/>
        /// Default Value: 0.45
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("human_fidelity")]
        public double? HumanFidelity { get; set; }

        /// <summary>
        /// Number of images to generate. Range [1, 9].<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; }

        /// <summary>
        /// Aspect ratio of the output image.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateImageGenerationRequestAspectRatioJsonConverter))]
        public global::G.CreateImageGenerationRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Resolution of the output image.<br/>
        /// Default Value: 1k
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateImageGenerationRequestResolutionJsonConverter))]
        public global::G.CreateImageGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// External task ID for tracking purposes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_task_id")]
        public string? ExternalTaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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