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
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// Total number of tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// Detailed completion token usage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_details")]
        public global::G.OneOf<global::G.ChatUsageCompletionTokensDetails, object>? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Detailed prompt token usage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_details")]
        public global::G.OneOf<global::G.ChatUsagePromptTokensDetails, object>? PromptTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public ChatUsage(
            double completionTokens,
            double promptTokens,
            double totalTokens,
            global::G.OneOf<global::G.ChatUsageCompletionTokensDetails, object>? completionTokensDetails,
            global::G.OneOf<global::G.ChatUsagePromptTokensDetails, object>? promptTokensDetails)
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