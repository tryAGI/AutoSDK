//HintName: G.Models.ExtractionJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A job for extracting structured data from documents.
    /// </summary>
    public sealed partial class ExtractionJob
    {
        /// <summary>
        /// Unique identifier for the extraction job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// ID of the organization that owns this job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        /// ID of the file being extracted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FileId { get; set; }

        /// <summary>
        /// When the job was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the job was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// When the job started processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the job finished processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Current status of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ParsingJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ParsingJobStatus Status { get; set; }

        /// <summary>
        /// The extraction results if completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.ExtractionResult? Result { get; set; }

        /// <summary>
        /// Error information if failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// The JSON schema used for extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionJob" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the extraction job
        /// </param>
        /// <param name="organizationId">
        /// ID of the organization that owns this job
        /// </param>
        /// <param name="fileId">
        /// ID of the file being extracted
        /// </param>
        /// <param name="createdAt">
        /// When the job was created
        /// </param>
        /// <param name="updatedAt">
        /// When the job was last updated
        /// </param>
        /// <param name="status">
        /// Current status of the job
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema used for extraction
        /// </param>
        /// <param name="startedAt">
        /// When the job started processing
        /// </param>
        /// <param name="finishedAt">
        /// When the job finished processing
        /// </param>
        /// <param name="result">
        /// The extraction results if completed
        /// </param>
        /// <param name="error">
        /// Error information if failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionJob(
            global::System.Guid id,
            global::System.Guid organizationId,
            global::System.Guid fileId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.ParsingJobStatus status,
            object jsonSchema,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            global::G.ExtractionResult? result,
            object? error)
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.FileId = fileId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.Status = status;
            this.Result = result;
            this.Error = error;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionJob" /> class.
        /// </summary>
        public ExtractionJob()
        {
        }
    }
}