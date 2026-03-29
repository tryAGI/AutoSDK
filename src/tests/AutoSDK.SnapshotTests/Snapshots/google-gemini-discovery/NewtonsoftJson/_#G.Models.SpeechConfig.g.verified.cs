//HintName: G.Models.SpeechConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config for speech generation and transcription.
    /// </summary>
    public sealed partial class SpeechConfig
    {
        /// <summary>
        /// The configuration for the voice to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceConfig")]
        public global::G.VoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// The configuration for the multi-speaker setup.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multiSpeakerVoiceConfig")]
        public global::G.MultiSpeakerVoiceConfig? MultiSpeakerVoiceConfig { get; set; }

        /// <summary>
        /// Optional. The IETF [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language code that the user configured the app to use. Used for speech recognition and synthesis. Valid values are: `de-DE`, `en-AU`, `en-GB`, `en-IN`, `en-US`, `es-US`, `fr-FR`, `hi-IN`, `pt-BR`, `ar-XA`, `es-ES`, `fr-CA`, `id-ID`, `it-IT`, `ja-JP`, `tr-TR`, `vi-VN`, `bn-IN`, `gu-IN`, `kn-IN`, `ml-IN`, `mr-IN`, `ta-IN`, `te-IN`, `nl-NL`, `ko-KR`, `cmn-CN`, `pl-PL`, `ru-RU`, and `th-TH`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechConfig" /> class.
        /// </summary>
        /// <param name="voiceConfig">
        /// The configuration for the voice to use.
        /// </param>
        /// <param name="multiSpeakerVoiceConfig">
        /// The configuration for the multi-speaker setup.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The IETF [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language code that the user configured the app to use. Used for speech recognition and synthesis. Valid values are: `de-DE`, `en-AU`, `en-GB`, `en-IN`, `en-US`, `es-US`, `fr-FR`, `hi-IN`, `pt-BR`, `ar-XA`, `es-ES`, `fr-CA`, `id-ID`, `it-IT`, `ja-JP`, `tr-TR`, `vi-VN`, `bn-IN`, `gu-IN`, `kn-IN`, `ml-IN`, `mr-IN`, `ta-IN`, `te-IN`, `nl-NL`, `ko-KR`, `cmn-CN`, `pl-PL`, `ru-RU`, and `th-TH`.
        /// </param>
        public SpeechConfig(
            global::G.VoiceConfig? voiceConfig,
            global::G.MultiSpeakerVoiceConfig? multiSpeakerVoiceConfig,
            string? languageCode)
        {
            this.VoiceConfig = voiceConfig;
            this.MultiSpeakerVoiceConfig = multiSpeakerVoiceConfig;
            this.LanguageCode = languageCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechConfig" /> class.
        /// </summary>
        public SpeechConfig()
        {
        }
    }
}