//HintName: G.Models.EmbeddingsDeploymentStatsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsDeploymentStatsOut
    {
        /// <summary>
        /// number of inference requests in the provided interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// number of input tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// average millisecond time per token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_tpt_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTptMs { get; set; }

        /// <summary>
        /// 95th percentile time per token (estimated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg95_tpt_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Avg95TptMs { get; set; }

        /// <summary>
        /// total number of cents spent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_amount_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAmountCents { get; set; }

        /// <summary>
        /// number of errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsDeploymentStatsOut" /> class.
        /// </summary>
        /// <param name="requests">
        /// number of inference requests in the provided interval
        /// </param>
        /// <param name="inputTokens">
        /// number of input tokens generated
        /// </param>
        /// <param name="avgTptMs">
        /// average millisecond time per token
        /// </param>
        /// <param name="avg95TptMs">
        /// 95th percentile time per token (estimated)
        /// </param>
        /// <param name="totalAmountCents">
        /// total number of cents spent
        /// </param>
        /// <param name="errors">
        /// number of errors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsDeploymentStatsOut(
            int requests,
            int inputTokens,
            double avgTptMs,
            double avg95TptMs,
            int totalAmountCents,
            int errors)
        {
            this.Requests = requests;
            this.InputTokens = inputTokens;
            this.AvgTptMs = avgTptMs;
            this.Avg95TptMs = avg95TptMs;
            this.TotalAmountCents = totalAmountCents;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsDeploymentStatsOut" /> class.
        /// </summary>
        public EmbeddingsDeploymentStatsOut()
        {
        }
    }
}