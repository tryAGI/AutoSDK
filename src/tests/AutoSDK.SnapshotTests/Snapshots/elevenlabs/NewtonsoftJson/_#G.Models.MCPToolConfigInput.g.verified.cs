//HintName: G.Models.MCPToolConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An MCP tool configuration that can be used to call MCP servers
    /// </summary>
    public sealed partial class MCPToolConfigInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// Default Value: mcp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MCPToolConfigInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IntegrationType IntegrationType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ObjectJsonSchemaPropertyInput? Parameters { get; set; }

        /// <summary>
        /// Defines the MCP server-level approval policy for tool execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_policy")]
        public global::G.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// The name of the MCP tool to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpToolName { get; set; } = default!;

        /// <summary>
        /// The description of the MCP tool to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_tool_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpToolDescription { get; set; } = default!;

        /// <summary>
        /// The id of the MCP server to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpServerId { get; set; } = default!;

        /// <summary>
        /// The name of the MCP server to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpServerName { get; set; } = default!;

        /// <summary>
        /// Original inputSchema dict for consistent hashing (pure MCP format)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_input_schema")]
        public object? McpInputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
        /// <param name="integrationType"></param>
        /// <param name="parameters"></param>
        /// <param name="approvalPolicy">
        /// Defines the MCP server-level approval policy for tool execution.
        /// </param>
        /// <param name="mcpToolName">
        /// The name of the MCP tool to call
        /// </param>
        /// <param name="mcpToolDescription">
        /// The description of the MCP tool to call
        /// </param>
        /// <param name="mcpServerId">
        /// The id of the MCP server to call
        /// </param>
        /// <param name="mcpServerName">
        /// The name of the MCP server to call
        /// </param>
        /// <param name="mcpInputSchema">
        /// Original inputSchema dict for consistent hashing (pure MCP format)
        /// </param>
        public MCPToolConfigInput(
            string name,
            string description,
            global::G.IntegrationType integrationType,
            string mcpToolName,
            string mcpToolDescription,
            string mcpServerId,
            string mcpServerName,
            string? id,
            int? responseTimeoutSecs,
            global::G.MCPToolConfigInputType? type,
            global::G.ObjectJsonSchemaPropertyInput? parameters,
            global::G.MCPApprovalPolicy? approvalPolicy,
            object? mcpInputSchema)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IntegrationType = integrationType;
            this.McpToolName = mcpToolName ?? throw new global::System.ArgumentNullException(nameof(mcpToolName));
            this.McpToolDescription = mcpToolDescription ?? throw new global::System.ArgumentNullException(nameof(mcpToolDescription));
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.Id = id;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Type = type;
            this.Parameters = parameters;
            this.ApprovalPolicy = approvalPolicy;
            this.McpInputSchema = mcpInputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInput" /> class.
        /// </summary>
        public MCPToolConfigInput()
        {
        }
    }
}