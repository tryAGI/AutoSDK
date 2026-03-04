//HintName: G.Models.FineTuneChatCompletionRequestAssistantMessageAssistantMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneChatCompletionRequestAssistantMessageAssistantMessage
    {
        /// <summary>
        /// Controls whether the assistant message is trained against (0 or 1)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatCompletionRequestAssistantMessageAssistantMessage" /> class.
        /// </summary>
        /// <param name="weight">
        /// Controls whether the assistant message is trained against (0 or 1)
        /// </param>
        public FineTuneChatCompletionRequestAssistantMessageAssistantMessage(
            int? weight)
        {
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatCompletionRequestAssistantMessageAssistantMessage" /> class.
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessageAssistantMessage()
        {
        }
    }
}