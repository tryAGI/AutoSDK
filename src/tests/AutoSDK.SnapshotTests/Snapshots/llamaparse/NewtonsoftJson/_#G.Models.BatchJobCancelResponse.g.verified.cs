//HintName: G.Models.BatchJobCancelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response after cancelling a batch job.
    /// </summary>
    public sealed partial class BatchJobCancelResponse
    {
        /// <summary>
        /// ID of the cancelled job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// New status (should be 'cancelled')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BatchJobStatusJsonConverter))]
        public global::G.BatchJobStatus Status { get; set; } = default!;

        /// <summary>
        /// Number of items processed before cancellation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processed_items", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProcessedItems { get; set; } = default!;

        /// <summary>
        /// Confirmation message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobCancelResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// ID of the cancelled job
        /// </param>
        /// <param name="status">
        /// New status (should be 'cancelled')
        /// </param>
        /// <param name="processedItems">
        /// Number of items processed before cancellation
        /// </param>
        /// <param name="message">
        /// Confirmation message
        /// </param>
        public BatchJobCancelResponse(
            string jobId,
            global::G.BatchJobStatus status,
            int processedItems,
            string message)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.ProcessedItems = processedItems;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobCancelResponse" /> class.
        /// </summary>
        public BatchJobCancelResponse()
        {
        }
    }
}