//HintName: G.Models.WorkflowToolEdgeStepModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowToolEdgeStepModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_latency_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public double StepLatencySecs { get; set; } = default!;

        /// <summary>
        /// Default Value: edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edge_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EdgeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetNodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolEdgeStepModel" /> class.
        /// </summary>
        /// <param name="stepLatencySecs"></param>
        /// <param name="edgeId"></param>
        /// <param name="targetNodeId"></param>
        /// <param name="type">
        /// Default Value: edge
        /// </param>
        public WorkflowToolEdgeStepModel(
            double stepLatencySecs,
            string edgeId,
            string targetNodeId,
            string? type)
        {
            this.StepLatencySecs = stepLatencySecs;
            this.Type = type;
            this.EdgeId = edgeId ?? throw new global::System.ArgumentNullException(nameof(edgeId));
            this.TargetNodeId = targetNodeId ?? throw new global::System.ArgumentNullException(nameof(targetNodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolEdgeStepModel" /> class.
        /// </summary>
        public WorkflowToolEdgeStepModel()
        {
        }
    }
}