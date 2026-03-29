//HintName: G.Models.CompletionUsagePromptTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of tokens in the prompt.
    /// </summary>
    public sealed partial class CompletionUsagePromptTokensDetails
    {
        /// <summary>
        /// Number of tokens that were cached and reused.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CachedTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Number of tokens that were cached and reused.
        /// </param>
        public CompletionUsagePromptTokensDetails(
            int cachedTokens)
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