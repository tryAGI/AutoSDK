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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// ID of the organization that owns this job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrganizationId { get; set; } = default!;

        /// <summary>
        /// ID of the file being extracted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// When the job was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// When the job was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// When the job started processing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the job finished processing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Current status of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ParsingJobStatus Status { get; set; } = default!;

        /// <summary>
        /// The extraction results if completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.ExtractionResult? Result { get; set; }

        /// <summary>
        /// Error information if failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public object? Error { get; set; }

        /// <summary>
        /// The JSON schema used for extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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