//HintName: G.Models.ImportJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of an import job
    /// </summary>
    public sealed partial class ImportJobStatus
    {
        /// <summary>
        /// Unique identifier for the job<br/>
        /// Example: 6dc3f30a-58c2-4174-96a6-dc18cf3c7776
        /// </summary>
        /// <example>6dc3f30a-58c2-4174-96a6-dc18cf3c7776</example>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid JobId { get; set; } = default!;

        /// <summary>
        /// Type of job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ImportJobStatusJobTypeJsonConverter))]
        public global::G.ImportJobStatusJobType JobType { get; set; }

        /// <summary>
        /// Current state of the job:<br/>
        /// - queued: Job is waiting to start<br/>
        /// - running: Job is actively processing<br/>
        /// - stopped: Job has finished (check result.status for outcome)<br/>
        /// - cancelled: Job was cancelled by user<br/>
        /// Example: stopped
        /// </summary>
        /// <example>stopped</example>
        [global::Newtonsoft.Json.JsonProperty("job_state", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ImportJobStatusJobStateJsonConverter))]
        public global::G.ImportJobStatusJobState JobState { get; set; } = default!;

        /// <summary>
        /// When the job was created<br/>
        /// Example: 2025-11-18T10:30:00Z
        /// </summary>
        /// <example>2025-11-18T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// When the job stopped (only present when job_state is stopped or cancelled)<br/>
        /// Example: 2025-11-18T10:35:00Z
        /// </summary>
        /// <example>2025-11-18T10:35:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("stopped_at")]
        public global::System.DateTime? StoppedAt { get; set; }

        /// <summary>
        /// The drive ID<br/>
        /// Example: c9c5c47e-158a-49f7-846b-4f6ee2a229a2
        /// </summary>
        /// <example>c9c5c47e-158a-49f7-846b-4f6ee2a229a2</example>
        [global::Newtonsoft.Json.JsonProperty("drive_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DriveId { get; set; } = default!;

        /// <summary>
        /// The project ID<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// URL to access the project in Descript web app<br/>
        /// Example: https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </summary>
        /// <example>https://web.descript.com/9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb</example>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// Progress information for the workflow (only present when job_state is running)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public global::G.ImportJobStatusProgress? Progress { get; set; }

        /// <summary>
        /// Job result (only present when job_state is stopped)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.Result? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJobStatus" /> class.
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
        /// Type of job
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
        public ImportJobStatus(
            global::System.Guid jobId,
            global::G.ImportJobStatusJobState jobState,
            global::System.DateTime createdAt,
            global::System.Guid driveId,
            global::System.Guid projectId,
            string projectUrl,
            global::G.ImportJobStatusJobType jobType,
            global::System.DateTime? stoppedAt,
            global::G.ImportJobStatusProgress? progress,
            global::G.Result? result)
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
        /// Initializes a new instance of the <see cref="ImportJobStatus" /> class.
        /// </summary>
        public ImportJobStatus()
        {
        }
    }
}