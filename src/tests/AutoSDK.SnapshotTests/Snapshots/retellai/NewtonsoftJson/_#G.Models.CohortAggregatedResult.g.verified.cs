//HintName: G.Models.CohortAggregatedResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohortAggregatedResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("calls_analysed", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> CallsAnalysed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timepoints", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Timepoints { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_by", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CohortAggregatedResultGroupByJsonConverter))]
        public global::G.CohortAggregatedResultGroupBy GroupBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_score", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric AvgScore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_resolution_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric CallResolutionRate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_questions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CohortAggregatedResultTopQuestion> TopQuestions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_recommendations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CohortAggregatedResultTopRecommendation> TopRecommendations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric Latency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_hallucination_analysis", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric LlmHallucinationAnalysis { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_analysis", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric RagAnalysis { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_sentiment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BreakdownMetric UserSentiment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_sentiment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BreakdownMetric AgentSentiment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_success_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric TransferSuccessRate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_wait_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric TransferWaitTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric Wer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_interruption", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric AvgInterruption { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_accuracy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric ToolCallAccuracy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition_accuracy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric TransitionAccuracy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("natural_tonality_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric NaturalTonalityRate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_tool_call_latency", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric CustomToolCallLatency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_tool_call_success_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AverageMetric CustomToolCallSuccessRate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResult" /> class.
        /// </summary>
        /// <param name="callsAnalysed"></param>
        /// <param name="timepoints"></param>
        /// <param name="groupBy"></param>
        /// <param name="avgScore"></param>
        /// <param name="callResolutionRate"></param>
        /// <param name="topQuestions"></param>
        /// <param name="topRecommendations"></param>
        /// <param name="latency"></param>
        /// <param name="llmHallucinationAnalysis"></param>
        /// <param name="ragAnalysis"></param>
        /// <param name="userSentiment"></param>
        /// <param name="agentSentiment"></param>
        /// <param name="transferSuccessRate"></param>
        /// <param name="transferWaitTime"></param>
        /// <param name="wer"></param>
        /// <param name="avgInterruption"></param>
        /// <param name="toolCallAccuracy"></param>
        /// <param name="transitionAccuracy"></param>
        /// <param name="naturalTonalityRate"></param>
        /// <param name="customToolCallLatency"></param>
        /// <param name="customToolCallSuccessRate"></param>
        public CohortAggregatedResult(
            global::System.Collections.Generic.IList<double> callsAnalysed,
            global::System.Collections.Generic.IList<double> timepoints,
            global::G.CohortAggregatedResultGroupBy groupBy,
            global::G.AverageMetric avgScore,
            global::G.AverageMetric callResolutionRate,
            global::System.Collections.Generic.IList<global::G.CohortAggregatedResultTopQuestion> topQuestions,
            global::System.Collections.Generic.IList<global::G.CohortAggregatedResultTopRecommendation> topRecommendations,
            global::G.AverageMetric latency,
            global::G.AverageMetric llmHallucinationAnalysis,
            global::G.AverageMetric ragAnalysis,
            global::G.BreakdownMetric userSentiment,
            global::G.BreakdownMetric agentSentiment,
            global::G.AverageMetric transferSuccessRate,
            global::G.AverageMetric transferWaitTime,
            global::G.AverageMetric wer,
            global::G.AverageMetric avgInterruption,
            global::G.AverageMetric toolCallAccuracy,
            global::G.AverageMetric transitionAccuracy,
            global::G.AverageMetric naturalTonalityRate,
            global::G.AverageMetric customToolCallLatency,
            global::G.AverageMetric customToolCallSuccessRate)
        {
            this.CallsAnalysed = callsAnalysed ?? throw new global::System.ArgumentNullException(nameof(callsAnalysed));
            this.Timepoints = timepoints ?? throw new global::System.ArgumentNullException(nameof(timepoints));
            this.GroupBy = groupBy;
            this.AvgScore = avgScore ?? throw new global::System.ArgumentNullException(nameof(avgScore));
            this.CallResolutionRate = callResolutionRate ?? throw new global::System.ArgumentNullException(nameof(callResolutionRate));
            this.TopQuestions = topQuestions ?? throw new global::System.ArgumentNullException(nameof(topQuestions));
            this.TopRecommendations = topRecommendations ?? throw new global::System.ArgumentNullException(nameof(topRecommendations));
            this.Latency = latency ?? throw new global::System.ArgumentNullException(nameof(latency));
            this.LlmHallucinationAnalysis = llmHallucinationAnalysis ?? throw new global::System.ArgumentNullException(nameof(llmHallucinationAnalysis));
            this.RagAnalysis = ragAnalysis ?? throw new global::System.ArgumentNullException(nameof(ragAnalysis));
            this.UserSentiment = userSentiment ?? throw new global::System.ArgumentNullException(nameof(userSentiment));
            this.AgentSentiment = agentSentiment ?? throw new global::System.ArgumentNullException(nameof(agentSentiment));
            this.TransferSuccessRate = transferSuccessRate ?? throw new global::System.ArgumentNullException(nameof(transferSuccessRate));
            this.TransferWaitTime = transferWaitTime ?? throw new global::System.ArgumentNullException(nameof(transferWaitTime));
            this.Wer = wer ?? throw new global::System.ArgumentNullException(nameof(wer));
            this.AvgInterruption = avgInterruption ?? throw new global::System.ArgumentNullException(nameof(avgInterruption));
            this.ToolCallAccuracy = toolCallAccuracy ?? throw new global::System.ArgumentNullException(nameof(toolCallAccuracy));
            this.TransitionAccuracy = transitionAccuracy ?? throw new global::System.ArgumentNullException(nameof(transitionAccuracy));
            this.NaturalTonalityRate = naturalTonalityRate ?? throw new global::System.ArgumentNullException(nameof(naturalTonalityRate));
            this.CustomToolCallLatency = customToolCallLatency ?? throw new global::System.ArgumentNullException(nameof(customToolCallLatency));
            this.CustomToolCallSuccessRate = customToolCallSuccessRate ?? throw new global::System.ArgumentNullException(nameof(customToolCallSuccessRate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResult" /> class.
        /// </summary>
        public CohortAggregatedResult()
        {
        }
    }
}