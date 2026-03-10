//HintName: G.Models.ConversationalConfigAPIModelWorkflowOverrideInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"agent":{"disable_first_message_interruptions":false,"dynamic_variables":{"dynamic_variable_placeholders":{"user_name":"John Doe"}},"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}},"asr":{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"},"conversation":{"client_events":["audio","interruption"],"max_duration_seconds":600},"tts":{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"mode":"turn","silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0},"vad":{"background_voice_detection":false}}
    /// </summary>
    public sealed partial class ConversationalConfigAPIModelWorkflowOverrideInput
    {
        /// <summary>
        /// Configuration for conversational transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::G.ASRConversationalConfigWorkflowOverride? Asr { get; set; }

        /// <summary>
        /// Configuration for turn detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::G.TurnConfigWorkflowOverride? Turn { get; set; }

        /// <summary>
        /// Configuration for conversational text to speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::G.TTSConversationalConfigWorkflowOverrideInput? Tts { get; set; }

        /// <summary>
        /// Configuration for conversational events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::G.ConversationConfigWorkflowOverride? Conversation { get; set; }

        /// <summary>
        /// Language presets for conversations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_presets")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LanguagePresetInput>? LanguagePresets { get; set; }

        /// <summary>
        /// Configuration for voice activity detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad")]
        public global::G.VADConfigWorkflowOverride? Vad { get; set; }

        /// <summary>
        /// Agent specific configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::G.AgentConfigAPIModelWorkflowOverrideInput? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfigAPIModelWorkflowOverrideInput" /> class.
        /// </summary>
        /// <param name="asr">
        /// Configuration for conversational transcription
        /// </param>
        /// <param name="turn">
        /// Configuration for turn detection
        /// </param>
        /// <param name="tts">
        /// Configuration for conversational text to speech
        /// </param>
        /// <param name="conversation">
        /// Configuration for conversational events
        /// </param>
        /// <param name="languagePresets">
        /// Language presets for conversations
        /// </param>
        /// <param name="vad">
        /// Configuration for voice activity detection
        /// </param>
        /// <param name="agent">
        /// Agent specific configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationalConfigAPIModelWorkflowOverrideInput(
            global::G.ASRConversationalConfigWorkflowOverride? asr,
            global::G.TurnConfigWorkflowOverride? turn,
            global::G.TTSConversationalConfigWorkflowOverrideInput? tts,
            global::G.ConversationConfigWorkflowOverride? conversation,
            global::System.Collections.Generic.Dictionary<string, global::G.LanguagePresetInput>? languagePresets,
            global::G.VADConfigWorkflowOverride? vad,
            global::G.AgentConfigAPIModelWorkflowOverrideInput? agent)
        {
            this.Asr = asr;
            this.Turn = turn;
            this.Tts = tts;
            this.Conversation = conversation;
            this.LanguagePresets = languagePresets;
            this.Vad = vad;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfigAPIModelWorkflowOverrideInput" /> class.
        /// </summary>
        public ConversationalConfigAPIModelWorkflowOverrideInput()
        {
        }
    }
}