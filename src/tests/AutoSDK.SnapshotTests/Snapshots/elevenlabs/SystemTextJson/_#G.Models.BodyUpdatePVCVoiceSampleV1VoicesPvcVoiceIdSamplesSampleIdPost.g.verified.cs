//HintName: G.Models.BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost
    {
        /// <summary>
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// Speaker IDs to be used for PVC training. Make sure you send all the speaker IDs you want to use for PVC training in one request because the last request will override the previous ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_speaker_ids")]
        public global::System.Collections.Generic.IList<string>? SelectedSpeakerIds { get; set; }

        /// <summary>
        /// The start time of the audio to be used for PVC training. Time should be in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_start_time")]
        public int? TrimStartTime { get; set; }

        /// <summary>
        /// The end time of the audio to be used for PVC training. Time should be in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_end_time")]
        public int? TrimEndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost" /> class.
        /// </summary>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="selectedSpeakerIds">
        /// Speaker IDs to be used for PVC training. Make sure you send all the speaker IDs you want to use for PVC training in one request because the last request will override the previous ones.
        /// </param>
        /// <param name="trimStartTime">
        /// The start time of the audio to be used for PVC training. Time should be in milliseconds
        /// </param>
        /// <param name="trimEndTime">
        /// The end time of the audio to be used for PVC training. Time should be in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost(
            bool? removeBackgroundNoise,
            global::System.Collections.Generic.IList<string>? selectedSpeakerIds,
            int? trimStartTime,
            int? trimEndTime)
        {
            this.RemoveBackgroundNoise = removeBackgroundNoise;
            this.SelectedSpeakerIds = selectedSpeakerIds;
            this.TrimStartTime = trimStartTime;
            this.TrimEndTime = trimEndTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost" /> class.
        /// </summary>
        public BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost()
        {
        }
    }
}