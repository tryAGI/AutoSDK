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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// The description of the MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolDescription { get; set; }

        /// <summary>
        /// The input schema of the MCP tool (the schema defined on the MCP server before ElevenLabs does any extra processing)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Defines the tool-level approval policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPToolApprovalPolicyJsonConverter))]
        public global::G.MCPToolApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// Defines the tool-level approval policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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