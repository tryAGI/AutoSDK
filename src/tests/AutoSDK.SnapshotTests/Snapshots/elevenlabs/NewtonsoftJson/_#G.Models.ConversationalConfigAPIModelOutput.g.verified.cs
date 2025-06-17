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
        [global::Newtonsoft.Json.JsonProperty("asr")]
        public global::G.ASRConversationalConfig? Asr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn")]
        public global::G.TurnConfig? Turn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts")]
        public global::G.TTSConversationalConfigOutput? Tts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation")]
        public global::G.ConversationConfig? Conversation { get; set; }

        /// <summary>
        /// Language presets for conversations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_presets")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LanguagePresetOutput>? LanguagePresets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::G.AgentConfigAPIModelOutput? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public ConversationalConfigAPIModelOutput(
            global::G.ASRConversationalConfig? asr,
            global::G.TurnConfig? turn,
            global::G.TTSConversationalConfigOutput? tts,
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