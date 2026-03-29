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
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Text prompt to guide the expansion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expansion_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExpansionRatio ExpansionRatio { get; set; }

        /// <summary>
        /// Target aspect ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageExpansionRequestAspectRatioJsonConverter))]
        public global::G.CreateImageExpansionRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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