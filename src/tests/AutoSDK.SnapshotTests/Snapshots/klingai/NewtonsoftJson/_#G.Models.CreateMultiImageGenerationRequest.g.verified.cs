//HintName: G.Models.CreateMultiImageGenerationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMultiImageGenerationRequest
    {
        /// <summary>
        /// Model to use for generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Text prompt for generation. Max 2500 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Array of reference images as Base64 strings or URLs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Images { get; set; } = default!;

        /// <summary>
        /// Aspect ratio of the output image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateMultiImageGenerationRequestAspectRatioJsonConverter))]
        public global::G.CreateMultiImageGenerationRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Number of images to generate. Range [1, 9].<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultiImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for generation. Max 2500 characters.
        /// </param>
        /// <param name="images">
        /// Array of reference images as Base64 strings or URLs.
        /// </param>
        /// <param name="modelName">
        /// Model to use for generation.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the output image.
        /// </param>
        /// <param name="n">
        /// Number of images to generate. Range [1, 9].<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        public CreateMultiImageGenerationRequest(
            string prompt,
            global::System.Collections.Generic.IList<string> images,
            string? modelName,
            global::G.CreateMultiImageGenerationRequestAspectRatio? aspectRatio,
            int? n,
            string? callbackUrl)
        {
            this.ModelName = modelName;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.AspectRatio = aspectRatio;
            this.N = n;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultiImageGenerationRequest" /> class.
        /// </summary>
        public CreateMultiImageGenerationRequest()
        {
        }
    }
}