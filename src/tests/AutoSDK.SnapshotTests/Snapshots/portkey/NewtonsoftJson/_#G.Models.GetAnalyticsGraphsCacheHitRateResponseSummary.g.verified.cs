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
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Percentage cache hit rate across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate", Required = global::Newtonsoft.Json.Required.Always)]
        public int Rate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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