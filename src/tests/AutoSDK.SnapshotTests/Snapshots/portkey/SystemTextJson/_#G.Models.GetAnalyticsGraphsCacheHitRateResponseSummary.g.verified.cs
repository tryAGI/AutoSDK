//HintName: G.Models.GetAnalyticsGraphsCacheHitRateResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsCacheHitRateResponseSummary
    {
        /// <summary>
        /// Total cache hits across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Percentage cache hit rate across all data points
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
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCacheHitRateResponseSummary" /> class.
        /// </summary>
        /// <param name="total">
        /// Total cache hits across all data points
        /// </param>
        /// <param name="rate">
        /// Percentage cache hit rate across all data points
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsCacheHitRateResponseSummary(
            int total,
            int rate)
        {
            this.Total = total;
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCacheHitRateResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsCacheHitRateResponseSummary()
        {
        }
    }
}