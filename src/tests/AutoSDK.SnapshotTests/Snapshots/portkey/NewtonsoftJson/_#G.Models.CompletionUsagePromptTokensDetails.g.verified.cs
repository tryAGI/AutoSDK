//HintName: G.Models.CompletionUsagePromptTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of tokens used in the prompt.
    /// </summary>
    public sealed partial class CompletionUsagePromptTokensDetails
    {
        /// <summary>
        /// Cached tokens present in the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Cached tokens present in the prompt.
        /// </param>
        public CompletionUsagePromptTokensDetails(
            int? cachedTokens)
        {
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsagePromptTokensDetails" /> class.
        /// </summary>
        public CompletionUsagePromptTokensDetails()
        {
        }
    }
}