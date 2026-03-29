//HintName: G.Models.AggregationData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AggregationData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_count")]
        public long? ExperimentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_count")]
        public long? TraceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_estimated_cost_avg")]
        public double? TotalEstimatedCostAvg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public global::G.PercentageValues? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? FeedbackScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? ExperimentScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_rate_avg")]
        public double? PassRateAvg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed_count_sum")]
        public long? PassedCountSum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count_sum")]
        public long? TotalCountSum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationData" /> class.
        /// </summary>
        /// <param name="experimentCount"></param>
        /// <param name="traceCount"></param>
        /// <param name="totalEstimatedCost"></param>
        /// <param name="totalEstimatedCostAvg"></param>
        /// <param name="duration"></param>
        /// <param name="feedbackScores"></param>
        /// <param name="experimentScores"></param>
        /// <param name="passRateAvg"></param>
        /// <param name="passedCountSum"></param>
        /// <param name="totalCountSum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregationData(
            long? experimentCount,
            long? traceCount,
            double? totalEstimatedCost,
            double? totalEstimatedCostAvg,
            global::G.PercentageValues? duration,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? feedbackScores,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? experimentScores,
            double? passRateAvg,
            long? passedCountSum,
            long? totalCountSum)
        {
            this.ExperimentCount = experimentCount;
            this.TraceCount = traceCount;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.TotalEstimatedCostAvg = totalEstimatedCostAvg;
            this.Duration = duration;
            this.FeedbackScores = feedbackScores;
            this.ExperimentScores = experimentScores;
            this.PassRateAvg = passRateAvg;
            this.PassedCountSum = passedCountSum;
            this.TotalCountSum = totalCountSum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationData" /> class.
        /// </summary>
        public AggregationData()
        {
        }
    }
}