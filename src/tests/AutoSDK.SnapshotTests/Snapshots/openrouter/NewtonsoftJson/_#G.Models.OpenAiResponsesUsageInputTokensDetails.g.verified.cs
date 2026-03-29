//HintName: G.Models.OpenAiResponsesUsageInputTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAiResponsesUsageInputTokensDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CachedTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponsesUsageInputTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens"></param>
        public OpenAiResponsesUsageInputTokensDetails(
            double cachedTokens)
        {
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponsesUsageInputTokensDetails" /> class.
        /// </summary>
        public OpenAiResponsesUsageInputTokensDetails()
        {
        }
    }
}