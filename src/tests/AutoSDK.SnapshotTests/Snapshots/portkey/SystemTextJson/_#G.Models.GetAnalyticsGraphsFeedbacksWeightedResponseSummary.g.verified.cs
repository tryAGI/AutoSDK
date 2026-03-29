//HintName: G.Models.GetAnalyticsGraphsFeedbacksWeightedResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsFeedbacksWeightedResponseSummary
    {
        /// <summary>
        /// Average weighted feedback across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Avg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksWeightedResponseSummary" /> class.
        /// </summary>
        /// <param name="avg">
        /// Average weighted feedback across all data points
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsFeedbacksWeightedResponseSummary(
            int avg)
        {
            this.Avg = avg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksWeightedResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsFeedbacksWeightedResponseSummary()
        {
        }
    }
}