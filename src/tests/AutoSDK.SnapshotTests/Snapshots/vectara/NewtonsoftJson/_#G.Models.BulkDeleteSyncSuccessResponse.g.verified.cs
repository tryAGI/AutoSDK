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
        [global::Newtonsoft.Json.JsonProperty("response_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResponseType { get; set; } = default!;

        /// <summary>
        /// Job ID to track the bulk delete operation via the Jobs API.<br/>
        /// Example: job_bulk_del_123456
        /// </summary>
        /// <example>job_bulk_del_123456</example>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp captured at workflow launch. Only documents created or updated before this timestamp will be deleted.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </summary>
        /// <example>2025-12-18T15:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("cutoff_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CutoffTimestamp { get; set; } = default!;

        /// <summary>
        /// Number of documents successfully deleted.<br/>
        /// Example: 1523
        /// </summary>
        /// <example>1523</example>
        [global::Newtonsoft.Json.JsonProperty("deleted_count", Required = global::Newtonsoft.Json.Required.Always)]
        public long DeletedCount { get; set; } = default!;

        /// <summary>
        /// Number of documents skipped.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("skipped_count", Required = global::Newtonsoft.Json.Required.Always)]
        public long SkippedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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