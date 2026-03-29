//HintName: G.Models.ExtractRun.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for an extraction run.
    /// </summary>
    public sealed partial class ExtractRun
    {
        /// <summary>
        /// The id of the extraction run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

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
        /// The id of the project that the extraction run belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// The id of the extraction agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExtractionAgentId { get; set; } = default!;

        /// <summary>
        /// The schema used for extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object DataSchema { get; set; } = default!;

        /// <summary>
        /// The config used for extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtractConfig Config { get; set; } = default!;

        /// <summary>
        /// The id of the file that the extract was extracted from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// [DEPRECATED] The file that the extract was extracted from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.File? File { get; set; }

        /// <summary>
        /// The status of the extraction run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtractState Status { get; set; } = default!;

        /// <summary>
        /// The error that occurred during extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The id of the job that the extraction run belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public global::System.Guid? JobId { get; set; }

        /// <summary>
        /// The data extracted from the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Data { get; set; }

        /// <summary>
        /// The metadata extracted from the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_metadata")]
        public object? ExtractionMetadata { get; set; }

        /// <summary>
        /// Whether this extraction run was triggered from the UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_ui", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FromUi { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractRun" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the extraction run
        /// </param>
        /// <param name="projectId">
        /// The id of the project that the extraction run belongs to
        /// </param>
        /// <param name="extractionAgentId">
        /// The id of the extraction agent
        /// </param>
        /// <param name="dataSchema">
        /// The schema used for extraction
        /// </param>
        /// <param name="config">
        /// The config used for extraction
        /// </param>
        /// <param name="status">
        /// The status of the extraction run
        /// </param>
        /// <param name="fromUi">
        /// Whether this extraction run was triggered from the UI
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="fileId">
        /// The id of the file that the extract was extracted from
        /// </param>
        /// <param name="error">
        /// The error that occurred during extraction
        /// </param>
        /// <param name="jobId">
        /// The id of the job that the extraction run belongs to
        /// </param>
        /// <param name="data">
        /// The data extracted from the file
        /// </param>
        /// <param name="extractionMetadata">
        /// The metadata extracted from the file
        /// </param>
        public ExtractRun(
            global::System.Guid id,
            global::System.Guid projectId,
            global::System.Guid extractionAgentId,
            object dataSchema,
            global::G.ExtractConfig config,
            global::G.ExtractState status,
            bool fromUi,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Guid? fileId,
            string? error,
            global::System.Guid? jobId,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? data,
            object? extractionMetadata)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId;
            this.ExtractionAgentId = extractionAgentId;
            this.DataSchema = dataSchema ?? throw new global::System.ArgumentNullException(nameof(dataSchema));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.FileId = fileId;
            this.Status = status;
            this.Error = error;
            this.JobId = jobId;
            this.Data = data;
            this.ExtractionMetadata = extractionMetadata;
            this.FromUi = fromUi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractRun" /> class.
        /// </summary>
        public ExtractRun()
        {
        }
    }
}