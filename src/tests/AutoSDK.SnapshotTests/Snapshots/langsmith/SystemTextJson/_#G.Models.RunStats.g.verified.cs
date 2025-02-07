//HintName: G.Models.RunStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p50")]
        public double? LatencyP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p99")]
        public double? LatencyP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_p50")]
        public double? FirstTokenP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_p99")]
        public double? FirstTokenP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median_tokens")]
        public int? MedianTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_start_time")]
        public global::System.DateTime? LastRunStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        public object? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_facets")]
        public global::System.Collections.Generic.IList<object>? RunFacets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_rate")]
        public double? StreamingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public string? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public string? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public string? CompletionCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStats" /> class.
        /// </summary>
        /// <param name="runCount"></param>
        /// <param name="latencyP50"></param>
        /// <param name="latencyP99"></param>
        /// <param name="firstTokenP50"></param>
        /// <param name="firstTokenP99"></param>
        /// <param name="totalTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="medianTokens"></param>
        /// <param name="lastRunStartTime"></param>
        /// <param name="feedbackStats"></param>
        /// <param name="runFacets"></param>
        /// <param name="errorRate"></param>
        /// <param name="streamingRate"></param>
        /// <param name="totalCost"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStats(
            int runCount,
            double? latencyP50,
            double? latencyP99,
            double? firstTokenP50,
            double? firstTokenP99,
            int? totalTokens,
            int? promptTokens,
            int? completionTokens,
            int? medianTokens,
            global::System.DateTime? lastRunStartTime,
            object? feedbackStats,
            global::System.Collections.Generic.IList<object>? runFacets,
            double? errorRate,
            double? streamingRate,
            string? totalCost,
            string? promptCost,
            string? completionCost)
        {
            this.RunCount = runCount;
            this.LatencyP50 = latencyP50;
            this.LatencyP99 = latencyP99;
            this.FirstTokenP50 = firstTokenP50;
            this.FirstTokenP99 = firstTokenP99;
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.MedianTokens = medianTokens;
            this.LastRunStartTime = lastRunStartTime;
            this.FeedbackStats = feedbackStats;
            this.RunFacets = runFacets;
            this.ErrorRate = errorRate;
            this.StreamingRate = streamingRate;
            this.TotalCost = totalCost;
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStats" /> class.
        /// </summary>
        public RunStats()
        {
        }
    }
}