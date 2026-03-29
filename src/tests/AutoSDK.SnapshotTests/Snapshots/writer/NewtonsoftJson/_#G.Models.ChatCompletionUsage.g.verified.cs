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
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_token_details")]
        public global::G.PromptTokenDetails? PromptTokenDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_details")]
        public global::G.CompletionTokenDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsage" /> class.
        /// </summary>
        /// <param name="promptTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokenDetails"></param>
        /// <param name="completionTokensDetails"></param>
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