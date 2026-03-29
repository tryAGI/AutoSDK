//HintName: G.Models.ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem" /> class.
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="userId"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="count"></param>
        public ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem(
            double cost,
            string userId,
            double completionTokens,
            double promptTokens,
            double count)
        {
            this.Cost = cost;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem()
        {
        }
    }
}