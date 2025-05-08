//HintName: G.Models.ImagesResponseUsageInputTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The input tokens detailed information for the image generation.
    /// </summary>
    public sealed partial class ImagesResponseUsageInputTokensDetails
    {
        /// <summary>
        /// The number of text tokens in the input prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TextTokens { get; set; } = default!;

        /// <summary>
        /// The number of image tokens in the input prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int ImageTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesResponseUsageInputTokensDetails" /> class.
        /// </summary>
        /// <param name="textTokens">
        /// The number of text tokens in the input prompt.
        /// </param>
        /// <param name="imageTokens">
        /// The number of image tokens in the input prompt.
        /// </param>
        public ImagesResponseUsageInputTokensDetails(
            int textTokens,
            int imageTokens)
        {
            this.TextTokens = textTokens;
            this.ImageTokens = imageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesResponseUsageInputTokensDetails" /> class.
        /// </summary>
        public ImagesResponseUsageInputTokensDetails()
        {
        }
    }
}