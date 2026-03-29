//HintName: G.Models.UsageStatsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageStatsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billingPeriod", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsageStatsResponseBillingPeriod BillingPeriod { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsageStatsResponseUsage Usage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dailyData", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DailyUsageDataPoint> DailyData { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("estimatedCost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsageStatsResponseEstimatedCost EstimatedCost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponse" /> class.
        /// </summary>
        /// <param name="billingPeriod"></param>
        /// <param name="usage"></param>
        /// <param name="dailyData"></param>
        /// <param name="estimatedCost"></param>
        public UsageStatsResponse(
            global::G.UsageStatsResponseBillingPeriod billingPeriod,
            global::G.UsageStatsResponseUsage usage,
            global::System.Collections.Generic.IList<global::G.DailyUsageDataPoint> dailyData,
            global::G.UsageStatsResponseEstimatedCost estimatedCost)
        {
            this.BillingPeriod = billingPeriod ?? throw new global::System.ArgumentNullException(nameof(billingPeriod));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.DailyData = dailyData ?? throw new global::System.ArgumentNullException(nameof(dailyData));
            this.EstimatedCost = estimatedCost ?? throw new global::System.ArgumentNullException(nameof(estimatedCost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponse" /> class.
        /// </summary>
        public UsageStatsResponse()
        {
        }
    }
}