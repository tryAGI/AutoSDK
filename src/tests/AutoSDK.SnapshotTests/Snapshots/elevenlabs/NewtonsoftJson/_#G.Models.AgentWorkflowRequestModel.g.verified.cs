//HintName: G.Models.AgentWorkflowRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer"},{"prompt":"Phone condition"},{"left":{"name":"mode"},"right":{"value":"dev"}}]}},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry"},"failure_node":{"conversation_config":{},"label":"Failure"},"start_node":{"edge_order":["start_to_entry"]},"success_conversation":{"conversation_config":{},"label":"Success A"},"success_end":{},"success_phone":{"transfer_destination":{"phone_number":"\u002B1234567890"}},"success_transfer":{"agent_id":"success_transfer_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}]},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"tools":[{"tool_id":"tool_a"}]}}}
    /// </summary>
    public sealed partial class AgentWorkflowRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges")]
        public global::System.Collections.Generic.Dictionary<string, global::G.WorkflowEdgeModelInput>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes")]
        public object? Nodes { get; set; }

        /// <summary>
        /// Whether to prevent loops in the workflow execution.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prevent_subagent_loops")]
        public bool? PreventSubagentLoops { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkflowRequestModel" /> class.
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="nodes"></param>
        /// <param name="preventSubagentLoops">
        /// Whether to prevent loops in the workflow execution.<br/>
        /// Default Value: false
        /// </param>
        public AgentWorkflowRequestModel(
            global::System.Collections.Generic.Dictionary<string, global::G.WorkflowEdgeModelInput>? edges,
            object? nodes,
            bool? preventSubagentLoops)
        {
            this.Edges = edges;
            this.Nodes = nodes;
            this.PreventSubagentLoops = preventSubagentLoops;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkflowRequestModel" /> class.
        /// </summary>
        public AgentWorkflowRequestModel()
        {
        }
    }
}