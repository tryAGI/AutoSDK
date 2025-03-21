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
        /// Number of tokens in the generated completion.<br/>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Breakdown of tokens used in a completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_details")]
        public global::G.CompletionUsageCompletionTokensDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Number of tokens in the prompt.<br/>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// Breakdown of tokens used in the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_details")]
        public global::G.CompletionUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Total number of tokens used in the request (prompt + completion).<br/>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsage" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Number of tokens in the generated completion.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="completionTokensDetails">
        /// Breakdown of tokens used in a completion.
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokensDetails">
        /// Breakdown of tokens used in the prompt.
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used in the request (prompt + completion).<br/>
        /// Default Value: 0
        /// </param>
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