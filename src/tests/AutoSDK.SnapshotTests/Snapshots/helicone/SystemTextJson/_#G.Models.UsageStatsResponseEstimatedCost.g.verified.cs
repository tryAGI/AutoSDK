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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectedMonthlyTotalCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProjectedMonthlyTotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectedMonthlyGBCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProjectedMonthlyGBCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectedMonthlyRequestsCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProjectedMonthlyRequestsCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gbCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double GbCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestsCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestsCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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