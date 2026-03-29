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
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CancelledCount { get; set; }

        /// <summary>
        /// Cancellation status message
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
        /// Initializes a new instance of the <see cref="StateBackfillCancelResponse" /> class.
        /// </summary>
        /// <param name="cancelledCount">
        /// Number of jobs successfully cancelled
        /// </param>
        /// <param name="message">
        /// Cancellation status message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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