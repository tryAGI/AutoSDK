//HintName: G.Models.WorkflowToolMaxIterationsExceededStepModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowToolMaxIterationsExceededStepModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_latency_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StepLatencySecs { get; set; }

        /// <summary>
        /// Default Value: max_iterations_exceeded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_iterations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxIterations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolMaxIterationsExceededStepModel" /> class.
        /// </summary>
        /// <param name="stepLatencySecs"></param>
        /// <param name="maxIterations"></param>
        /// <param name="type">
        /// Default Value: max_iterations_exceeded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowToolMaxIterationsExceededStepModel(
            double stepLatencySecs,
            int maxIterations,
            string? type)
        {
            this.StepLatencySecs = stepLatencySecs;
            this.Type = type;
            this.MaxIterations = maxIterations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolMaxIterationsExceededStepModel" /> class.
        /// </summary>
        public WorkflowToolMaxIterationsExceededStepModel()
        {
        }
    }
}