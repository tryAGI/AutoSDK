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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SampleId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpeakerSeparationResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speakers")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SpeakerResponseModel>? Speakers { get; set; }

        /// <summary>
        /// 
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
        /// <param name="voiceId"></param>
        /// <param name="sampleId"></param>
        /// <param name="status"></param>
        /// <param name="speakers"></param>
        /// <param name="selectedSpeakerIds"></param>
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