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
        [global::System.Text.Json.Serialization.JsonPropertyName("predict_and_score_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PredictAndScoreCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predict_call_id")]
        public string? PredictCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_output")]
        public object? ModelOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public object? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_latency_seconds")]
        public double? ModelLatencySeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_call_ids")]
        public global::System.Collections.Generic.Dictionary<string, string>? ScorerCallIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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