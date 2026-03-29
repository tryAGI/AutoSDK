//HintName: G.Models.AgreementV2BackfillJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializes a DimensionsBackfillJob model instance.<br/>
    /// Used by the list endpoint and as the base for the status endpoint.
    /// </summary>
    public sealed partial class AgreementV2BackfillJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Error message if job failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Database ID of the backfill job<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int JobId { get; set; } = default!;

        /// <summary>
        /// JSON data tracking job progress (matrices_created, errors, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress_data")]
        public object? ProgressData { get; set; }

        /// <summary>
        /// Optional specific project to backfill (if null, backfills entire organization)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Redis queue job ID<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rq_job_id")]
        public string? RqJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Current status of the backfill job<br/>
        /// * `PENDING` - Pending<br/>
        /// * `QUEUED` - Queued<br/>
        /// * `RUNNING` - Running<br/>
        /// * `COMPLETED` - Completed<br/>
        /// * `FAILED` - Failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgreementV2BackfillJobStatusEnumJsonConverter))]
        public global::G.AgreementV2BackfillJobStatusEnum? Status { get; set; }

        /// <summary>
        /// User who triggered the backfill<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_by")]
        public string TriggeredBy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementV2BackfillJob" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="errorMessage">
        /// Error message if job failed
        /// </param>
        /// <param name="progressData">
        /// JSON data tracking job progress (matrices_created, errors, etc.)
        /// </param>
        /// <param name="projectId">
        /// Optional specific project to backfill (if null, backfills entire organization)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="rqJobId">
        /// Redis queue job ID<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startedAt"></param>
        /// <param name="status">
        /// Current status of the backfill job<br/>
        /// * `PENDING` - Pending<br/>
        /// * `QUEUED` - Queued<br/>
        /// * `RUNNING` - Running<br/>
        /// * `COMPLETED` - Completed<br/>
        /// * `FAILED` - Failed
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="jobId">
        /// Database ID of the backfill job<br/>
        /// Included only in responses
        /// </param>
        /// <param name="triggeredBy">
        /// User who triggered the backfill<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgreementV2BackfillJob(
            global::System.DateTime? completedAt,
            string? errorMessage,
            object? progressData,
            int? projectId,
            string? rqJobId,
            global::System.DateTime? startedAt,
            global::G.AgreementV2BackfillJobStatusEnum? status,
            global::System.DateTime createdAt = default!,
            int jobId = default!,
            string triggeredBy = default!)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.ErrorMessage = errorMessage;
            this.JobId = jobId;
            this.ProgressData = progressData;
            this.ProjectId = projectId;
            this.RqJobId = rqJobId;
            this.StartedAt = startedAt;
            this.Status = status;
            this.TriggeredBy = triggeredBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementV2BackfillJob" /> class.
        /// </summary>
        public AgreementV2BackfillJob()
        {
        }
    }
}