//HintName: G.Models.SpeakerSeparationResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"sample_id":"DCwhRBWXzGAHq8TQ4Fs18","status":"not_started","voice_id":"DCwhRBWXzGAHq8TQ4Fs18"}
    /// </summary>
    public sealed partial class SpeakerSeparationResponseModel
    {
        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SampleId { get; set; } = default!;

        /// <summary>
        /// The status of the speaker separation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpeakerSeparationResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// The speakers of the sample.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speakers")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SpeakerResponseModel>? Speakers { get; set; }

        /// <summary>
        /// The IDs of the selected speakers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_speaker_ids")]
        public global::System.Collections.Generic.IList<string>? SelectedSpeakerIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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