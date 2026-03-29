//HintName: G.Models.EvalResultsRowEvaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalResultsRowEvaluation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluationCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trials")]
        public global::System.Collections.Generic.IList<global::G.EvalResultsTrial>? Trials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsRowEvaluation" /> class.
        /// </summary>
        /// <param name="evaluationCallId"></param>
        /// <param name="trials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalResultsRowEvaluation(
            string evaluationCallId,
            global::System.Collections.Generic.IList<global::G.EvalResultsTrial>? trials)
        {
            this.EvaluationCallId = evaluationCallId ?? throw new global::System.ArgumentNullException(nameof(evaluationCallId));
            this.Trials = trials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsRowEvaluation" /> class.
        /// </summary>
        public EvalResultsRowEvaluation()
        {
        }
    }
}