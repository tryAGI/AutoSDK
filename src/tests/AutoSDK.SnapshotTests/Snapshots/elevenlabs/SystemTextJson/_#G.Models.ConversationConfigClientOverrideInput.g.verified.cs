//HintName: G.Models.ConversationConfigClientOverrideInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}
    /// </summary>
    public sealed partial class ConversationConfigClientOverrideInput
    {
        /// <summary>
        /// Configuration for turn detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::G.TurnConfigOverride? Turn { get; set; }

        /// <summary>
        /// Configuration for conversational text to speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::G.TTSConversationalConfigOverride? Tts { get; set; }

        /// <summary>
        /// Configuration for conversational events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::G.ConversationConfigOverride? Conversation { get; set; }

        /// <summary>
        /// Agent specific configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::G.AgentConfigOverrideInput? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideInput" /> class.
        /// </summary>
        /// <param name="turn">
        /// Configuration for turn detection
        /// </param>
        /// <param name="tts">
        /// Configuration for conversational text to speech
        /// </param>
        /// <param name="conversation">
        /// Configuration for conversational events
        /// </param>
        /// <param name="agent">
        /// Agent specific configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConfigClientOverrideInput(
            global::G.TurnConfigOverride? turn,
            global::G.TTSConversationalConfigOverride? tts,
            global::G.ConversationConfigOverride? conversation,
            global::G.AgentConfigOverrideInput? agent)
        {
            this.Turn = turn;
            this.Tts = tts;
            this.Conversation = conversation;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideInput" /> class.
        /// </summary>
        public ConversationConfigClientOverrideInput()
        {
        }
    }
}