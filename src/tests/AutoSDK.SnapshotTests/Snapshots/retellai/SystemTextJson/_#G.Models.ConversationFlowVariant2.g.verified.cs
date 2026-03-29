//HintName: G.Models.ConversationFlowVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationFlowVariant2
    {
        /// <summary>
        /// Global prompt used in every node of the conversation flow.<br/>
        /// Example: You are a helpful customer service agent.
        /// </summary>
        /// <example>You are a helpful customer service agent.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_prompt")]
        public string? GlobalPrompt { get; set; }

        /// <summary>
        /// Tools available in the conversation flow.<br/>
        /// Example: [{"type":"custom","name":"get_customer_info","description":"Get customer information from database","tool_id":"tool_001","url":"https://api.example.com/customer","method":"GET"}]
        /// </summary>
        /// <example>[{"type":"custom","name":"get_customer_info","description":"Get customer information from database","tool_id":"tool_001","url":"https://api.example.com/customer","method":"GET"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.NodeTool>? Tools { get; set; }

        /// <summary>
        /// Local components embedded within the conversation flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        public global::System.Collections.Generic.IList<global::G.CreateConversationFlowComponentRequest>? Components { get; set; }

        /// <summary>
        /// ID of the start node in the conversation flow.<br/>
        /// Example: start
        /// </summary>
        /// <example>start</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_node_id")]
        public string? StartNodeId { get; set; }

        /// <summary>
        /// Default dynamic variables that can be referenced throughout the conversation flow.<br/>
        /// Example: {"company_name":"Retell Inc","support_hours":"9 AM - 5 PM"}
        /// </summary>
        /// <example>{"company_name":"Retell Inc","support_hours":"9 AM - 5 PM"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? DefaultDynamicVariables { get; set; }

        /// <summary>
        /// Display position for the begin tag in the frontend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_tag_display_position")]
        public global::G.ConversationFlowVariant2BeginTagDisplayPosition? BeginTagDisplayPosition { get; set; }

        /// <summary>
        /// A list of MCP server configurations to use for this conversation flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcps")]
        public global::System.Collections.Generic.IList<global::G.Mcp>? Mcps { get; set; }

        /// <summary>
        /// Whether this conversation flow is used for transfer LLM.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_transfer_llm")]
        public bool? IsTransferLlm { get; set; }

        /// <summary>
        /// Array of nodes in the conversation flow.<br/>
        /// Example: [{"id":"start","type":"conversation","instruction":{"type":"prompt","text":"Greet the customer and ask how you can help them."},"edges":[{"id":"edge_1","transition_condition":{"type":"prompt","prompt":"Customer wants to book appointment"},"destination_node_id":"book_appointment"}]}]
        /// </summary>
        /// <example>[{"id":"start","type":"conversation","instruction":{"type":"prompt","text":"Greet the customer and ask how you can help them."},"edges":[{"id":"edge_1","transition_condition":{"type":"prompt","prompt":"Customer wants to book appointment"},"destination_node_id":"book_appointment"}]}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::G.ConversationFlowNode>? Nodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowVariant2" /> class.
        /// </summary>
        /// <param name="globalPrompt">
        /// Global prompt used in every node of the conversation flow.<br/>
        /// Example: You are a helpful customer service agent.
        /// </param>
        /// <param name="tools">
        /// Tools available in the conversation flow.<br/>
        /// Example: [{"type":"custom","name":"get_customer_info","description":"Get customer information from database","tool_id":"tool_001","url":"https://api.example.com/customer","method":"GET"}]
        /// </param>
        /// <param name="components">
        /// Local components embedded within the conversation flow.
        /// </param>
        /// <param name="startNodeId">
        /// ID of the start node in the conversation flow.<br/>
        /// Example: start
        /// </param>
        /// <param name="defaultDynamicVariables">
        /// Default dynamic variables that can be referenced throughout the conversation flow.<br/>
        /// Example: {"company_name":"Retell Inc","support_hours":"9 AM - 5 PM"}
        /// </param>
        /// <param name="beginTagDisplayPosition">
        /// Display position for the begin tag in the frontend.
        /// </param>
        /// <param name="mcps">
        /// A list of MCP server configurations to use for this conversation flow.
        /// </param>
        /// <param name="isTransferLlm">
        /// Whether this conversation flow is used for transfer LLM.<br/>
        /// Example: false
        /// </param>
        /// <param name="nodes">
        /// Array of nodes in the conversation flow.<br/>
        /// Example: [{"id":"start","type":"conversation","instruction":{"type":"prompt","text":"Greet the customer and ask how you can help them."},"edges":[{"id":"edge_1","transition_condition":{"type":"prompt","prompt":"Customer wants to book appointment"},"destination_node_id":"book_appointment"}]}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationFlowVariant2(
            string? globalPrompt,
            global::System.Collections.Generic.IList<global::G.NodeTool>? tools,
            global::System.Collections.Generic.IList<global::G.CreateConversationFlowComponentRequest>? components,
            string? startNodeId,
            global::System.Collections.Generic.Dictionary<string, string>? defaultDynamicVariables,
            global::G.ConversationFlowVariant2BeginTagDisplayPosition? beginTagDisplayPosition,
            global::System.Collections.Generic.IList<global::G.Mcp>? mcps,
            bool? isTransferLlm,
            global::System.Collections.Generic.IList<global::G.ConversationFlowNode>? nodes)
        {
            this.GlobalPrompt = globalPrompt;
            this.Tools = tools;
            this.Components = components;
            this.StartNodeId = startNodeId;
            this.DefaultDynamicVariables = defaultDynamicVariables;
            this.BeginTagDisplayPosition = beginTagDisplayPosition;
            this.Mcps = mcps;
            this.IsTransferLlm = isTransferLlm;
            this.Nodes = nodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowVariant2" /> class.
        /// </summary>
        public ConversationFlowVariant2()
        {
        }
    }
}