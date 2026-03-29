//HintName: G.Models.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The amount of tokens used in the request.
    /// </summary>
    public sealed partial class ChatCompletionsPostResponsesContentApplicationJsonSchemaUsage
    {
        /// <summary>
        /// The amount of tokens included in the request prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Further information about the amount of tokens used in the request prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_details")]
        public global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// The amount of tokens included in the request completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Further information about the amount of tokens in the request completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_details")]
        public global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// The total amount of tokens used in the entire request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// The amount of tokens included in the request prompt.
        /// </param>
        /// <param name="promptTokensDetails">
        /// Further information about the amount of tokens used in the request prompt.
        /// </param>
        /// <param name="completionTokens">
        /// The amount of tokens included in the request completion.
        /// </param>
        /// <param name="completionTokensDetails">
        /// Further information about the amount of tokens in the request completion.
        /// </param>
        /// <param name="totalTokens">
        /// The total amount of tokens used in the entire request.
        /// </param>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaUsage(
            int? promptTokens,
            global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails? promptTokensDetails,
            int? completionTokens,
            global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails? completionTokensDetails,
            int? totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.CompletionTokens = completionTokens;
            this.CompletionTokensDetails = completionTokensDetails;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaUsage()
        {
        }
    }
}