//HintName: G.Models.AgreementV2BackfillCancelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from DELETE /api/dimensions/backfill/
    /// </summary>
    public sealed partial class AgreementV2BackfillCancelResponse
    {
        /// <summary>
        /// Number of jobs successfully cancelled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CancelledCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementV2BackfillCancelResponse" /> class.
        /// </summary>
        /// <param name="cancelledCount">
        /// Number of jobs successfully cancelled
        /// </param>
        /// <param name="message"></param>
        public AgreementV2BackfillCancelResponse(
            int cancelledCount,
            string message)
        {
            this.CancelledCount = cancelledCount;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementV2BackfillCancelResponse" /> class.
        /// </summary>
        public AgreementV2BackfillCancelResponse()
        {
        }
    }
}