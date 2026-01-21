//HintName: G.Models.ConversationConfigClientOverrideConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConfigClientOverrideConfigInput
    {
        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts")]
        public global::G.TTSConversationalConfigOverrideConfig? Tts { get; set; }

        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation")]
        public global::G.ConversationConfigOverrideConfig? Conversation { get; set; }

        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::G.AgentConfigOverrideConfig? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideConfigInput" /> class.
        /// </summary>
        /// <param name="tts">
        /// Configures overrides for nested fields.
        /// </param>
        /// <param name="conversation">
        /// Configures overrides for nested fields.
        /// </param>
        /// <param name="agent">
        /// Configures overrides for nested fields.
        /// </param>
        public ConversationConfigClientOverrideConfigInput(
            global::G.TTSConversationalConfigOverrideConfig? tts,
            global::G.ConversationConfigOverrideConfig? conversation,
            global::G.AgentConfigOverrideConfig? agent)
        {
            this.Tts = tts;
            this.Conversation = conversation;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideConfigInput" /> class.
        /// </summary>
        public ConversationConfigClientOverrideConfigInput()
        {
        }
    }
}