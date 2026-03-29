//HintName: G.Models.ConversationFlowComponent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationFlowComponent
    {
        /// <summary>
        /// Name of the component<br/>
        /// Example: Customer Information Collector
        /// </summary>
        /// <example>Customer Information Collector</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tools available within the component<br/>
        /// Example: [{"type":"custom","name":"get_customer_info","description":"Get customer information from database","tool_id":"tool_001","url":"https://api.example.com/customer","method":"GET"}]
        /// </summary>
        /// <example>[{"type":"custom","name":"get_customer_info","description":"Get customer information from database","tool_id":"tool_001","url":"https://api.example.com/customer","method":"GET"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.NodeTool>? Tools { get; set; }

        /// <summary>
        /// A list of MCP server configurations to use for this component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcps")]
        public global::System.Collections.Generic.IList<global::G.Mcp>? Mcps { get; set; }

        /// <summary>
        /// Nodes that make up the component<br/>
        /// Example: [{"id":"collect_info","type":"conversation","instruction":{"type":"prompt","text":"Ask the customer for their name and contact information."}}]
        /// </summary>
        /// <example>[{"id":"collect_info","type":"conversation","instruction":{"type":"prompt","text":"Ask the customer for their name and contact information."}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::G.ConversationFlowNode>? Nodes { get; set; }

        /// <summary>
        /// ID of the starting node<br/>
        /// Example: collect_info
        /// </summary>
        /// <example>collect_info</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_node_id")]
        public string? StartNodeId { get; set; }

        /// <summary>
        /// Display position for the begin tag in the frontend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_tag_display_position")]
        public global::G.ConversationFlowComponentBeginTagDisplayPosition? BeginTagDisplayPosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowComponent" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the component<br/>
        /// Example: Customer Information Collector
        /// </param>
        /// <param name="tools">
        /// Tools available within the component<br/>
        /// Example: [{"type":"custom","name":"get_customer_info","description":"Get customer information from database","tool_id":"tool_001","url":"https://api.example.com/customer","method":"GET"}]
        /// </param>
        /// <param name="mcps">
        /// A list of MCP server configurations to use for this component
        /// </param>
        /// <param name="nodes">
        /// Nodes that make up the component<br/>
        /// Example: [{"id":"collect_info","type":"conversation","instruction":{"type":"prompt","text":"Ask the customer for their name and contact information."}}]
        /// </param>
        /// <param name="startNodeId">
        /// ID of the starting node<br/>
        /// Example: collect_info
        /// </param>
        /// <param name="beginTagDisplayPosition">
        /// Display position for the begin tag in the frontend
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationFlowComponent(
            string? name,
            global::System.Collections.Generic.IList<global::G.NodeTool>? tools,
            global::System.Collections.Generic.IList<global::G.Mcp>? mcps,
            global::System.Collections.Generic.IList<global::G.ConversationFlowNode>? nodes,
            string? startNodeId,
            global::G.ConversationFlowComponentBeginTagDisplayPosition? beginTagDisplayPosition)
        {
            this.Name = name;
            this.Tools = tools;
            this.Mcps = mcps;
            this.Nodes = nodes;
            this.StartNodeId = startNodeId;
            this.BeginTagDisplayPosition = beginTagDisplayPosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowComponent" /> class.
        /// </summary>
        public ConversationFlowComponent()
        {
        }
    }
}