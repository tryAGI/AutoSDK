//HintName: G.Models.UsageStatisticsCompletionTokenDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageStatisticsCompletionTokenDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatisticsCompletionTokenDetails" /> class.
        /// </summary>
        /// <param name="reasoningTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageStatisticsCompletionTokenDetails(
            int? reasoningTokens)
        {
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatisticsCompletionTokenDetails" /> class.
        /// </summary>
        public UsageStatisticsCompletionTokenDetails()
        {
        }
    }
}