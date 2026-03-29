//HintName: G.Models.AgentTriggers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Trigger configurations for this agent
    /// </summary>
    public sealed partial class AgentTriggers
    {
        /// <summary>
        /// Configuration for a specific trigger event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.AgentTriggersChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTriggers" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration for a specific trigger event
        /// </param>
        public AgentTriggers(
            global::G.AgentTriggersChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTriggers" /> class.
        /// </summary>
        public AgentTriggers()
        {
        }
    }
}