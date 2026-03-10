//HintName: G.Models.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch
    {
        /// <summary>
        /// Name to attribute to this speaker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_name")]
        public string? SpeakerName { get; set; }

        /// <summary>
        /// Either the identifier of a voice from the ElevenLabs voice library, or one of ['track-clone', 'clip-clone'].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// For models that support it, the voice similarity value to use. This will default to 0.65, with a valid range of [0.0, 1.0].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_stability")]
        public double? VoiceStability { get; set; }

        /// <summary>
        /// For models that support it, the voice similarity value to use. This will default to 1.0, with a valid range of [0.0, 1.0].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_similarity")]
        public double? VoiceSimilarity { get; set; }

        /// <summary>
        /// For models that support it, the voice style value to use. This will default to 1.0, with a valid range of [0.0, 1.0].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_style")]
        public double? VoiceStyle { get; set; }

        /// <summary>
        /// Languages to apply these changes to. If empty, will apply to all languages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch" /> class.
        /// </summary>
        /// <param name="speakerName">
        /// Name to attribute to this speaker.
        /// </param>
        /// <param name="voiceId">
        /// Either the identifier of a voice from the ElevenLabs voice library, or one of ['track-clone', 'clip-clone'].
        /// </param>
        /// <param name="voiceStability">
        /// For models that support it, the voice similarity value to use. This will default to 0.65, with a valid range of [0.0, 1.0].
        /// </param>
        /// <param name="voiceSimilarity">
        /// For models that support it, the voice similarity value to use. This will default to 1.0, with a valid range of [0.0, 1.0].
        /// </param>
        /// <param name="voiceStyle">
        /// For models that support it, the voice style value to use. This will default to 1.0, with a valid range of [0.0, 1.0].
        /// </param>
        /// <param name="languages">
        /// Languages to apply these changes to. If empty, will apply to all languages.
        /// </param>
        public BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch(
            string? speakerName,
            string? voiceId,
            double? voiceStability,
            double? voiceSimilarity,
            double? voiceStyle,
            global::System.Collections.Generic.IList<string>? languages)
        {
            this.SpeakerName = speakerName;
            this.VoiceId = voiceId;
            this.VoiceStability = voiceStability;
            this.VoiceSimilarity = voiceSimilarity;
            this.VoiceStyle = voiceStyle;
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch" /> class.
        /// </summary>
        public BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch()
        {
        }
    }
}