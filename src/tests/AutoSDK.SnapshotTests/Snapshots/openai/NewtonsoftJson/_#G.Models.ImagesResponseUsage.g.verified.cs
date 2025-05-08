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
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// The number of tokens (images and text) in the input prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// The number of image tokens in the output image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// The input tokens detailed information for the image generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImagesResponseUsageInputTokensDetails InputTokensDetails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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