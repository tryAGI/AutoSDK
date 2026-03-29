//HintName: G.Models.FileClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A file classification.
    /// </summary>
    public sealed partial class FileClassification
    {
        /// <summary>
        /// Unique identifier
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
        /// The ID of the classify job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classify_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ClassifyJobId { get; set; }

        /// <summary>
        /// The ID of the classified file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// The classification result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.ClassificationResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileClassification" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="classifyJobId">
        /// The ID of the classify job
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="fileId">
        /// The ID of the classified file
        /// </param>
        /// <param name="result">
        /// The classification result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileClassification(
            global::System.Guid id,
            global::System.Guid classifyJobId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Guid? fileId,
            global::G.ClassificationResult? result)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ClassifyJobId = classifyJobId;
            this.FileId = fileId;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileClassification" /> class.
        /// </summary>
        public FileClassification()
        {
        }
    }
}