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
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CancelledCount { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="AgreementV2BackfillCancelResponse" /> class.
        /// </summary>
        /// <param name="cancelledCount">
        /// Number of jobs successfully cancelled
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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