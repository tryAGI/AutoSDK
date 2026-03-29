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
        [global::Newtonsoft.Json.JsonProperty("evaluations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StructuredOutputEvaluationResult> Evaluations { get; set; } = default!;

        /// <summary>
        /// This indicates whether all required evaluations passed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Passed { get; set; } = default!;

        /// <summary>
        /// This contains the latency metrics collected from the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latencyMetrics")]
        public global::G.LatencyMetrics? LatencyMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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