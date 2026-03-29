//HintName: G.Models.ConversationProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationProperties
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_call_duration")]
        public int? MaxCallDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("participant_left_timeout")]
        public int? ParticipantLeftTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("participant_absent_timeout")]
        public int? ParticipantAbsentTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_recording")]
        public bool? EnableRecording { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_closed_captions")]
        public bool? EnableClosedCaptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_greenscreen")]
        public bool? ApplyGreenscreen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recording_s3_bucket_region")]
        public string? RecordingS3BucketRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recording_s3_bucket_name")]
        public string? RecordingS3BucketName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationProperties" /> class.
        /// </summary>
        /// <param name="maxCallDuration"></param>
        /// <param name="participantLeftTimeout"></param>
        /// <param name="participantAbsentTimeout"></param>
        /// <param name="enableRecording"></param>
        /// <param name="enableClosedCaptions"></param>
        /// <param name="applyGreenscreen"></param>
        /// <param name="language"></param>
        /// <param name="recordingS3BucketRegion"></param>
        /// <param name="recordingS3BucketName"></param>
        public ConversationProperties(
            int? maxCallDuration,
            int? participantLeftTimeout,
            int? participantAbsentTimeout,
            bool? enableRecording,
            bool? enableClosedCaptions,
            bool? applyGreenscreen,
            string? language,
            string? recordingS3BucketRegion,
            string? recordingS3BucketName)
        {
            this.MaxCallDuration = maxCallDuration;
            this.ParticipantLeftTimeout = participantLeftTimeout;
            this.ParticipantAbsentTimeout = participantAbsentTimeout;
            this.EnableRecording = enableRecording;
            this.EnableClosedCaptions = enableClosedCaptions;
            this.ApplyGreenscreen = applyGreenscreen;
            this.Language = language;
            this.RecordingS3BucketRegion = recordingS3BucketRegion;
            this.RecordingS3BucketName = recordingS3BucketName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationProperties" /> class.
        /// </summary>
        public ConversationProperties()
        {
        }
    }
}