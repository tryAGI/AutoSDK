//HintName: G.Models.SpeakerSeparationResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakerSeparationResponseModel
    {
        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SampleId { get; set; }

        /// <summary>
        /// The status of the speaker separation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpeakerSeparationResponseModelStatus Status { get; set; }

        /// <summary>
        /// The speakers of the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SpeakerResponseModel>? Speakers { get; set; }

        /// <summary>
        /// The IDs of the selected speakers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_speaker_ids")]
        public global::System.Collections.Generic.IList<string>? SelectedSpeakerIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerSeparationResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice.
        /// </param>
        /// <param name="sampleId">
        /// The ID of the sample.
        /// </param>
        /// <param name="status">
        /// The status of the speaker separation.
        /// </param>
        /// <param name="speakers">
        /// The speakers of the sample.
        /// </param>
        /// <param name="selectedSpeakerIds">
        /// The IDs of the selected speakers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerSeparationResponseModel(
            string voiceId,
            string sampleId,
            global::G.SpeakerSeparationResponseModelStatus status,
            global::System.Collections.Generic.Dictionary<string, global::G.SpeakerResponseModel>? speakers,
            global::System.Collections.Generic.IList<string>? selectedSpeakerIds)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.SampleId = sampleId ?? throw new global::System.ArgumentNullException(nameof(sampleId));
            this.Status = status;
            this.Speakers = speakers;
            this.SelectedSpeakerIds = selectedSpeakerIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerSeparationResponseModel" /> class.
        /// </summary>
        public SpeakerSeparationResponseModel()
        {
        }
    }
}