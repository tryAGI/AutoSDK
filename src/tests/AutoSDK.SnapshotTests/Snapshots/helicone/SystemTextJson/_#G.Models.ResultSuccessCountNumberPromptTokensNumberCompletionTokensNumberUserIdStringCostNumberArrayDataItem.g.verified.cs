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
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCountNumberPromptTokensNumberCompletionTokensNumberUserIdStringCostNumberArrayDataItem" /> class.
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="userId"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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