//HintName: G.Models.OutputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output token usage details.
    /// </summary>
    public sealed partial class OutputTokens
    {
        /// <summary>
        /// Number of output tokens generated.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// Number of tokens used for reasoning/thinking.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens")]
        public long? ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTokens" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of output tokens generated.<br/>
        /// Example: 30
        /// </param>
        /// <param name="reasoningTokens">
        /// Number of tokens used for reasoning/thinking.<br/>
        /// Example: 0
        /// </param>
        public OutputTokens(
            long? count,
            long? reasoningTokens)
        {
            this.Count = count;
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTokens" /> class.
        /// </summary>
        public OutputTokens()
        {
        }
    }
}