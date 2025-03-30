//HintName: G.Models.ConversationDeletionSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationDeletionSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletion_time_unix_secs")]
        public int? DeletionTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_logs_at_time_unix_secs")]
        public int? DeletedLogsAtTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_audio_at_time_unix_secs")]
        public int? DeletedAudioAtTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_transcript_at_time_unix_secs")]
        public int? DeletedTranscriptAtTimeUnixSecs { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_transcript_and_pii")]
        public bool? DeleteTranscriptAndPii { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_audio")]
        public bool? DeleteAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDeletionSettings" /> class.
        /// </summary>
        /// <param name="deletionTimeUnixSecs"></param>
        /// <param name="deletedLogsAtTimeUnixSecs"></param>
        /// <param name="deletedAudioAtTimeUnixSecs"></param>
        /// <param name="deletedTranscriptAtTimeUnixSecs"></param>
        /// <param name="deleteTranscriptAndPii">
        /// Default Value: false
        /// </param>
        /// <param name="deleteAudio">
        /// Default Value: false
        /// </param>
        public ConversationDeletionSettings(
            int? deletionTimeUnixSecs,
            int? deletedLogsAtTimeUnixSecs,
            int? deletedAudioAtTimeUnixSecs,
            int? deletedTranscriptAtTimeUnixSecs,
            bool? deleteTranscriptAndPii,
            bool? deleteAudio)
        {
            this.DeletionTimeUnixSecs = deletionTimeUnixSecs;
            this.DeletedLogsAtTimeUnixSecs = deletedLogsAtTimeUnixSecs;
            this.DeletedAudioAtTimeUnixSecs = deletedAudioAtTimeUnixSecs;
            this.DeletedTranscriptAtTimeUnixSecs = deletedTranscriptAtTimeUnixSecs;
            this.DeleteTranscriptAndPii = deleteTranscriptAndPii;
            this.DeleteAudio = deleteAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDeletionSettings" /> class.
        /// </summary>
        public ConversationDeletionSettings()
        {
        }
    }
}