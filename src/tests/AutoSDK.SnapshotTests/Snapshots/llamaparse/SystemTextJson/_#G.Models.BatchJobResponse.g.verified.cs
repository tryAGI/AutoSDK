//HintName: G.Models.BatchJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response schema for a batch processing job.
    /// </summary>
    public sealed partial class BatchJobResponse
    {
        /// <summary>
        /// Current job status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BatchJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The job record ID associated with this status, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_record_id")]
        public string? JobRecordId { get; set; }

        /// <summary>
        /// Error message for the latest job attempt, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Unique identifier for the batch job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Project this job belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Directory being processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_id")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// Type of processing operation (parse or classify)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchJobTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BatchJobType JobType { get; set; }

        /// <summary>
        /// Total number of items in the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalItems { get; set; }

        /// <summary>
        /// Number of items processed so far<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_items")]
        public int? ProcessedItems { get; set; }

        /// <summary>
        /// Number of items that failed processing<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_items")]
        public int? FailedItems { get; set; }

        /// <summary>
        /// Number of items skipped (already processed or size limit)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_items")]
        public int? SkippedItems { get; set; }

        /// <summary>
        /// Async job tracking ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Timestamp when job processing started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when job completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Current job status
        /// </param>
        /// <param name="id">
        /// Unique identifier for the batch job
        /// </param>
        /// <param name="projectId">
        /// Project this job belongs to
        /// </param>
        /// <param name="jobType">
        /// Type of processing operation (parse or classify)
        /// </param>
        /// <param name="totalItems">
        /// Total number of items in the job
        /// </param>
        /// <param name="effectiveAt"></param>
        /// <param name="jobRecordId">
        /// The job record ID associated with this status, if any.
        /// </param>
        /// <param name="errorMessage">
        /// Error message for the latest job attempt, if any.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="directoryId">
        /// Directory being processed
        /// </param>
        /// <param name="processedItems">
        /// Number of items processed so far<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="failedItems">
        /// Number of items that failed processing<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="skippedItems">
        /// Number of items skipped (already processed or size limit)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="workflowId">
        /// Async job tracking ID
        /// </param>
        /// <param name="startedAt">
        /// Timestamp when job processing started
        /// </param>
        /// <param name="completedAt">
        /// Timestamp when job completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobResponse(
            global::G.BatchJobStatus status,
            string id,
            string projectId,
            global::G.BatchJobType jobType,
            int totalItems,
            global::System.DateTime? effectiveAt,
            string? jobRecordId,
            string? errorMessage,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? directoryId,
            int? processedItems,
            int? failedItems,
            int? skippedItems,
            string? workflowId,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt)
        {
            this.Status = status;
            this.EffectiveAt = effectiveAt;
            this.JobRecordId = jobRecordId;
            this.ErrorMessage = errorMessage;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DirectoryId = directoryId;
            this.JobType = jobType;
            this.TotalItems = totalItems;
            this.ProcessedItems = processedItems;
            this.FailedItems = failedItems;
            this.SkippedItems = skippedItems;
            this.WorkflowId = workflowId;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobResponse" /> class.
        /// </summary>
        public BatchJobResponse()
        {
        }
    }
}