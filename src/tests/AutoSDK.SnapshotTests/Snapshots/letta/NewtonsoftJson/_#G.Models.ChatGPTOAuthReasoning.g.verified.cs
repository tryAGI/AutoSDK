//HintName: G.Models.ChatGPTOAuthReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reasoning configuration for ChatGPT OAuth models (GPT-5.x, o-series).
    /// </summary>
    public sealed partial class ChatGPTOAuthReasoning
    {
        /// <summary>
        /// The reasoning effort level for GPT-5.x and o-series models.<br/>
        /// Default Value: medium
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        public global::G.ChatGPTOAuthReasoningReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGPTOAuthReasoning" /> class.
        /// </summary>
        /// <param name="reasoningEffort">
        /// The reasoning effort level for GPT-5.x and o-series models.<br/>
        /// Default Value: medium
        /// </param>
        public ChatGPTOAuthReasoning(
            global::G.ChatGPTOAuthReasoningReasoningEffort? reasoningEffort)
        {
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatGPTOAuthReasoning" /> class.
        /// </summary>
        public ChatGPTOAuthReasoning()
        {
        }
    }
}