//HintName: G.Models.AgentJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of an Agent edit job
    /// </summary>
    public sealed partial class AgentJobStatus
    {
        /// <summary>
        /// Unique identifier for the job<br/>
        /// Example: 6dc3f30a-58c2-4174-96a6-dc18cf3c7776
        /// </summary>
        /// <example>6dc3f30a-58c2-4174-96a6-dc18cf3c7776</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// Type of job<br/>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentJobStatusJobTypeJsonConverter))]
        public global::G.AgentJobStatusJobType JobType { get; set; }

        /// <summary>
        /// Current state of the job:<br/>
        /// - queued: Job is waiting to start<br/>
        /// - running: Job is actively processing<br/>
        /// - stopped: Job has finished (check result.status for outcome)<br/>
        /// - cancelled: Job was cancelled by user<br/>
        /// Example: stopped
        /// </summary>
        /// <example>stopped</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentJobStatusJobStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentJobStatusJobState JobState { get; set; }

        /// <summary>
        /// When the job was created<br/>
        /// Example: 2025-11-18T10:30:00Z
        /// </summary>
        /// <example>2025-11-18T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the job stopped (only present when job_state is stopped or cancelled)<br/>
        /// Example: 2025-11-18T10:35:00Z
        /// </summary>
        /// <example>2025-11-18T10:35:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopped_at")]
        public global::System.DateTime? StoppedAt { get; set; }

        /// <summary>
        /// The drive ID<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </summary>
        /// <example>c9c5c47e-158a-49f7-846b-4f6ee2a229a2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DriveId { get; set; }

        /// <summary>
        /// The project ID<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// URL to access the project in Descript web app<br/>
        /// Example: https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// Progress information for the workflow (only present when job_state is running)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::G.AgentJobStatusProgress? Progress { get; set; }

        /// <summary>
        /// Job result (only present when job_state is stopped)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Result2JsonConverter))]
        public global::G.Result2? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentJobStatus" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Unique identifier for the job<br/>
        /// Example: 6dc3f30a-58c2-4174-96a6-dc18cf3c7776
        /// </param>
        /// <param name="jobState">
        /// Current state of the job:<br/>
        /// - queued: Job is waiting to start<br/>
        /// - running: Job is actively processing<br/>
        /// - stopped: Job has finished (check result.status for outcome)<br/>
        /// - cancelled: Job was cancelled by user<br/>
        /// Example: stopped
        /// </param>
        /// <param name="createdAt">
        /// When the job was created<br/>
        /// Example: 2025-11-18T10:30:00Z
        /// </param>
        /// <param name="driveId">
        /// The drive ID<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </param>
        /// <param name="projectId">
        /// The project ID<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="projectUrl">
        /// URL to access the project in Descript web app<br/>
        /// Example: https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="jobType">
        /// Type of job<br/>
        /// Example: agent
        /// </param>
        /// <param name="stoppedAt">
        /// When the job stopped (only present when job_state is stopped or cancelled)<br/>
        /// Example: 2025-11-18T10:35:00Z
        /// </param>
        /// <param name="progress">
        /// Progress information for the workflow (only present when job_state is running)
        /// </param>
        /// <param name="result">
        /// Job result (only present when job_state is stopped)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentJobStatus(
            global::System.Guid jobId,
            global::G.AgentJobStatusJobState jobState,
            global::System.DateTime createdAt,
            global::System.Guid driveId,
            global::System.Guid projectId,
            string projectUrl,
            global::G.AgentJobStatusJobType jobType,
            global::System.DateTime? stoppedAt,
            global::G.AgentJobStatusProgress? progress,
            global::G.Result2? result)
        {
            this.JobId = jobId;
            this.JobType = jobType;
            this.JobState = jobState;
            this.CreatedAt = createdAt;
            this.StoppedAt = stoppedAt;
            this.DriveId = driveId;
            this.ProjectId = projectId;
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.Progress = progress;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentJobStatus" /> class.
        /// </summary>
        public AgentJobStatus()
        {
        }
    }
}