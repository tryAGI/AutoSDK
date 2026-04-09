//HintName: G.Models.CreateImageExpansionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageExpansionRequest
    {
        /// <summary>
        /// Input image as Base64 string or URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public string Image { get; set; } = default!;

        /// <summary>
        /// Text prompt to guide the expansion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expansion_ratio", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExpansionRatio ExpansionRatio { get; set; } = default!;

        /// <summary>
        /// Target aspect ratio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateImageExpansionRequestAspectRatioJsonConverter))]
        public global::G.CreateImageExpansionRequestAspectRatio? AspectRatio { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateImageExpansionRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// Input image as Base64 string or URL.
        /// </param>
        /// <param name="expansionRatio"></param>
        /// <param name="prompt">
        /// Text prompt to guide the expansion.
        /// </param>
        /// <param name="aspectRatio">
        /// Target aspect ratio.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        public CreateImageExpansionRequest(
            string image,
            global::G.ExpansionRatio expansionRatio,
            string? prompt,
            global::G.CreateImageExpansionRequestAspectRatio? aspectRatio,
            string? callbackUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Prompt = prompt;
            this.ExpansionRatio = expansionRatio ?? throw new global::System.ArgumentNullException(nameof(expansionRatio));
            this.AspectRatio = aspectRatio;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageExpansionRequest" /> class.
        /// </summary>
        public CreateImageExpansionRequest()
        {
        }
    }
}