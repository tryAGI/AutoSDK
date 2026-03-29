//HintName: G.Models.EvalResultsSummaryRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalResultsSummaryRes
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        public int? RowCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        public global::System.Collections.Generic.IList<global::G.EvalResultsEvaluationSummary>? Evaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsSummaryRes" /> class.
        /// </summary>
        /// <param name="rowCount">
        /// Default Value: 0
        /// </param>
        /// <param name="evaluations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalResultsSummaryRes(
            int? rowCount,
            global::System.Collections.Generic.IList<global::G.EvalResultsEvaluationSummary>? evaluations)
        {
            this.RowCount = rowCount;
            this.Evaluations = evaluations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsSummaryRes" /> class.
        /// </summary>
        public EvalResultsSummaryRes()
        {
        }
    }
}