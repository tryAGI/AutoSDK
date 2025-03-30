//HintName: G.Models.ConversationalConfigAPIModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationalConfigAPIModelOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::G.ASRConversationalConfig? Asr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::G.TurnConfig? Turn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::G.TTSConversationalConfig? Tts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::G.ConversationConfig? Conversation { get; set; }

        /// <summary>
        /// Language presets for conversations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_presets")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LanguagePresetOutput>? LanguagePresets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::G.AgentConfigAPIModelOutput? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfigAPIModelOutput" /> class.
        /// </summary>
        /// <param name="asr"></param>
        /// <param name="turn"></param>
        /// <param name="tts"></param>
        /// <param name="conversation"></param>
        /// <param name="languagePresets">
        /// Language presets for conversations
        /// </param>
        /// <param name="agent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationalConfigAPIModelOutput(
            global::G.ASRConversationalConfig? asr,
            global::G.TurnConfig? turn,
            global::G.TTSConversationalConfig? tts,
            global::G.ConversationConfig? conversation,
            global::System.Collections.Generic.Dictionary<string, global::G.LanguagePresetOutput>? languagePresets,
            global::G.AgentConfigAPIModelOutput? agent)
        {
            this.Asr = asr;
            this.Turn = turn;
            this.Tts = tts;
            this.Conversation = conversation;
            this.LanguagePresets = languagePresets;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalConfigAPIModelOutput" /> class.
        /// </summary>
        public ConversationalConfigAPIModelOutput()
        {
        }
    }
}