//HintName: G.Models.AgentUpdateDtoTriggers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event-based trigger configuration for the Agent.
    /// </summary>
    public sealed partial class AgentUpdateDtoTriggers
    {
        /// <summary>
        /// Configuration triggered when a chat session ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.AgentUpdateDtoTriggersChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoTriggers" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration triggered when a chat session ends.
        /// </param>
        public AgentUpdateDtoTriggers(
            global::G.AgentUpdateDtoTriggersChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoTriggers" /> class.
        /// </summary>
        public AgentUpdateDtoTriggers()
        {
        }
    }
}