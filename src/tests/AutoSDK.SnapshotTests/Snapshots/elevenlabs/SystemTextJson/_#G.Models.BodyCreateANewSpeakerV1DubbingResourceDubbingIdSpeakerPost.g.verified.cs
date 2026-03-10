//HintName: G.Models.BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost
    {
        /// <summary>
        /// Name to attribute to this speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_name")]
        public string? SpeakerName { get; set; }

        /// <summary>
        /// Either the identifier of a voice from the ElevenLabs voice library, or one of ['track-clone', 'clip-clone'].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// For models that support it, the voice similarity value to use. This will default to 0.65, with a valid range of [0.0, 1.0].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_stability")]
        public double? VoiceStability { get; set; }

        /// <summary>
        /// For models that support it, the voice similarity value to use. This will default to 1.0, with a valid range of [0.0, 1.0].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_similarity")]
        public double? VoiceSimilarity { get; set; }

        /// <summary>
        /// For models that support it, the voice style value to use. This will default to 1.0, with a valid range of [0.0, 1.0].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_style")]
        public double? VoiceStyle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost(
            string? speakerName,
            string? voiceId,
            double? voiceStability,
            double? voiceSimilarity,
            double? voiceStyle)
        {
            this.SpeakerName = speakerName;
            this.VoiceId = voiceId;
            this.VoiceStability = voiceStability;
            this.VoiceSimilarity = voiceSimilarity;
            this.VoiceStyle = voiceStyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost" /> class.
        /// </summary>
        public BodyCreateANewSpeakerV1DubbingResourceDubbingIdSpeakerPost()
        {
        }
    }
}