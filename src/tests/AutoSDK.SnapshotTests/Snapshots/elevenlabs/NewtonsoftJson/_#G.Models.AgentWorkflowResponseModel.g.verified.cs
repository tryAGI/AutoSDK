//HintName: G.Models.AgentWorkflowResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"edges":{"entry_to_tool_a":{"forward_condition":{"condition":"Tool A condition","type":"llm"},"source":"entry_node","target":"tool_node_a"},"start_to_entry":{"forward_condition":{"type":"unconditional"},"source":"start_node","target":"entry_node"},"tool_a_to_failure":{"forward_condition":{"successful":false,"type":"result"},"source":"tool_node_a","target":"failure_node"},"tool_a_to_tool_b":{"forward_condition":{"successful":true,"type":"result"},"source":"tool_node_a","target":"tool_node_b"},"tool_b_to_agent_transfer":{"forward_condition":{"type":"unconditional"},"source":"tool_node_b","target":"success_transfer"},"tool_b_to_conversation":{"forward_condition":{"condition":"Conversation condition","type":"llm"},"source":"tool_node_b","target":"success_conversation"},"tool_b_to_end":{"forward_condition":{"condition":"End condition","type":"llm"},"source":"tool_node_b","target":"success_end"},"tool_b_to_phone":{"forward_condition":{"expression":{"children":[{"name":"force_phone_transfer","type":"dynamic_variable"},{"prompt":"Phone condition","type":"llm"},{"left":{"name":"mode","type":"dynamic_variable"},"right":{"type":"string_literal","value":"dev"},"type":"eq_operator"}],"type":"or_operator"},"type":"expression"},"source":"tool_node_b","target":"success_phone"}},"nodes":{"entry_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":["entry_to_tool_a"],"label":"Entry","position":{"x":0.0,"y":0.0},"type":"override_agent"},"failure_node":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Failure","position":{"x":0.0,"y":0.0},"type":"override_agent"},"start_node":{"edge_order":["start_to_entry"],"position":{"x":0.0,"y":0.0},"type":"start"},"success_conversation":{"additional_knowledge_base":[],"additional_prompt":"","additional_tool_ids":[],"conversation_config":{},"edge_order":[],"label":"Success A","position":{"x":0.0,"y":0.0},"type":"override_agent"},"success_end":{"edge_order":[],"position":{"x":0.0,"y":0.0},"type":"end"},"success_phone":{"custom_sip_headers":[],"edge_order":[],"position":{"x":0.0,"y":0.0},"transfer_destination":{"phone_number":"\u002B1234567890","type":"phone"},"transfer_type":"conference","type":"phone_number"},"success_transfer":{"agent_id":"success_transfer_agent","delay_ms":0,"edge_order":[],"enable_transferred_agent_first_message":false,"position":{"x":0.0,"y":0.0},"type":"standalone_agent"},"tool_node_a":{"edge_order":["tool_a_to_failure","tool_a_to_tool_b"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"},{"tool_id":"tool_b"}],"type":"tool"},"tool_node_b":{"edge_order":["tool_b_to_conversation","tool_b_to_end","tool_b_to_phone","tool_b_to_agent_transfer"],"position":{"x":0.0,"y":0.0},"tools":[{"tool_id":"tool_a"}],"type":"tool"}},"prevent_subagent_loops":false}
    /// </summary>
    public sealed partial class AgentWorkflowResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.WorkflowEdgeModelOutput> Edges { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public object Nodes { get; set; } = default!;

        /// <summary>
        /// Whether to prevent loops in the workflow execution.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prevent_subagent_loops", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PreventSubagentLoops { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkflowResponseModel" /> class.
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="nodes"></param>
        /// <param name="preventSubagentLoops">
        /// Whether to prevent loops in the workflow execution.<br/>
        /// Default Value: false
        /// </param>
        public AgentWorkflowResponseModel(
            global::System.Collections.Generic.Dictionary<string, global::G.WorkflowEdgeModelOutput> edges,
            object nodes,
            bool preventSubagentLoops)
        {
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.PreventSubagentLoops = preventSubagentLoops;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkflowResponseModel" /> class.
        /// </summary>
        public AgentWorkflowResponseModel()
        {
        }
    }
}