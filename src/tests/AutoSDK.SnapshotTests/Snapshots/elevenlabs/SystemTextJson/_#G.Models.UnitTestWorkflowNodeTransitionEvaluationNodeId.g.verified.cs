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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ID of the agent whose workflow contains the target node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The ID of the workflow node that the agent should transition to.
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
        /// Initializes a new instance of the <see cref="UnitTestWorkflowNodeTransitionEvaluationNodeId" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: node_id
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent whose workflow contains the target node.
        /// </param>
        /// <param name="targetNodeId">
        /// The ID of the workflow node that the agent should transition to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnitTestWorkflowNodeTransitionEvaluationNodeId(
            string agentId,
            string targetNodeId,
            string? type)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.TargetNodeId = targetNodeId ?? throw new global::System.ArgumentNullException(nameof(targetNodeId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestWorkflowNodeTransitionEvaluationNodeId" /> class.
        /// </summary>
        public UnitTestWorkflowNodeTransitionEvaluationNodeId()
        {
        }
    }
}