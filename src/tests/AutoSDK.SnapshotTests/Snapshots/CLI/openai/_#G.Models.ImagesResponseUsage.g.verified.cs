//HintName: G.Models.ImagesResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For `gpt-image-1` only, the token usage information for the image generation.
    /// </summary>
    public sealed partial class ImagesResponseUsage
    {
        /// <summary>
        /// The total number of tokens (images and text) used for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// The number of tokens (images and text) in the input prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The number of image tokens in the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// The input tokens detailed information for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImagesResponseUsageInputTokensDetails InputTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesResponseUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The total number of tokens (images and text) used for the image generation.
        /// </param>
        /// <param name="inputTokens">
        /// The number of tokens (images and text) in the input prompt.
        /// </param>
        /// <param name="outputTokens">
        /// The number of image tokens in the output image.
        /// </param>
        /// <param name="inputTokensDetails">
        /// The input tokens detailed information for the image generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesResponseUsage(
            int totalTokens,
            int inputTokens,
            int outputTokens,
            global::G.ImagesResponseUsageInputTokensDetails inputTokensDetails)
        {
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesResponseUsage" /> class.
        /// </summary>
        public ImagesResponseUsage()
        {
        }
    }
}