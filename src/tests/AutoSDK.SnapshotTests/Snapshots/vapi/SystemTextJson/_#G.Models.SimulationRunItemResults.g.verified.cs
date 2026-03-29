//HintName: G.Models.SimulationRunItemResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItemResults
    {
        /// <summary>
        /// This is the list of results from structured output evaluations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StructuredOutputEvaluationResult> Evaluations { get; set; }

        /// <summary>
        /// This indicates whether all required evaluations passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// This contains the latency metrics collected from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyMetrics")]
        public global::G.LatencyMetrics? LatencyMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemResults" /> class.
        /// </summary>
        /// <param name="evaluations">
        /// This is the list of results from structured output evaluations.
        /// </param>
        /// <param name="passed">
        /// This indicates whether all required evaluations passed.
        /// </param>
        /// <param name="latencyMetrics">
        /// This contains the latency metrics collected from the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItemResults(
            global::System.Collections.Generic.IList<global::G.StructuredOutputEvaluationResult> evaluations,
            bool passed,
            global::G.LatencyMetrics? latencyMetrics)
        {
            this.Evaluations = evaluations ?? throw new global::System.ArgumentNullException(nameof(evaluations));
            this.Passed = passed;
            this.LatencyMetrics = latencyMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemResults" /> class.
        /// </summary>
        public SimulationRunItemResults()
        {
        }
    }
}