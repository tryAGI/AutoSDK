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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::G.AgentConfigOverrideConfig? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts")]
        public global::G.TTSConversationalConfigOverrideConfig? Tts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideConfigInput" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="tts"></param>
        public ConversationConfigClientOverrideConfigInput(
            global::G.AgentConfigOverrideConfig? agent,
            global::G.TTSConversationalConfigOverrideConfig? tts)
        {
            this.Agent = agent;
            this.Tts = tts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideConfigInput" /> class.
        /// </summary>
        public ConversationConfigClientOverrideConfigInput()
        {
        }
    }
}