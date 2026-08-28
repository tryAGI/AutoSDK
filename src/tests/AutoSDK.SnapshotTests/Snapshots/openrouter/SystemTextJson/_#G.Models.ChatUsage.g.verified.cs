//HintName: G.Models.ChatUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Token usage statistics
    /// </summary>
    public sealed partial class ChatUsage
    {
        /// <summary>
        /// Number of tokens in the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// Total number of tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTokens { get; set; }

        /// <summary>
        /// Detailed completion token usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        public global::G.ChatUsageCompletionTokensDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Detailed prompt token usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::G.ChatUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsage" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Number of tokens in the completion
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens
        /// </param>
        /// <param name="completionTokensDetails">
        /// Detailed completion token usage
        /// </param>
        /// <param name="promptTokensDetails">
        /// Detailed prompt token usage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatUsage(
            double completionTokens,
            double promptTokens,
            double totalTokens,
            global::G.ChatUsageCompletionTokensDetails? completionTokensDetails,
            global::G.ChatUsagePromptTokensDetails? promptTokensDetails)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.CompletionTokensDetails = completionTokensDetails;
            this.PromptTokensDetails = promptTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsage" /> class.
        /// </summary>
        public ChatUsage()
        {
        }

    }
}