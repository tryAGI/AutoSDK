//HintName: G.Models.CreateConversationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConversationRequest
    {
        /// <summary>
        /// The identifier of the persona to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persona_id")]
        public string? PersonaId { get; set; }

        /// <summary>
        /// The identifier of the replica. Required if persona has no default replica.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replica_id")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// URL to receive webhook callbacks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional context for the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversational_context")]
        public string? ConversationalContext { get; set; }

        /// <summary>
        /// Custom greeting message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_greeting")]
        public string? CustomGreeting { get; set; }

        /// <summary>
        /// Conversation language or "multilingual" for auto-detection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Start in audio-only mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_only")]
        public bool? AudioOnly { get; set; }

        /// <summary>
        /// Maximum call length in seconds (max 3600).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_call_duration")]
        public int? MaxCallDuration { get; set; }

        /// <summary>
        /// Timeout if no participant joins.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_timeout")]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// Timeout after last participant leaves.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("participant_left_timeout")]
        public int? ParticipantLeftTimeout { get; set; }

        /// <summary>
        /// Enable closed captions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_closed_captions")]
        public bool? EnableClosedCaptions { get; set; }

        /// <summary>
        /// Create a private conversation requiring a meeting token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Maximum number of participants.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_participant_count")]
        public int? MaxParticipantCount { get; set; }

        /// <summary>
        /// Apply green screen effect.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_greenscreen")]
        public bool? ApplyGreenscreen { get; set; }

        /// <summary>
        /// Website URL for background.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_url")]
        public string? BackgroundUrl { get; set; }

        /// <summary>
        /// Image URL for background.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_image_url")]
        public string? BackgroundImageUrl { get; set; }

        /// <summary>
        /// Memory store identifiers for cross-conversation memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_stores")]
        public global::System.Collections.Generic.IList<string>? MemoryStores { get; set; }

        /// <summary>
        /// Enable conversation recording.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_recording")]
        public bool? EnableRecording { get; set; }

        /// <summary>
        /// AWS S3 bucket region for recordings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recording_s3_bucket_region")]
        public string? RecordingS3BucketRegion { get; set; }

        /// <summary>
        /// AWS S3 bucket name for recordings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recording_s3_bucket_name")]
        public string? RecordingS3BucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::G.ConversationProperties? Properties { get; set; }

        /// <summary>
        /// Knowledge base document IDs to make available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_ids")]
        public global::System.Collections.Generic.IList<string>? DocumentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationRequest" /> class.
        /// </summary>
        /// <param name="personaId">
        /// The identifier of the persona to use.
        /// </param>
        /// <param name="replicaId">
        /// The identifier of the replica. Required if persona has no default replica.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callbacks.
        /// </param>
        /// <param name="conversationalContext">
        /// Additional context for the LLM.
        /// </param>
        /// <param name="customGreeting">
        /// Custom greeting message.
        /// </param>
        /// <param name="language">
        /// Conversation language or "multilingual" for auto-detection.
        /// </param>
        /// <param name="audioOnly">
        /// Start in audio-only mode.
        /// </param>
        /// <param name="maxCallDuration">
        /// Maximum call length in seconds (max 3600).
        /// </param>
        /// <param name="idleTimeout">
        /// Timeout if no participant joins.
        /// </param>
        /// <param name="participantLeftTimeout">
        /// Timeout after last participant leaves.
        /// </param>
        /// <param name="enableClosedCaptions">
        /// Enable closed captions.
        /// </param>
        /// <param name="isPrivate">
        /// Create a private conversation requiring a meeting token.
        /// </param>
        /// <param name="maxParticipantCount">
        /// Maximum number of participants.
        /// </param>
        /// <param name="applyGreenscreen">
        /// Apply green screen effect.
        /// </param>
        /// <param name="backgroundUrl">
        /// Website URL for background.
        /// </param>
        /// <param name="backgroundImageUrl">
        /// Image URL for background.
        /// </param>
        /// <param name="memoryStores">
        /// Memory store identifiers for cross-conversation memory.
        /// </param>
        /// <param name="enableRecording">
        /// Enable conversation recording.
        /// </param>
        /// <param name="recordingS3BucketRegion">
        /// AWS S3 bucket region for recordings.
        /// </param>
        /// <param name="recordingS3BucketName">
        /// AWS S3 bucket name for recordings.
        /// </param>
        /// <param name="properties"></param>
        /// <param name="documentIds">
        /// Knowledge base document IDs to make available.
        /// </param>
        public CreateConversationRequest(
            string? personaId,
            string? replicaId,
            string? callbackUrl,
            string? conversationalContext,
            string? customGreeting,
            string? language,
            bool? audioOnly,
            int? maxCallDuration,
            int? idleTimeout,
            int? participantLeftTimeout,
            bool? enableClosedCaptions,
            bool? isPrivate,
            int? maxParticipantCount,
            bool? applyGreenscreen,
            string? backgroundUrl,
            string? backgroundImageUrl,
            global::System.Collections.Generic.IList<string>? memoryStores,
            bool? enableRecording,
            string? recordingS3BucketRegion,
            string? recordingS3BucketName,
            global::G.ConversationProperties? properties,
            global::System.Collections.Generic.IList<string>? documentIds)
        {
            this.PersonaId = personaId;
            this.ReplicaId = replicaId;
            this.CallbackUrl = callbackUrl;
            this.ConversationalContext = conversationalContext;
            this.CustomGreeting = customGreeting;
            this.Language = language;
            this.AudioOnly = audioOnly;
            this.MaxCallDuration = maxCallDuration;
            this.IdleTimeout = idleTimeout;
            this.ParticipantLeftTimeout = participantLeftTimeout;
            this.EnableClosedCaptions = enableClosedCaptions;
            this.IsPrivate = isPrivate;
            this.MaxParticipantCount = maxParticipantCount;
            this.ApplyGreenscreen = applyGreenscreen;
            this.BackgroundUrl = backgroundUrl;
            this.BackgroundImageUrl = backgroundImageUrl;
            this.MemoryStores = memoryStores;
            this.EnableRecording = enableRecording;
            this.RecordingS3BucketRegion = recordingS3BucketRegion;
            this.RecordingS3BucketName = recordingS3BucketName;
            this.Properties = properties;
            this.DocumentIds = documentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationRequest" /> class.
        /// </summary>
        public CreateConversationRequest()
        {
        }
    }
}