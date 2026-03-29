//HintName: G.Models.AgentCreateDtoTriggers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event-based trigger configuration for the Agent.
    /// </summary>
    public sealed partial class AgentCreateDtoTriggers
    {
        /// <summary>
        /// Configuration triggered when a chat session ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.AgentCreateDtoTriggersChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoTriggers" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration triggered when a chat session ends.
        /// </param>
        public AgentCreateDtoTriggers(
            global::G.AgentCreateDtoTriggersChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoTriggers" /> class.
        /// </summary>
        public AgentCreateDtoTriggers()
        {
        }
    }
}