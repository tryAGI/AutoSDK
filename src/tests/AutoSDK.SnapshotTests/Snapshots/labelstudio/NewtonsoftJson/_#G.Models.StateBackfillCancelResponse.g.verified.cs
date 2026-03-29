//HintName: G.Models.StateBackfillCancelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillCancelResponse
    {
        /// <summary>
        /// Number of jobs successfully cancelled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CancelledCount { get; set; } = default!;

        /// <summary>
        /// Cancellation status message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillCancelResponse" /> class.
        /// </summary>
        /// <param name="cancelledCount">
        /// Number of jobs successfully cancelled
        /// </param>
        /// <param name="message">
        /// Cancellation status message
        /// </param>
        public StateBackfillCancelResponse(
            int cancelledCount,
            string message)
        {
            this.CancelledCount = cancelledCount;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillCancelResponse" /> class.
        /// </summary>
        public StateBackfillCancelResponse()
        {
        }
    }
}