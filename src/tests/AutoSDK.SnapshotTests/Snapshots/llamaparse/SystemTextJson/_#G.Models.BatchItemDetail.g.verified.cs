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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchFileStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BatchFileStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The job record ID associated with this status, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_record_id")]
        public string? JobRecordId { get; set; }

        /// <summary>
        /// Error message for the latest job attempt, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// ID of the item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Name of the item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemName { get; set; }

        /// <summary>
        /// Job ID for the underlying processing job (links to parse/extract job results)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// Reason item was skipped (e.g., 'already_processed', 'size_limit_exceeded')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_reason")]
        public string? SkipReason { get; set; }

        /// <summary>
        /// When processing started for this item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When processing completed for this item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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