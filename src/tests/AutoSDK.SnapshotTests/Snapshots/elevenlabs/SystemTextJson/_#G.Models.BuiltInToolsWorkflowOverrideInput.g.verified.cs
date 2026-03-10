//HintName: G.Models.BuiltInToolsWorkflowOverrideInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuiltInToolsWorkflowOverrideInput
    {
        /// <summary>
        /// The end call tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public global::G.SystemToolConfigInput? EndCall { get; set; }

        /// <summary>
        /// The language detection tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public global::G.SystemToolConfigInput? LanguageDetection { get; set; }

        /// <summary>
        /// The transfer to agent tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_agent")]
        public global::G.SystemToolConfigInput? TransferToAgent { get; set; }

        /// <summary>
        /// The transfer to number tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::G.SystemToolConfigInput? TransferToNumber { get; set; }

        /// <summary>
        /// The skip turn tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_turn")]
        public global::G.SystemToolConfigInput? SkipTurn { get; set; }

        /// <summary>
        /// The play DTMF tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play_keypad_touch_tone")]
        public global::G.SystemToolConfigInput? PlayKeypadTouchTone { get; set; }

        /// <summary>
        /// The voicemail detection tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_detection")]
        public global::G.SystemToolConfigInput? VoicemailDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInToolsWorkflowOverrideInput" /> class.
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
        public BuiltInToolsWorkflowOverrideInput(
            global::G.SystemToolConfigInput? endCall,
            global::G.SystemToolConfigInput? languageDetection,
            global::G.SystemToolConfigInput? transferToAgent,
            global::G.SystemToolConfigInput? transferToNumber,
            global::G.SystemToolConfigInput? skipTurn,
            global::G.SystemToolConfigInput? playKeypadTouchTone,
            global::G.SystemToolConfigInput? voicemailDetection)
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
        /// Initializes a new instance of the <see cref="BuiltInToolsWorkflowOverrideInput" /> class.
        /// </summary>
        public BuiltInToolsWorkflowOverrideInput()
        {
        }
    }
}