//HintName: G.Models.TranscriptionConfigSpeakerDiarizationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for speaker diarization
    /// </summary>
    public sealed partial class TranscriptionConfigSpeakerDiarizationConfig
    {
        /// <summary>
        /// If true, the algorithm will prefer to stay with the current active speaker if it is a close enough match, even if other speakers may be closer.  This is useful for cases where we can flip incorrectly between similar speakers during a single speaker section."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefer_current_speaker")]
        public bool? PreferCurrentSpeaker { get; set; }

        /// <summary>
        /// Controls how sensitive the algorithm is in terms of keeping similar speakers separate, as opposed to combining them into a single speaker.  Higher values will typically lead to more speakers, as the degree of difference between speakers in order to allow them to remain distinct will be lower.  A lower value for this parameter will conversely guide the algorithm towards being less sensitive in terms of retaining similar speakers, and as such may lead to fewer speakers overall.  The default is 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_sensitivity")]
        public float? SpeakerSensitivity { get; set; }

        /// <summary>
        /// If true, speaker identifiers will be returned at the end of transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get_speakers")]
        public bool? GetSpeakers { get; set; }

        /// <summary>
        /// Use this option to provide speaker labels linked to their speaker identifiers. When passed, the transcription system will tag spoken words in the transcript with the provided speaker labels whenever any of the specified speakers is detected in the audio. A maximum of 50 speakers identifiers across all speakers can be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers")]
        public global::System.Collections.Generic.IList<global::G.SpeakersInputItem>? Speakers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigSpeakerDiarizationConfig" /> class.
        /// </summary>
        /// <param name="preferCurrentSpeaker">
        /// If true, the algorithm will prefer to stay with the current active speaker if it is a close enough match, even if other speakers may be closer.  This is useful for cases where we can flip incorrectly between similar speakers during a single speaker section."
        /// </param>
        /// <param name="speakerSensitivity">
        /// Controls how sensitive the algorithm is in terms of keeping similar speakers separate, as opposed to combining them into a single speaker.  Higher values will typically lead to more speakers, as the degree of difference between speakers in order to allow them to remain distinct will be lower.  A lower value for this parameter will conversely guide the algorithm towards being less sensitive in terms of retaining similar speakers, and as such may lead to fewer speakers overall.  The default is 0.5.
        /// </param>
        /// <param name="getSpeakers">
        /// If true, speaker identifiers will be returned at the end of transcript.
        /// </param>
        /// <param name="speakers">
        /// Use this option to provide speaker labels linked to their speaker identifiers. When passed, the transcription system will tag spoken words in the transcript with the provided speaker labels whenever any of the specified speakers is detected in the audio. A maximum of 50 speakers identifiers across all speakers can be provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionConfigSpeakerDiarizationConfig(
            bool? preferCurrentSpeaker,
            float? speakerSensitivity,
            bool? getSpeakers,
            global::System.Collections.Generic.IList<global::G.SpeakersInputItem>? speakers)
        {
            this.PreferCurrentSpeaker = preferCurrentSpeaker;
            this.SpeakerSensitivity = speakerSensitivity;
            this.GetSpeakers = getSpeakers;
            this.Speakers = speakers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigSpeakerDiarizationConfig" /> class.
        /// </summary>
        public TranscriptionConfigSpeakerDiarizationConfig()
        {
        }
    }
}