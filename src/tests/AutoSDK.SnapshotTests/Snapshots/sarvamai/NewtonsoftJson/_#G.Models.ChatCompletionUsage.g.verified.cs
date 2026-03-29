//HintName: G.Models.ChatCompletionUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUsage
    {
        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Number of tokens in the completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Total tokens used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt
        /// </param>
        /// <param name="completionTokens">
        /// Number of tokens in the completion
        /// </param>
        /// <param name="totalTokens">
        /// Total tokens used
        /// </param>
        public ChatCompletionUsage(
            int? promptTokens,
            int? completionTokens,
            int? totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        public ChatCompletionUsage()
        {
        }
    }
}