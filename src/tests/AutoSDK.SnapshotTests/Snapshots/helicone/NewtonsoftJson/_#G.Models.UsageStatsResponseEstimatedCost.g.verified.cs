//HintName: G.Models.UsageStatsResponseEstimatedCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageStatsResponseEstimatedCost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectedMonthlyTotalCost", Required = global::Newtonsoft.Json.Required.Always)]
        public double ProjectedMonthlyTotalCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectedMonthlyGBCost", Required = global::Newtonsoft.Json.Required.Always)]
        public double ProjectedMonthlyGBCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectedMonthlyRequestsCost", Required = global::Newtonsoft.Json.Required.Always)]
        public double ProjectedMonthlyRequestsCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalCost", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gbCost", Required = global::Newtonsoft.Json.Required.Always)]
        public double GbCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestsCost", Required = global::Newtonsoft.Json.Required.Always)]
        public double RequestsCost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponseEstimatedCost" /> class.
        /// </summary>
        /// <param name="projectedMonthlyTotalCost"></param>
        /// <param name="projectedMonthlyGBCost"></param>
        /// <param name="projectedMonthlyRequestsCost"></param>
        /// <param name="totalCost"></param>
        /// <param name="gbCost"></param>
        /// <param name="requestsCost"></param>
        public UsageStatsResponseEstimatedCost(
            double projectedMonthlyTotalCost,
            double projectedMonthlyGBCost,
            double projectedMonthlyRequestsCost,
            double totalCost,
            double gbCost,
            double requestsCost)
        {
            this.ProjectedMonthlyTotalCost = projectedMonthlyTotalCost;
            this.ProjectedMonthlyGBCost = projectedMonthlyGBCost;
            this.ProjectedMonthlyRequestsCost = projectedMonthlyRequestsCost;
            this.TotalCost = totalCost;
            this.GbCost = gbCost;
            this.RequestsCost = requestsCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponseEstimatedCost" /> class.
        /// </summary>
        public UsageStatsResponseEstimatedCost()
        {
        }
    }
}