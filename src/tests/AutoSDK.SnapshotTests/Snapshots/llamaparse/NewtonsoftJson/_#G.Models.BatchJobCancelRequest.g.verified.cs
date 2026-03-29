//HintName: G.Models.BatchJobCancelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to cancel a running batch job.
    /// </summary>
    public sealed partial class BatchJobCancelRequest
    {
        /// <summary>
        /// Optional reason for cancelling the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobCancelRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// Optional reason for cancelling the job
        /// </param>
        public BatchJobCancelRequest(
            string? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobCancelRequest" /> class.
        /// </summary>
        public BatchJobCancelRequest()
        {
        }
    }
}