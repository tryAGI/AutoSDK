//HintName: G.Models.PromptTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of tokens used in the prompt.
    /// </summary>
    public sealed partial class PromptTokensDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTokensDetails" /> class.
        /// </summary>
        /// <param name="audioTokens"></param>
        /// <param name="cachedTokens"></param>
        public PromptTokensDetails(
            int? audioTokens,
            int? cachedTokens)
        {
            this.AudioTokens = audioTokens;
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTokensDetails" /> class.
        /// </summary>
        public PromptTokensDetails()
        {
        }
    }
}