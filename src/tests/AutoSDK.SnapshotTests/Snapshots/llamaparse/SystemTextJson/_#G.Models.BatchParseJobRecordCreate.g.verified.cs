//HintName: G.Models.BatchParseJobRecordCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Batch-specific parse job record for batch processing.<br/>
    /// This model contains the metadata and configuration for a batch parse job,<br/>
    /// but excludes file-specific information. It's used as input to the batch<br/>
    /// parent workflow and combined with DirectoryFile data to create full<br/>
    /// ParseJobRecordCreate instances for each file.<br/>
    /// Attributes:<br/>
    ///     job_name: Must be PARSE_RAW_FILE<br/>
    ///     partitions: Partitions for job output location<br/>
    ///     parameters: Generic parse configuration (BatchParseJobConfig)<br/>
    ///     session_id: Upstream request ID for tracking<br/>
    ///     correlation_id: Correlation ID for cross-service tracking<br/>
    ///     parent_job_execution_id: Parent job execution ID if nested<br/>
    ///     user_id: User who created the job<br/>
    ///     project_id: Project this job belongs to<br/>
    ///     webhook_url: Optional webhook URL for job completion notifications
    /// </summary>
    public sealed partial class BatchParseJobRecordCreate
    {
        /// <summary>
        /// Default Value: parse_raw_file_job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_name")]
        public string? JobName { get; set; }

        /// <summary>
        /// The partitions for this execution. Used for determining where to save job output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitions")]
        public object? Partitions { get; set; }

        /// <summary>
        /// The generic parse configuration for all files in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.BatchParseJobConfig? Parameters { get; set; }

        /// <summary>
        /// The upstream request ID that created this job. Used for tracking the job across services.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// The correlation ID for this job. Used for tracking the job across services.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correlation_id")]
        public global::System.Guid? CorrelationId { get; set; }

        /// <summary>
        /// The ID of the parent job execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_job_execution_id")]
        public global::System.Guid? ParentJobExecutionId { get; set; }

        /// <summary>
        /// The ID of the user that created this job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The ID of the project this job belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// The URL that needs to be called at the end of the parsing job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchParseJobRecordCreate" /> class.
        /// </summary>
        /// <param name="jobName">
        /// Default Value: parse_raw_file_job
        /// </param>
        /// <param name="partitions">
        /// The partitions for this execution. Used for determining where to save job output.
        /// </param>
        /// <param name="parameters">
        /// The generic parse configuration for all files in the batch.
        /// </param>
        /// <param name="sessionId">
        /// The upstream request ID that created this job. Used for tracking the job across services.
        /// </param>
        /// <param name="correlationId">
        /// The correlation ID for this job. Used for tracking the job across services.
        /// </param>
        /// <param name="parentJobExecutionId">
        /// The ID of the parent job execution.
        /// </param>
        /// <param name="userId">
        /// The ID of the user that created this job
        /// </param>
        /// <param name="projectId">
        /// The ID of the project this job belongs to.
        /// </param>
        /// <param name="webhookUrl">
        /// The URL that needs to be called at the end of the parsing job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchParseJobRecordCreate(
            string? jobName,
            object? partitions,
            global::G.BatchParseJobConfig? parameters,
            global::System.Guid? sessionId,
            global::System.Guid? correlationId,
            global::System.Guid? parentJobExecutionId,
            string? userId,
            global::System.Guid? projectId,
            string? webhookUrl)
        {
            this.JobName = jobName;
            this.Partitions = partitions;
            this.Parameters = parameters;
            this.SessionId = sessionId;
            this.CorrelationId = correlationId;
            this.ParentJobExecutionId = parentJobExecutionId;
            this.UserId = userId;
            this.ProjectId = projectId;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchParseJobRecordCreate" /> class.
        /// </summary>
        public BatchParseJobRecordCreate()
        {
        }
    }
}