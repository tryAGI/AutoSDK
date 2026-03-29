//HintName: G.Models.ChatCompletionUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage information for the chat completion response. Please note that at this time Knowledge Graph tool usage is not included in this object.
    /// </summary>
    public sealed partial class ChatCompletionUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_details")]
        public global::G.PromptTokenDetails? PromptTokenDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        public global::G.CompletionTokenDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        /// <param name="promptTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokenDetails"></param>
        /// <param name="completionTokensDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUsage(
            int promptTokens,
            int totalTokens,
            int completionTokens,
            global::G.PromptTokenDetails? promptTokenDetails,
            global::G.CompletionTokenDetails? completionTokensDetails)
        {
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.CompletionTokens = completionTokens;
            this.PromptTokenDetails = promptTokenDetails;
            this.CompletionTokensDetails = completionTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        public ChatCompletionUsage()
        {
        }
    }
}