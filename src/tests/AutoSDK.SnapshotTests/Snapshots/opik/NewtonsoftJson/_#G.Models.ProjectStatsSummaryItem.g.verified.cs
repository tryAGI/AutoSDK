//HintName: G.Models.ProjectStatsSummaryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectStatsSummaryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? FeedbackScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public global::G.PercentageValues? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost_sum")]
        public double? TotalEstimatedCostSum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::System.Collections.Generic.Dictionary<string, double>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_count")]
        public long? TraceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_count")]
        public long? ThreadCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrails_failed_count")]
        public long? GuardrailsFailedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_count")]
        public global::G.ErrorCountWithDeviation? ErrorCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsSummaryItem" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="feedbackScores"></param>
        /// <param name="duration"></param>
        /// <param name="totalEstimatedCost"></param>
        /// <param name="totalEstimatedCostSum"></param>
        /// <param name="usage"></param>
        /// <param name="traceCount"></param>
        /// <param name="threadCount"></param>
        /// <param name="guardrailsFailedCount"></param>
        /// <param name="errorCount"></param>
        public ProjectStatsSummaryItem(
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? feedbackScores,
            global::G.PercentageValues? duration,
            double? totalEstimatedCost,
            double? totalEstimatedCostSum,
            global::System.Collections.Generic.Dictionary<string, double>? usage,
            long? traceCount,
            long? threadCount,
            long? guardrailsFailedCount,
            global::G.ErrorCountWithDeviation? errorCount)
        {
            this.ProjectId = projectId;
            this.FeedbackScores = feedbackScores;
            this.Duration = duration;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.TotalEstimatedCostSum = totalEstimatedCostSum;
            this.Usage = usage;
            this.TraceCount = traceCount;
            this.ThreadCount = threadCount;
            this.GuardrailsFailedCount = guardrailsFailedCount;
            this.ErrorCount = errorCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatsSummaryItem" /> class.
        /// </summary>
        public ProjectStatsSummaryItem()
        {
        }
    }
}