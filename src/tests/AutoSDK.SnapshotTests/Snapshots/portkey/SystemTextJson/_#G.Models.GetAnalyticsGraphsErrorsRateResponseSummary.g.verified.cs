//HintName: G.Models.GetAnalyticsGraphsErrorsRateResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsErrorsRateResponseSummary
    {
        /// <summary>
        /// Percentage error rate across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsRateResponseSummary" /> class.
        /// </summary>
        /// <param name="rate">
        /// Percentage error rate across all data points
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsErrorsRateResponseSummary(
            int rate)
        {
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsRateResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsErrorsRateResponseSummary()
        {
        }
    }
}