//HintName: G.Models.TranscriptionJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rev.ai Transcription Job
    /// </summary>
    public sealed partial class TranscriptionJob
    {
        /// <summary>
        /// Job ID<br/>
        /// Example: Umx5c6F7pH7r
        /// </summary>
        /// <example>Umx5c6F7pH7r</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Current status of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionJobStatusJsonConverter))]
        public global::G.TranscriptionJobStatus? Status { get; set; }

        /// <summary>
        /// Type of speech recognition performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionJobTypeJsonConverter))]
        public global::G.TranscriptionJobType? Type { get; set; }

        /// <summary>
        /// Job creation timestamp in ISO-8601 UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_on")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Job completion timestamp in ISO-8601 UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_on")]
        public global::System.DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Name of the file provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Media URL provided during submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_url")]
        public string? MediaUrl { get; set; }

        /// <summary>
        /// Optional metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Duration of the file in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Reason for job failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionJobFailureJsonConverter))]
        public global::G.TranscriptionJobFailure? Failure { get; set; }

        /// <summary>
        /// Human-readable failure reason
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_detail")]
        public string? FailureDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_diarization")]
        public bool? SkipDiarization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_punctuation")]
        public bool? SkipPunctuation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_disfluencies")]
        public bool? RemoveDisfluencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_channels_count")]
        public int? SpeakerChannelsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_vocabulary_id")]
        public string? CustomVocabularyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionJob" /> class.
        /// </summary>
        /// <param name="id">
        /// Job ID<br/>
        /// Example: Umx5c6F7pH7r
        /// </param>
        /// <param name="status">
        /// Current status of the job
        /// </param>
        /// <param name="type">
        /// Type of speech recognition performed
        /// </param>
        /// <param name="createdOn">
        /// Job creation timestamp in ISO-8601 UTC
        /// </param>
        /// <param name="completedOn">
        /// Job completion timestamp in ISO-8601 UTC
        /// </param>
        /// <param name="name">
        /// Name of the file provided
        /// </param>
        /// <param name="mediaUrl">
        /// Media URL provided during submission
        /// </param>
        /// <param name="metadata">
        /// Optional metadata
        /// </param>
        /// <param name="callbackUrl"></param>
        /// <param name="language"></param>
        /// <param name="durationSeconds">
        /// Duration of the file in seconds
        /// </param>
        /// <param name="failure">
        /// Reason for job failure
        /// </param>
        /// <param name="failureDetail">
        /// Human-readable failure reason
        /// </param>
        /// <param name="skipDiarization"></param>
        /// <param name="skipPunctuation"></param>
        /// <param name="removeDisfluencies"></param>
        /// <param name="filterProfanity"></param>
        /// <param name="speakerChannelsCount"></param>
        /// <param name="customVocabularyId"></param>
        /// <param name="deleteAfterSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionJob(
            string? id,
            global::G.TranscriptionJobStatus? status,
            global::G.TranscriptionJobType? type,
            global::System.DateTime? createdOn,
            global::System.DateTime? completedOn,
            string? name,
            string? mediaUrl,
            string? metadata,
            string? callbackUrl,
            string? language,
            double? durationSeconds,
            global::G.TranscriptionJobFailure? failure,
            string? failureDetail,
            bool? skipDiarization,
            bool? skipPunctuation,
            bool? removeDisfluencies,
            bool? filterProfanity,
            int? speakerChannelsCount,
            string? customVocabularyId,
            int? deleteAfterSeconds)
        {
            this.Id = id;
            this.Status = status;
            this.Type = type;
            this.CreatedOn = createdOn;
            this.CompletedOn = completedOn;
            this.Name = name;
            this.MediaUrl = mediaUrl;
            this.Metadata = metadata;
            this.CallbackUrl = callbackUrl;
            this.Language = language;
            this.DurationSeconds = durationSeconds;
            this.Failure = failure;
            this.FailureDetail = failureDetail;
            this.SkipDiarization = skipDiarization;
            this.SkipPunctuation = skipPunctuation;
            this.RemoveDisfluencies = removeDisfluencies;
            this.FilterProfanity = filterProfanity;
            this.SpeakerChannelsCount = speakerChannelsCount;
            this.CustomVocabularyId = customVocabularyId;
            this.DeleteAfterSeconds = deleteAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionJob" /> class.
        /// </summary>
        public TranscriptionJob()
        {
        }
    }
}