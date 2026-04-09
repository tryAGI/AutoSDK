//HintName: G.Models.BatchItemDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed information about an item in a batch job.
    /// </summary>
    public sealed partial class BatchItemDetail
    {
        /// <summary>
        /// Processing status of this item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BatchFileStatusJsonConverter))]
        public global::G.BatchFileStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The job record ID associated with this status, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_record_id")]
        public string? JobRecordId { get; set; }

        /// <summary>
        /// Error message for the latest job attempt, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// ID of the item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// Name of the item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemName { get; set; } = default!;

        /// <summary>
        /// Job ID for the underlying processing job (links to parse/extract job results)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// Reason item was skipped (e.g., 'already_processed', 'size_limit_exceeded')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip_reason")]
        public string? SkipReason { get; set; }

        /// <summary>
        /// When processing started for this item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When processing completed for this item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchItemDetail" /> class.
        /// </summary>
        /// <param name="status">
        /// Processing status of this item
        /// </param>
        /// <param name="itemId">
        /// ID of the item
        /// </param>
        /// <param name="itemName">
        /// Name of the item
        /// </param>
        /// <param name="effectiveAt"></param>
        /// <param name="jobRecordId">
        /// The job record ID associated with this status, if any.
        /// </param>
        /// <param name="errorMessage">
        /// Error message for the latest job attempt, if any.
        /// </param>
        /// <param name="jobId">
        /// Job ID for the underlying processing job (links to parse/extract job results)
        /// </param>
        /// <param name="skipReason">
        /// Reason item was skipped (e.g., 'already_processed', 'size_limit_exceeded')
        /// </param>
        /// <param name="startedAt">
        /// When processing started for this item
        /// </param>
        /// <param name="completedAt">
        /// When processing completed for this item
        /// </param>
        public BatchItemDetail(
            global::G.BatchFileStatus status,
            string itemId,
            string itemName,
            global::System.DateTime? effectiveAt,
            string? jobRecordId,
            string? errorMessage,
            string? jobId,
            string? skipReason,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt)
        {
            this.Status = status;
            this.EffectiveAt = effectiveAt;
            this.JobRecordId = jobRecordId;
            this.ErrorMessage = errorMessage;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ItemName = itemName ?? throw new global::System.ArgumentNullException(nameof(itemName));
            this.JobId = jobId;
            this.SkipReason = skipReason;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchItemDetail" /> class.
        /// </summary>
        public BatchItemDetail()
        {
        }
    }
}