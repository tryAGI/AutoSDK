//HintName: G.Models.ParsingJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A job for parsing documents with its current state and result.
    /// </summary>
    public sealed partial class ParsingJob
    {
        /// <summary>
        /// The ID of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the file to parse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The name of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The status of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ParsingJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ParsingJobStatus Status { get; set; }

        /// <summary>
        /// The error of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// The result of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.DocumentParserResult? Result { get; set; }

        /// <summary>
        /// The started time of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The finished time of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// The creation time of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The updated time of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: parsing_job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJob" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to parse
        /// </param>
        /// <param name="status">
        /// The status of the job
        /// </param>
        /// <param name="filename">
        /// The name of the file
        /// </param>
        /// <param name="error">
        /// The error of the job
        /// </param>
        /// <param name="result">
        /// The result of the job
        /// </param>
        /// <param name="startedAt">
        /// The started time of the job
        /// </param>
        /// <param name="finishedAt">
        /// The finished time of the job
        /// </param>
        /// <param name="createdAt">
        /// The creation time of the job
        /// </param>
        /// <param name="updatedAt">
        /// The updated time of the job
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: parsing_job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParsingJob(
            string id,
            string fileId,
            global::G.ParsingJobStatus status,
            string? filename,
            object? error,
            global::G.DocumentParserResult? result,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename;
            this.Status = status;
            this.Error = error;
            this.Result = result;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJob" /> class.
        /// </summary>
        public ParsingJob()
        {
        }
    }
}