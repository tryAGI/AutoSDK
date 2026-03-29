//HintName: G.Models.MultimodalEmbeddingsApiResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultimodalEmbeddingsApiResponseUsage
    {
        /// <summary>
        /// The total number of text tokens in the list of inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// The total number of image pixels in the list of inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_pixels")]
        public int? ImagePixels { get; set; }

        /// <summary>
        /// The combined total of text and image tokens. Every 560 pixels counts as a token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalEmbeddingsApiResponseUsage" /> class.
        /// </summary>
        /// <param name="textTokens">
        /// The total number of text tokens in the list of inputs.
        /// </param>
        /// <param name="imagePixels">
        /// The total number of image pixels in the list of inputs.
        /// </param>
        /// <param name="totalTokens">
        /// The combined total of text and image tokens. Every 560 pixels counts as a token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultimodalEmbeddingsApiResponseUsage(
            int? textTokens,
            int? imagePixels,
            int? totalTokens)
        {
            this.TextTokens = textTokens;
            this.ImagePixels = imagePixels;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultimodalEmbeddingsApiResponseUsage" /> class.
        /// </summary>
        public MultimodalEmbeddingsApiResponseUsage()
        {
        }
    }
}