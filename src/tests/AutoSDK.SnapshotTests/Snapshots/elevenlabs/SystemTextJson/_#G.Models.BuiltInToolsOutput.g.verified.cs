//HintName: G.Models.BuiltInToolsOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuiltInToolsOutput
    {
        /// <summary>
        /// The end call tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public global::G.SystemToolConfigOutput? EndCall { get; set; }

        /// <summary>
        /// The language detection tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public global::G.SystemToolConfigOutput? LanguageDetection { get; set; }

        /// <summary>
        /// The transfer to agent tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_agent")]
        public global::G.SystemToolConfigOutput? TransferToAgent { get; set; }

        /// <summary>
        /// The transfer to number tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::G.SystemToolConfigOutput? TransferToNumber { get; set; }

        /// <summary>
        /// The skip turn tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_turn")]
        public global::G.SystemToolConfigOutput? SkipTurn { get; set; }

        /// <summary>
        /// The play DTMF tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play_keypad_touch_tone")]
        public global::G.SystemToolConfigOutput? PlayKeypadTouchTone { get; set; }

        /// <summary>
        /// The voicemail detection tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_detection")]
        public global::G.SystemToolConfigOutput? VoicemailDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInToolsOutput" /> class.
        /// </summary>
        /// <param name="endCall">
        /// The end call tool
        /// </param>
        /// <param name="languageDetection">
        /// The language detection tool
        /// </param>
        /// <param name="transferToAgent">
        /// The transfer to agent tool
        /// </param>
        /// <param name="transferToNumber">
        /// The transfer to number tool
        /// </param>
        /// <param name="skipTurn">
        /// The skip turn tool
        /// </param>
        /// <param name="playKeypadTouchTone">
        /// The play DTMF tool
        /// </param>
        /// <param name="voicemailDetection">
        /// The voicemail detection tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltInToolsOutput(
            global::G.SystemToolConfigOutput? endCall,
            global::G.SystemToolConfigOutput? languageDetection,
            global::G.SystemToolConfigOutput? transferToAgent,
            global::G.SystemToolConfigOutput? transferToNumber,
            global::G.SystemToolConfigOutput? skipTurn,
            global::G.SystemToolConfigOutput? playKeypadTouchTone,
            global::G.SystemToolConfigOutput? voicemailDetection)
        {
            this.EndCall = endCall;
            this.LanguageDetection = languageDetection;
            this.TransferToAgent = transferToAgent;
            this.TransferToNumber = transferToNumber;
            this.SkipTurn = skipTurn;
            this.PlayKeypadTouchTone = playKeypadTouchTone;
            this.VoicemailDetection = voicemailDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInToolsOutput" /> class.
        /// </summary>
        public BuiltInToolsOutput()
        {
        }
    }
}