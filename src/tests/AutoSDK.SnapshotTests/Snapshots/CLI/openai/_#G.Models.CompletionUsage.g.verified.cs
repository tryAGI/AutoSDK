﻿//HintName: G.Models.CompletionUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage statistics for the completion request.
    /// </summary>
    public sealed partial class CompletionUsage
    {
        /// <summary>
        /// Number of tokens in the generated completion.<br/>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; } = 0;

        /// <summary>
        /// Number of tokens in the prompt.<br/>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; } = 0;

        /// <summary>
        /// Total number of tokens used in the request (prompt + completion).<br/>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; } = 0;

        /// <summary>
        /// Breakdown of tokens used in a completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_details")]
        public global::G.CompletionUsageCompletionTokensDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Breakdown of tokens used in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::G.CompletionUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsage" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Number of tokens in the generated completion.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used in the request (prompt + completion).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="completionTokensDetails">
        /// Breakdown of tokens used in a completion.
        /// </param>
        /// <param name="promptTokensDetails">
        /// Breakdown of tokens used in the prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionUsage(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            global::G.CompletionUsageCompletionTokensDetails? completionTokensDetails,
            global::G.CompletionUsagePromptTokensDetails? promptTokensDetails)
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