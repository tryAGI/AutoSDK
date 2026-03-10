//HintName: G.Models.ASRConversationalConfigWorkflowOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}
    /// </summary>
    public sealed partial class ASRConversationalConfigWorkflowOverride
    {
        /// <summary>
        /// The quality of the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public global::G.ASRQuality? Quality { get; set; }

        /// <summary>
        /// The provider of the transcription service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::G.ASRProvider? Provider { get; set; }

        /// <summary>
        /// The format of the audio to be transcribed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_input_audio_format")]
        public global::G.ASRInputFormat? UserInputAudioFormat { get; set; }

        /// <summary>
        /// Keywords to boost prediction probability for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="quality">
        /// The quality of the transcription
        /// </param>
        /// <param name="provider">
        /// The provider of the transcription service
        /// </param>
        /// <param name="userInputAudioFormat">
        /// The format of the audio to be transcribed
        /// </param>
        /// <param name="keywords">
        /// Keywords to boost prediction probability for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASRConversationalConfigWorkflowOverride(
            global::G.ASRQuality? quality,
            global::G.ASRProvider? provider,
            global::G.ASRInputFormat? userInputAudioFormat,
            global::System.Collections.Generic.IList<string>? keywords)
        {
            this.Quality = quality;
            this.Provider = provider;
            this.UserInputAudioFormat = userInputAudioFormat;
            this.Keywords = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfigWorkflowOverride" /> class.
        /// </summary>
        public ASRConversationalConfigWorkflowOverride()
        {
        }
    }
}