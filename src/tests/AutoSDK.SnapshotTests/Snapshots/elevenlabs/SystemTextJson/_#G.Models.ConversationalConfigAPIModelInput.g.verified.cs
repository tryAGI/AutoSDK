//HintName: G.Models.ConversationalConfigAPIModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationalConfigAPIModelInput
    {
        /// <summary>
        /// Configuration for conversational transcription<br/>
        /// Example: {"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}
        /// </summary>
        /// <example>{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::G.ASRConversationalConfig? Asr { get; set; }

        /// <summary>
        /// Configuration for turn detection<br/>
        /// Example: {"mode":"turn","silence_end_call_timeout":-1,"turn_timeout":7}
        /// </summary>
        /// <example>{"mode":"turn","silence_end_call_timeout":-1,"turn_timeout":7}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::G.TurnConfig? Turn { get; set; }

        /// <summary>
        /// Configuration for conversational text to speech<br/>
        /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
        /// </summary>
        /// <example>{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::G.TTSConversationalConfigInput? Tts { get; set; }

        /// <summary>
        /// Configuration for conversational events<br/>
        /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
        /// </summary>
        /// <example>{"client_events":["audio","interruption"],"max_duration_seconds":600}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::G.ConversationConfig? Conversation { get; set; }

        /// <summary>
        /// Language presets for conversations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_presets")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LanguagePresetInput>? LanguagePresets { get; set; }

        /// <summary>
        /// Agent specific configuration<br/>
        /// Example: {"first_message":"Hello, how can I help you today?","language":"en"}
        /// </summary>
        /// <example>{"first_message":"Hello, how can I help you today?","language":"en"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::G.AgentConfigAPIModelInput? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfigAPIModelInput" /> class.
        /// </summary>
        /// <param name="asr">
        /// Configuration for conversational transcription<br/>
        /// Example: {"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}
        /// </param>
        /// <param name="turn">
        /// Configuration for turn detection<br/>
        /// Example: {"mode":"turn","silence_end_call_timeout":-1,"turn_timeout":7}
        /// </param>
        /// <param name="tts">
        /// Configuration for conversational text to speech<br/>
        /// Example: {"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"}
        /// </param>
        /// <param name="conversation">
        /// Configuration for conversational events<br/>
        /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
        /// </param>
        /// <param name="languagePresets">
        /// Language presets for conversations
        /// </param>
        /// <param name="agent">
        /// Agent specific configuration<br/>
        /// Example: {"first_message":"Hello, how can I help you today?","language":"en"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationalConfigAPIModelInput(
            global::G.ASRConversationalConfig? asr,
            global::G.TurnConfig? turn,
            global::G.TTSConversationalConfigInput? tts,
            global::G.ConversationConfig? conversation,
            global::System.Collections.Generic.Dictionary<string, global::G.LanguagePresetInput>? languagePresets,
            global::G.AgentConfigAPIModelInput? agent)
        {
            this.Asr = asr;
            this.Turn = turn;
            this.Tts = tts;
            this.Conversation = conversation;
            this.LanguagePresets = languagePresets;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfigAPIModelInput" /> class.
        /// </summary>
        public ConversationalConfigAPIModelInput()
        {
        }
    }
}