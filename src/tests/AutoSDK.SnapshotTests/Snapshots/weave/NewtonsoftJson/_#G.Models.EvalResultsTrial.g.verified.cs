//HintName: G.Models.EvalResultsTrial.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalResultsTrial
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predict_and_score_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PredictAndScoreCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predict_call_id")]
        public string? PredictCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_output")]
        public object? ModelOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores")]
        public object? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_latency_seconds")]
        public double? ModelLatencySeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorer_call_ids")]
        public global::System.Collections.Generic.Dictionary<string, string>? ScorerCallIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsTrial" /> class.
        /// </summary>
        /// <param name="predictAndScoreCallId"></param>
        /// <param name="predictCallId"></param>
        /// <param name="modelOutput"></param>
        /// <param name="scores"></param>
        /// <param name="modelLatencySeconds"></param>
        /// <param name="totalTokens"></param>
        /// <param name="scorerCallIds"></param>
        public EvalResultsTrial(
            string predictAndScoreCallId,
            string? predictCallId,
            object? modelOutput,
            object? scores,
            double? modelLatencySeconds,
            int? totalTokens,
            global::System.Collections.Generic.Dictionary<string, string>? scorerCallIds)
        {
            this.PredictAndScoreCallId = predictAndScoreCallId ?? throw new global::System.ArgumentNullException(nameof(predictAndScoreCallId));
            this.PredictCallId = predictCallId;
            this.ModelOutput = modelOutput;
            this.Scores = scores;
            this.ModelLatencySeconds = modelLatencySeconds;
            this.TotalTokens = totalTokens;
            this.ScorerCallIds = scorerCallIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsTrial" /> class.
        /// </summary>
        public EvalResultsTrial()
        {
        }
    }
}