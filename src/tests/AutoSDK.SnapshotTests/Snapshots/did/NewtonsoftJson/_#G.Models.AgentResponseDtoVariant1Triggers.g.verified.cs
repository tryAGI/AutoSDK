//HintName: G.Models.AgentResponseDtoVariant1Triggers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Trigger configurations for this agent
    /// </summary>
    public sealed partial class AgentResponseDtoVariant1Triggers
    {
        /// <summary>
        /// Configuration for a specific trigger event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.AgentResponseDtoVariant1TriggersChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDtoVariant1Triggers" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration for a specific trigger event
        /// </param>
        public AgentResponseDtoVariant1Triggers(
            global::G.AgentResponseDtoVariant1TriggersChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDtoVariant1Triggers" /> class.
        /// </summary>
        public AgentResponseDtoVariant1Triggers()
        {
        }
    }
}