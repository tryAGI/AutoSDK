//HintName: G.Models.ConversationConfigClientOverrideOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"voice_id":"cjVigY5qzO86Huf0OWal"}}
    /// </summary>
    public sealed partial class ConversationConfigClientOverrideOutput
    {
        /// <summary>
        /// Configuration for conversational text to speech
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts")]
        public global::G.TTSConversationalConfigOverride? Tts { get; set; }

        /// <summary>
        /// Configuration for conversational events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation")]
        public global::G.ConversationConfigOverride? Conversation { get; set; }

        /// <summary>
        /// Agent specific configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::G.AgentConfigOverride? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideOutput" /> class.
        /// </summary>
        /// <param name="tts">
        /// Configuration for conversational text to speech
        /// </param>
        /// <param name="conversation">
        /// Configuration for conversational events
        /// </param>
        /// <param name="agent">
        /// Agent specific configuration
        /// </param>
        public ConversationConfigClientOverrideOutput(
            global::G.TTSConversationalConfigOverride? tts,
            global::G.ConversationConfigOverride? conversation,
            global::G.AgentConfigOverride? agent)
        {
            this.Tts = tts;
            this.Conversation = conversation;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideOutput" /> class.
        /// </summary>
        public ConversationConfigClientOverrideOutput()
        {
        }
    }
}