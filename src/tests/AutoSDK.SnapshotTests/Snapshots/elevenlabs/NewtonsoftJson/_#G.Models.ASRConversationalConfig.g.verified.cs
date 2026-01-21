//HintName: G.Models.ASRConversationalConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"}
    /// </summary>
    public sealed partial class ASRConversationalConfig
    {
        /// <summary>
        /// The quality of the transcription<br/>
        /// Default Value: high
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality")]
        public global::G.ASRQuality? Quality { get; set; }

        /// <summary>
        /// The provider of the transcription service<br/>
        /// Default Value: elevenlabs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.ASRProvider? Provider { get; set; }

        /// <summary>
        /// The format of the audio to be transcribed<br/>
        /// Default Value: pcm_16000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_input_audio_format")]
        public global::G.ASRInputFormat? UserInputAudioFormat { get; set; }

        /// <summary>
        /// Keywords to boost prediction probability for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASRConversationalConfig" /> class.
        /// </summary>
        /// <param name="quality">
        /// The quality of the transcription<br/>
        /// Default Value: high
        /// </param>
        /// <param name="provider">
        /// The provider of the transcription service<br/>
        /// Default Value: elevenlabs
        /// </param>
        /// <param name="userInputAudioFormat">
        /// The format of the audio to be transcribed<br/>
        /// Default Value: pcm_16000
        /// </param>
        /// <param name="keywords">
        /// Keywords to boost prediction probability for
        /// </param>
        public ASRConversationalConfig(
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
        /// Initializes a new instance of the <see cref="ASRConversationalConfig" /> class.
        /// </summary>
        public ASRConversationalConfig()
        {
        }
    }
}