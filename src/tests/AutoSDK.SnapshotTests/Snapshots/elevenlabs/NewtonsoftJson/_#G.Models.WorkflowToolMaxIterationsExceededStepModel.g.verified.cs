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
        [global::Newtonsoft.Json.JsonProperty("step_latency_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public double StepLatencySecs { get; set; } = default!;

        /// <summary>
        /// Default Value: max_iterations_exceeded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_iterations", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxIterations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolMaxIterationsExceededStepModel" /> class.
        /// </summary>
        /// <param name="stepLatencySecs"></param>
        /// <param name="type">
        /// Default Value: max_iterations_exceeded
        /// </param>
        /// <param name="maxIterations"></param>
        public WorkflowToolMaxIterationsExceededStepModel(
            double stepLatencySecs,
            int maxIterations,
            string? type)
        {
            this.StepLatencySecs = stepLatencySecs;
            this.MaxIterations = maxIterations;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolMaxIterationsExceededStepModel" /> class.
        /// </summary>
        public WorkflowToolMaxIterationsExceededStepModel()
        {
        }
    }
}