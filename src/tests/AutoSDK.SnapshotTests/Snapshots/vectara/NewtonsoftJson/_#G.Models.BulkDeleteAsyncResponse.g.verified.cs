//HintName: G.Models.BulkDeleteAsyncResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response when async=true. Operation queued, returns immediately (HTTP 202).
    /// </summary>
    public sealed partial class BulkDeleteAsyncResponse
    {
        /// <summary>
        /// Indicates this is an async response.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteAsyncResponse" /> class.
        /// </summary>
        /// <param name="responseType">
        /// Indicates this is an async response.
        /// </param>
        /// <param name="jobId">
        /// Job ID to track the bulk delete operation via the Jobs API.<br/>
        /// Example: job_bulk_del_123456
        /// </param>
        /// <param name="cutoffTimestamp">
        /// ISO 8601 timestamp captured at workflow launch. Only documents created or updated before this timestamp will be deleted.<br/>
        /// Example: 2025-12-18T15:30:00Z
        /// </param>
        public BulkDeleteAsyncResponse(
            string responseType,
            string jobId,
            global::System.DateTime cutoffTimestamp)
        {
            this.ResponseType = responseType ?? throw new global::System.ArgumentNullException(nameof(responseType));
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.CutoffTimestamp = cutoffTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteAsyncResponse" /> class.
        /// </summary>
        public BulkDeleteAsyncResponse()
        {
        }
    }
}