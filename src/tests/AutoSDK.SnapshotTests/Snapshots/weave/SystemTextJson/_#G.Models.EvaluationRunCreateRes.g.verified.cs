//HintName: G.Models.EvaluationRunCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationRunCreateRes
    {
        /// <summary>
        /// The ID of the created evaluation run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluationRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunCreateRes" /> class.
        /// </summary>
        /// <param name="evaluationRunId">
        /// The ID of the created evaluation run
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationRunCreateRes(
            string evaluationRunId)
        {
            this.EvaluationRunId = evaluationRunId ?? throw new global::System.ArgumentNullException(nameof(evaluationRunId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunCreateRes" /> class.
        /// </summary>
        public EvaluationRunCreateRes()
        {
        }
    }
}