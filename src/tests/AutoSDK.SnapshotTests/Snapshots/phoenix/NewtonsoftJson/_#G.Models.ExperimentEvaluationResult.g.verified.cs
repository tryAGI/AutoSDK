//HintName: G.Models.ExperimentEvaluationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentEvaluationResult
    {
        /// <summary>
        /// The label assigned by the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// The score assigned by the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Explanation of the evaluation result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentEvaluationResult" /> class.
        /// </summary>
        /// <param name="label">
        /// The label assigned by the evaluation
        /// </param>
        /// <param name="score">
        /// The score assigned by the evaluation
        /// </param>
        /// <param name="explanation">
        /// Explanation of the evaluation result
        /// </param>
        public ExperimentEvaluationResult(
            string? label,
            double? score,
            string? explanation)
        {
            this.Label = label;
            this.Score = score;
            this.Explanation = explanation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentEvaluationResult" /> class.
        /// </summary>
        public ExperimentEvaluationResult()
        {
        }
    }
}