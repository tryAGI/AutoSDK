//HintName: G.Models.CompletionUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage statistics for the completion request.
    /// </summary>
    public sealed partial class CompletionUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        public global::G.CompletionTokensDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::G.PromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsage" /> class.
        /// </summary>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="completionTokensDetails"></param>
        /// <param name="promptTokensDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionUsage(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            global::G.CompletionTokensDetails? completionTokensDetails,
            global::G.PromptTokensDetails? promptTokensDetails)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.CompletionTokensDetails = completionTokensDetails;
            this.PromptTokensDetails = promptTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsage" /> class.
        /// </summary>
        public CompletionUsage()
        {
        }
    }
}