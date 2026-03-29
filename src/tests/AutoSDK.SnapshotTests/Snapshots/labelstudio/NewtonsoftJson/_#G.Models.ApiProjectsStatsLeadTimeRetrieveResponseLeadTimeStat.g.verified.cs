//HintName: G.Models.ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat
    {
        /// <summary>
        /// Average lead time for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mean_time")]
        public double? MeanTime { get; set; }

        /// <summary>
        /// Median lead time for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("median_time")]
        public double? MedianTime { get; set; }

        /// <summary>
        /// Total lead time for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sum_lead_time")]
        public double? SumLeadTime { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat" /> class.
        /// </summary>
        /// <param name="meanTime">
        /// Average lead time for the user
        /// </param>
        /// <param name="medianTime">
        /// Median lead time for the user
        /// </param>
        /// <param name="sumLeadTime">
        /// Total lead time for the user
        /// </param>
        /// <param name="userId">
        /// User ID
        /// </param>
        public ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat(
            double? meanTime,
            double? medianTime,
            double? sumLeadTime,
            int? userId)
        {
            this.MeanTime = meanTime;
            this.MedianTime = medianTime;
            this.SumLeadTime = sumLeadTime;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat" /> class.
        /// </summary>
        public ApiProjectsStatsLeadTimeRetrieveResponseLeadTimeStat()
        {
        }
    }
}