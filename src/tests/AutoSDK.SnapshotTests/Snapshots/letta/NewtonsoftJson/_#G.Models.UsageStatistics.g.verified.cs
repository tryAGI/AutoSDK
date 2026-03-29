//HintName: G.Models.UsageStatistics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageStatistics
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_details")]
        public global::G.UsageStatisticsPromptTokenDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_details")]
        public global::G.UsageStatisticsCompletionTokenDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatistics" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokensDetails"></param>
        /// <param name="completionTokensDetails"></param>
        public UsageStatistics(
            int? completionTokens,
            int? promptTokens,
            int? totalTokens,
            global::G.UsageStatisticsPromptTokenDetails? promptTokensDetails,
            global::G.UsageStatisticsCompletionTokenDetails? completionTokensDetails)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.CompletionTokensDetails = completionTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatistics" /> class.
        /// </summary>
        public UsageStatistics()
        {
        }
    }
}