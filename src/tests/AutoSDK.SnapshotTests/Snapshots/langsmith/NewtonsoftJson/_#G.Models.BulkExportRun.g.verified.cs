//HintName: G.Models.BulkExportRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bulk_export_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid BulkExportId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BulkExportRunMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BulkExportRunStatus Status { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry_number")]
        public int? RetryNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public object? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? FinishedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRun" /> class.
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="metadata"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="retryNumber">
        /// Default Value: 0
        /// </param>
        /// <param name="errors"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="finishedAt"></param>
        public BulkExportRun(
            global::System.Guid bulkExportId,
            global::G.BulkExportRunMetadata metadata,
            global::System.Guid id,
            global::G.BulkExportRunStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? finishedAt,
            int? retryNumber,
            object? errors)
        {
            this.BulkExportId = bulkExportId;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Id = id;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FinishedAt = finishedAt ?? throw new global::System.ArgumentNullException(nameof(finishedAt));
            this.RetryNumber = retryNumber;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRun" /> class.
        /// </summary>
        public BulkExportRun()
        {
        }
    }
}