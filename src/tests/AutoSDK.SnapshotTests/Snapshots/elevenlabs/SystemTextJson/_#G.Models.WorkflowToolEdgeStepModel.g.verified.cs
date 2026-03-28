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
        [global::System.Text.Json.Serialization.JsonPropertyName("step_latency_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StepLatencySecs { get; set; }

        /// <summary>
        /// Default Value: edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EdgeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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