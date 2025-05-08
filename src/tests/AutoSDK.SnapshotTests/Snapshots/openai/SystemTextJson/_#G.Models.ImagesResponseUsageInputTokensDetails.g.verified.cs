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
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TextTokens { get; set; }

        /// <summary>
        /// The number of image tokens in the input prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ImageTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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