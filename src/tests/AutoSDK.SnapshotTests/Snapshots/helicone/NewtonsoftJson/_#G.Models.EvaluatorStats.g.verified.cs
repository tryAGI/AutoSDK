//HintName: G.Models.EvaluatorStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("averageScore", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageScore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalUses", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalUses { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recentTrend", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvaluatorStatsRecentTrend RecentTrend { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scoreDistribution", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvaluatorStatsScoreDistributionItem> ScoreDistribution { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeSeriesData", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvaluatorStatsTimeSeriesDataItem> TimeSeriesData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStats" /> class.
        /// </summary>
        /// <param name="averageScore"></param>
        /// <param name="totalUses"></param>
        /// <param name="recentTrend"></param>
        /// <param name="scoreDistribution"></param>
        /// <param name="timeSeriesData"></param>
        public EvaluatorStats(
            double averageScore,
            double totalUses,
            global::G.EvaluatorStatsRecentTrend recentTrend,
            global::System.Collections.Generic.IList<global::G.EvaluatorStatsScoreDistributionItem> scoreDistribution,
            global::System.Collections.Generic.IList<global::G.EvaluatorStatsTimeSeriesDataItem> timeSeriesData)
        {
            this.AverageScore = averageScore;
            this.TotalUses = totalUses;
            this.RecentTrend = recentTrend;
            this.ScoreDistribution = scoreDistribution ?? throw new global::System.ArgumentNullException(nameof(scoreDistribution));
            this.TimeSeriesData = timeSeriesData ?? throw new global::System.ArgumentNullException(nameof(timeSeriesData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStats" /> class.
        /// </summary>
        public EvaluatorStats()
        {
        }
    }
}