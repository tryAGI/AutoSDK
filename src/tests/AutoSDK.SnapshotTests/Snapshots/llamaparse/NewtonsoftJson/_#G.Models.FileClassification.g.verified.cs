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
        /// The ID of the classify job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classify_job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ClassifyJobId { get; set; } = default!;

        /// <summary>
        /// The ID of the classified file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// The classification result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.ClassificationResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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