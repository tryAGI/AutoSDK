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
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// New status (should be 'cancelled')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BatchJobStatus Status { get; set; }

        /// <summary>
        /// Number of items processed before cancellation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProcessedItems { get; set; }

        /// <summary>
        /// Confirmation message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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