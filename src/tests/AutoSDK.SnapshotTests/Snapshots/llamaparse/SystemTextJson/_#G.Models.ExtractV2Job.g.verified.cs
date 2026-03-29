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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project this job belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Saved extract configuration ID used for this job, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// File ID or parse job ID that was extracted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_input_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentInputValue { get; set; }

        /// <summary>
        /// Configuration used for this job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::G.ExtractConfiguration? Configuration { get; set; }

        /// <summary>
        /// Current job status.<br/>
        /// - `PENDING` — queued, not yet started<br/>
        /// - `RUNNING` — actively processing<br/>
        /// - `COMPLETED` — finished successfully<br/>
        /// - `FAILED` — terminated with an error<br/>
        /// - `CANCELLED` — cancelled by user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Error details when status is FAILED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Extracted data conforming to the data_schema. Returns a single object for per_doc, or an array for per_page / per_table_row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? ExtractResult { get; set; }

        /// <summary>
        /// Extraction metadata including per-field info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_metadata")]
        public global::G.ExtractJobMetadata? ExtractMetadata { get; set; }

        /// <summary>
        /// Custom metadata - limited to enterprise plans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ExtractV2JobMetadata2? Metadata { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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