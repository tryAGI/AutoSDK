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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

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
        /// The id of the project that the extraction run belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// The id of the extraction agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExtractionAgentId { get; set; }

        /// <summary>
        /// The schema used for extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DataSchema { get; set; }

        /// <summary>
        /// The config used for extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtractConfig Config { get; set; }

        /// <summary>
        /// The id of the file that the extract was extracted from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// [DEPRECATED] The file that the extract was extracted from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.File? File { get; set; }

        /// <summary>
        /// The status of the extraction run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtractStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtractState Status { get; set; }

        /// <summary>
        /// The error that occurred during extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The id of the job that the extraction run belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public global::System.Guid? JobId { get; set; }

        /// <summary>
        /// The data extracted from the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Data { get; set; }

        /// <summary>
        /// The metadata extracted from the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_metadata")]
        public object? ExtractionMetadata { get; set; }

        /// <summary>
        /// Whether this extraction run was triggered from the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_ui")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FromUi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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