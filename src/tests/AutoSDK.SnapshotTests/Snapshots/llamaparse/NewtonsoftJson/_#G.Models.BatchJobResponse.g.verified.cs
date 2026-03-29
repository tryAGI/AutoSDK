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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BatchJobStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The job record ID associated with this status, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_record_id")]
        public string? JobRecordId { get; set; }

        /// <summary>
        /// Error message for the latest job attempt, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Unique identifier for the batch job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Project this job belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Directory being processed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directory_id")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// Type of processing operation (parse or classify)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BatchJobType JobType { get; set; } = default!;

        /// <summary>
        /// Total number of items in the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_items", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalItems { get; set; } = default!;

        /// <summary>
        /// Number of items processed so far<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processed_items")]
        public int? ProcessedItems { get; set; }

        /// <summary>
        /// Number of items that failed processing<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_items")]
        public int? FailedItems { get; set; }

        /// <summary>
        /// Number of items skipped (already processed or size limit)<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skipped_items")]
        public int? SkippedItems { get; set; }

        /// <summary>
        /// Async job tracking ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Timestamp when job processing started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when job completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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