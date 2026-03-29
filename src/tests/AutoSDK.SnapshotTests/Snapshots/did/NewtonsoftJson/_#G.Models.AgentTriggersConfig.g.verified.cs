//HintName: G.Models.AgentTriggersConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Agent triggers configuration with event-specific settings
    /// </summary>
    public sealed partial class AgentTriggersConfig
    {
        /// <summary>
        /// Configuration for a specific trigger event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.AgentTriggersConfigChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTriggersConfig" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration for a specific trigger event
        /// </param>
        public AgentTriggersConfig(
            global::G.AgentTriggersConfigChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTriggersConfig" /> class.
        /// </summary>
        public AgentTriggersConfig()
        {
        }
    }
}