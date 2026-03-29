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
        [global::System.Text.Json.Serialization.JsonPropertyName("mean_time")]
        public double? MeanTime { get; set; }

        /// <summary>
        /// Median lead time for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median_time")]
        public double? MedianTime { get; set; }

        /// <summary>
        /// Total lead time for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sum_lead_time")]
        public double? SumLeadTime { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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