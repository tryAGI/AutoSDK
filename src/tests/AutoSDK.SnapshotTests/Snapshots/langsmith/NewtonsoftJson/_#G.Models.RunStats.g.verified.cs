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
        [global::Newtonsoft.Json.JsonProperty("run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_p50")]
        public double? LatencyP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_p99")]
        public double? LatencyP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_token_p50")]
        public double? FirstTokenP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_token_p99")]
        public double? FirstTokenP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("median_tokens")]
        public int? MedianTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_p50")]
        public int? CompletionTokensP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_p50")]
        public int? PromptTokensP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens_p99")]
        public int? TokensP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_p99")]
        public int? CompletionTokensP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_p99")]
        public int? PromptTokensP99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_run_start_time")]
        public global::System.DateTime? LastRunStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_stats")]
        public object? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_facets")]
        public global::System.Collections.Generic.IList<object>? RunFacets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streaming_rate")]
        public double? StreamingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost")]
        public string? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cost")]
        public string? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_cost")]
        public string? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_p50")]
        public string? CostP50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_p99")]
        public string? CostP99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="completionTokensP50"></param>
        /// <param name="promptTokensP50"></param>
        /// <param name="tokensP99"></param>
        /// <param name="completionTokensP99"></param>
        /// <param name="promptTokensP99"></param>
        /// <param name="lastRunStartTime"></param>
        /// <param name="feedbackStats"></param>
        /// <param name="runFacets"></param>
        /// <param name="errorRate"></param>
        /// <param name="streamingRate"></param>
        /// <param name="totalCost"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="costP50"></param>
        /// <param name="costP99"></param>
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
            int? completionTokensP50,
            int? promptTokensP50,
            int? tokensP99,
            int? completionTokensP99,
            int? promptTokensP99,
            global::System.DateTime? lastRunStartTime,
            object? feedbackStats,
            global::System.Collections.Generic.IList<object>? runFacets,
            double? errorRate,
            double? streamingRate,
            string? totalCost,
            string? promptCost,
            string? completionCost,
            string? costP50,
            string? costP99)
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
            this.CompletionTokensP50 = completionTokensP50;
            this.PromptTokensP50 = promptTokensP50;
            this.TokensP99 = tokensP99;
            this.CompletionTokensP99 = completionTokensP99;
            this.PromptTokensP99 = promptTokensP99;
            this.LastRunStartTime = lastRunStartTime;
            this.FeedbackStats = feedbackStats;
            this.RunFacets = runFacets;
            this.ErrorRate = errorRate;
            this.StreamingRate = streamingRate;
            this.TotalCost = totalCost;
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.CostP50 = costP50;
            this.CostP99 = costP99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStats" /> class.
        /// </summary>
        public RunStats()
        {
        }
    }
}