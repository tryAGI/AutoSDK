//HintName: G.Models.ExtractV2Job.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An extraction job.
    /// </summary>
    public sealed partial class ExtractV2Job
    {
        /// <summary>
        /// Unique job identifier (job_id)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Project this job belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Saved extract configuration ID used for this job, if any
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// File ID or parse job ID that was extracted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_input_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentInputValue { get; set; } = default!;

        /// <summary>
        /// Configuration used for this job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::G.ExtractConfiguration? Configuration { get; set; }

        /// <summary>
        /// Current job status.<br/>
        /// - `PENDING` — queued, not yet started<br/>
        /// - `RUNNING` — actively processing<br/>
        /// - `COMPLETED` — finished successfully<br/>
        /// - `FAILED` — terminated with an error<br/>
        /// - `CANCELLED` — cancelled by user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Error details when status is FAILED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Extracted data conforming to the data_schema. Returns a single object for per_doc, or an array for per_page / per_table_row.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extract_result")]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? ExtractResult { get; set; }

        /// <summary>
        /// Extraction metadata including per-field info
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extract_metadata")]
        public global::G.ExtractJobMetadata? ExtractMetadata { get; set; }

        /// <summary>
        /// Custom metadata - limited to enterprise plans.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ExtractV2JobMetadata2? Metadata { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2Job" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique job identifier (job_id)
        /// </param>
        /// <param name="projectId">
        /// Project this job belongs to
        /// </param>
        /// <param name="documentInputValue">
        /// File ID or parse job ID that was extracted
        /// </param>
        /// <param name="status">
        /// Current job status.<br/>
        /// - `PENDING` — queued, not yet started<br/>
        /// - `RUNNING` — actively processing<br/>
        /// - `COMPLETED` — finished successfully<br/>
        /// - `FAILED` — terminated with an error<br/>
        /// - `CANCELLED` — cancelled by user
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp
        /// </param>
        /// <param name="configurationId">
        /// Saved extract configuration ID used for this job, if any
        /// </param>
        /// <param name="configuration">
        /// Configuration used for this job
        /// </param>
        /// <param name="errorMessage">
        /// Error details when status is FAILED
        /// </param>
        /// <param name="extractResult">
        /// Extracted data conforming to the data_schema. Returns a single object for per_doc, or an array for per_page / per_table_row.
        /// </param>
        /// <param name="extractMetadata">
        /// Extraction metadata including per-field info
        /// </param>
        /// <param name="metadata">
        /// Custom metadata - limited to enterprise plans.
        /// </param>
        public ExtractV2Job(
            string id,
            string projectId,
            string documentInputValue,
            string status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? configurationId,
            global::G.ExtractConfiguration? configuration,
            string? errorMessage,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? extractResult,
            global::G.ExtractJobMetadata? extractMetadata,
            global::G.ExtractV2JobMetadata2? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ConfigurationId = configurationId;
            this.DocumentInputValue = documentInputValue ?? throw new global::System.ArgumentNullException(nameof(documentInputValue));
            this.Configuration = configuration;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ErrorMessage = errorMessage;
            this.ExtractResult = extractResult;
            this.ExtractMetadata = extractMetadata;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2Job" /> class.
        /// </summary>
        public ExtractV2Job()
        {
        }
    }
}