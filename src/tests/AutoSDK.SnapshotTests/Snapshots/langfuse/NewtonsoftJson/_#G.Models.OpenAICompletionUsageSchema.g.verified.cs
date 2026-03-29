//HintName: G.Models.OpenAICompletionUsageSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI Usage schema from (Chat-)Completion APIs
    /// </summary>
    public sealed partial class OpenAICompletionUsageSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_details")]
        public global::System.Collections.Generic.Dictionary<string, int?>? PromptTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_details")]
        public global::System.Collections.Generic.Dictionary<string, int?>? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompletionUsageSchema" /> class.
        /// </summary>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="promptTokensDetails"></param>
        /// <param name="completionTokensDetails"></param>
        public OpenAICompletionUsageSchema(
            int promptTokens,
            int completionTokens,
            int totalTokens,
            global::System.Collections.Generic.Dictionary<string, int?>? promptTokensDetails,
            global::System.Collections.Generic.Dictionary<string, int?>? completionTokensDetails)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.CompletionTokensDetails = completionTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompletionUsageSchema" /> class.
        /// </summary>
        public OpenAICompletionUsageSchema()
        {
        }
    }
}