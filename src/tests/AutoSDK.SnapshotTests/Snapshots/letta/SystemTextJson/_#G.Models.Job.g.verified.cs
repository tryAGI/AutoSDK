//HintName: G.Models.Job.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of offline jobs, used for tracking status of data loading tasks (involving parsing and embedding files).
    /// </summary>
    public sealed partial class Job
    {
        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The unix timestamp of when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The status of the job.<br/>
        /// Default Value: created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobStatusJsonConverter))]
        public global::G.JobStatus? Status { get; set; }

        /// <summary>
        /// The unix timestamp of when the job was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The reason why the job was stopped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        public global::G.StopReasonType? StopReason { get; set; }

        /// <summary>
        /// The metadata of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The type of the job.<br/>
        /// Default Value: job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobTypeJsonConverter))]
        public global::G.JobType? JobType { get; set; }

        /// <summary>
        /// Whether the job was created in background mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// The agent associated with this job/run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// If set, POST to this URL when the job completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Timestamp when the callback was last attempted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_sent_at")]
        public global::System.DateTime? CallbackSentAt { get; set; }

        /// <summary>
        /// HTTP status code returned by the callback endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_status_code")]
        public int? CallbackStatusCode { get; set; }

        /// <summary>
        /// Optional error message from attempting to POST the callback endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_error")]
        public string? CallbackError { get; set; }

        /// <summary>
        /// Time to first token for a run in nanoseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft_ns")]
        public long? TtftNs { get; set; }

        /// <summary>
        /// Total run duration in nanoseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ns")]
        public long? TotalDurationNs { get; set; }

        /// <summary>
        /// The human-friendly ID of the Job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="createdById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="createdAt">
        /// The unix timestamp of when the job was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the object was last updated.
        /// </param>
        /// <param name="status">
        /// The status of the job.<br/>
        /// Default Value: created
        /// </param>
        /// <param name="completedAt">
        /// The unix timestamp of when the job was completed.
        /// </param>
        /// <param name="stopReason">
        /// The reason why the job was stopped.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the job.
        /// </param>
        /// <param name="jobType">
        /// The type of the job.<br/>
        /// Default Value: job
        /// </param>
        /// <param name="background">
        /// Whether the job was created in background mode.
        /// </param>
        /// <param name="agentId">
        /// The agent associated with this job/run.
        /// </param>
        /// <param name="callbackUrl">
        /// If set, POST to this URL when the job completes.
        /// </param>
        /// <param name="callbackSentAt">
        /// Timestamp when the callback was last attempted.
        /// </param>
        /// <param name="callbackStatusCode">
        /// HTTP status code returned by the callback endpoint.
        /// </param>
        /// <param name="callbackError">
        /// Optional error message from attempting to POST the callback endpoint.
        /// </param>
        /// <param name="ttftNs">
        /// Time to first token for a run in nanoseconds
        /// </param>
        /// <param name="totalDurationNs">
        /// Total run duration in nanoseconds
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Job(
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::G.JobStatus? status,
            global::System.DateTime? completedAt,
            global::G.StopReasonType? stopReason,
            object? metadata,
            global::G.JobType? jobType,
            bool? background,
            string? agentId,
            string? callbackUrl,
            global::System.DateTime? callbackSentAt,
            int? callbackStatusCode,
            string? callbackError,
            long? ttftNs,
            long? totalDurationNs,
            string? id)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Status = status;
            this.CompletedAt = completedAt;
            this.StopReason = stopReason;
            this.Metadata = metadata;
            this.JobType = jobType;
            this.Background = background;
            this.AgentId = agentId;
            this.CallbackUrl = callbackUrl;
            this.CallbackSentAt = callbackSentAt;
            this.CallbackStatusCode = callbackStatusCode;
            this.CallbackError = callbackError;
            this.TtftNs = ttftNs;
            this.TotalDurationNs = totalDurationNs;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }
    }
}