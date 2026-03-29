//HintName: G.Models.EvalResultsEvaluationSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalResultsEvaluationSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvaluationCallId { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trial_count")]
        public int? TrialCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorer_stats")]
        public global::System.Collections.Generic.IList<global::G.EvalResultsScorerStats>? ScorerStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_ref")]
        public string? EvaluationRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_ref")]
        public string? ModelRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsEvaluationSummary" /> class.
        /// </summary>
        /// <param name="evaluationCallId"></param>
        /// <param name="trialCount">
        /// Default Value: 0
        /// </param>
        /// <param name="scorerStats"></param>
        /// <param name="evaluationRef"></param>
        /// <param name="modelRef"></param>
        /// <param name="displayName"></param>
        /// <param name="traceId"></param>
        /// <param name="startedAt"></param>
        public EvalResultsEvaluationSummary(
            string evaluationCallId,
            int? trialCount,
            global::System.Collections.Generic.IList<global::G.EvalResultsScorerStats>? scorerStats,
            string? evaluationRef,
            string? modelRef,
            string? displayName,
            string? traceId,
            string? startedAt)
        {
            this.EvaluationCallId = evaluationCallId ?? throw new global::System.ArgumentNullException(nameof(evaluationCallId));
            this.TrialCount = trialCount;
            this.ScorerStats = scorerStats;
            this.EvaluationRef = evaluationRef;
            this.ModelRef = modelRef;
            this.DisplayName = displayName;
            this.TraceId = traceId;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsEvaluationSummary" /> class.
        /// </summary>
        public EvalResultsEvaluationSummary()
        {
        }
    }
}