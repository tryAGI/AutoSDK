//HintName: G.Models.CompletionTokenDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionTokenDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReasoningTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionTokenDetails" /> class.
        /// </summary>
        /// <param name="reasoningTokens"></param>
        public CompletionTokenDetails(
            int reasoningTokens)
        {
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionTokenDetails" /> class.
        /// </summary>
        public CompletionTokenDetails()
        {
        }
    }
}