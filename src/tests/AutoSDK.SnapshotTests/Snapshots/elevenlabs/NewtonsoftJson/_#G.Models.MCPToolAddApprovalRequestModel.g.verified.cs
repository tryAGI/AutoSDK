//HintName: G.Models.MCPToolAddApprovalRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for adding approval for a single MCP tool.
    /// </summary>
    public sealed partial class MCPToolAddApprovalRequestModel
    {
        /// <summary>
        /// The name of the MCP tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// The description of the MCP tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolDescription { get; set; } = default!;

        /// <summary>
        /// The input schema of the MCP tool (the schema defined on the MCP server before ElevenLabs does any extra processing)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// The tool-level approval policy<br/>
        /// Default Value: requires_approval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_policy")]
        public global::G.MCPToolApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolAddApprovalRequestModel" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the MCP tool
        /// </param>
        /// <param name="toolDescription">
        /// The description of the MCP tool
        /// </param>
        /// <param name="inputSchema">
        /// The input schema of the MCP tool (the schema defined on the MCP server before ElevenLabs does any extra processing)
        /// </param>
        /// <param name="approvalPolicy">
        /// The tool-level approval policy<br/>
        /// Default Value: requires_approval
        /// </param>
        public MCPToolAddApprovalRequestModel(
            string toolName,
            string toolDescription,
            object? inputSchema,
            global::G.MCPToolApprovalPolicy? approvalPolicy)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolDescription = toolDescription ?? throw new global::System.ArgumentNullException(nameof(toolDescription));
            this.InputSchema = inputSchema;
            this.ApprovalPolicy = approvalPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolAddApprovalRequestModel" /> class.
        /// </summary>
        public MCPToolAddApprovalRequestModel()
        {
        }
    }
}