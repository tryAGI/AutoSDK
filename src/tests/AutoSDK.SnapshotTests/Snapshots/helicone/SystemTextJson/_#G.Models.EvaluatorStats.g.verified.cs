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
        [global::System.Text.Json.Serialization.JsonPropertyName("averageScore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentTrend")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvaluatorStatsRecentTrendJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvaluatorStatsRecentTrend RecentTrend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreDistribution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvaluatorStatsScoreDistributionItem> ScoreDistribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeriesData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvaluatorStatsTimeSeriesDataItem> TimeSeriesData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStats" /> class.
        /// </summary>
        /// <param name="averageScore"></param>
        /// <param name="totalUses"></param>
        /// <param name="recentTrend"></param>
        /// <param name="scoreDistribution"></param>
        /// <param name="timeSeriesData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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