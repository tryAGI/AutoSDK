//HintName: G.Models.BulkDeleteSyncSuccessResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response when async=false and operation completes successfully (HTTP 200).
    /// </summary>
    public sealed partial class BulkDeleteSyncSuccessResponse
    {
        /// <summary>
        /// Indicates this is a successful sync response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseType { get; set; }

        /// <summary>
        /// Job ID to track the bulk delete operation via the Jobs API.<br/>
        /// Example: job_bulk_del_123456
        /// </summary>
        /// <example>job_bulk_del_123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// ISO 8601 timestamp captured at workflow launch. Only documents created or updated before this timestamp will be deleted.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </summary>
        /// <example>2025-12-18T15:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cutoff_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CutoffTimestamp { get; set; }

        /// <summary>
        /// Number of documents successfully deleted.<br/>
        /// Example: 1523
        /// </summary>
        /// <example>1523</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DeletedCount { get; set; }

        /// <summary>
        /// Number of documents skipped.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SkippedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteSyncSuccessResponse" /> class.
        /// </summary>
        /// <param name="responseType">
        /// Indicates this is a successful sync response.
        /// </param>
        /// <param name="jobId">
        /// Job ID to track the bulk delete operation via the Jobs API.<br/>
        /// Example: job_bulk_del_123456
        /// </param>
        /// <param name="cutoffTimestamp">
        /// ISO 8601 timestamp captured at workflow launch. Only documents created or updated before this timestamp will be deleted.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </param>
        /// <param name="deletedCount">
        /// Number of documents successfully deleted.<br/>
        /// Example: 1523
        /// </param>
        /// <param name="skippedCount">
        /// Number of documents skipped.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkDeleteSyncSuccessResponse(
            string responseType,
            string jobId,
            global::System.DateTime cutoffTimestamp,
            long deletedCount,
            long skippedCount)
        {
            this.ResponseType = responseType ?? throw new global::System.ArgumentNullException(nameof(responseType));
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.CutoffTimestamp = cutoffTimestamp;
            this.DeletedCount = deletedCount;
            this.SkippedCount = skippedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteSyncSuccessResponse" /> class.
        /// </summary>
        public BulkDeleteSyncSuccessResponse()
        {
        }
    }
}