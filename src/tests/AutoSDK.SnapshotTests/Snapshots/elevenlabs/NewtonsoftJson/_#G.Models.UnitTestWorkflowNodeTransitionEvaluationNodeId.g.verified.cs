//HintName: G.Models.UnitTestWorkflowNodeTransitionEvaluationNodeId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnitTestWorkflowNodeTransitionEvaluationNodeId
    {
        /// <summary>
        /// Default Value: node_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ID of the agent whose workflow contains the target node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The ID of the workflow node that the agent should transition to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetNodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestWorkflowNodeTransitionEvaluationNodeId" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent whose workflow contains the target node.
        /// </param>
        /// <param name="targetNodeId">
        /// The ID of the workflow node that the agent should transition to.
        /// </param>
        /// <param name="type">
        /// Default Value: node_id
        /// </param>
        public UnitTestWorkflowNodeTransitionEvaluationNodeId(
            string agentId,
            string targetNodeId,
            string? type)
        {
            this.Type = type;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.TargetNodeId = targetNodeId ?? throw new global::System.ArgumentNullException(nameof(targetNodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestWorkflowNodeTransitionEvaluationNodeId" /> class.
        /// </summary>
        public UnitTestWorkflowNodeTransitionEvaluationNodeId()
        {
        }
    }
}