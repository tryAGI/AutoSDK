//HintName: G.Models.MCPToolConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An MCP tool configuration that can be used to call MCP servers
    /// </summary>
    public sealed partial class MCPToolConfigOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// Default Value: mcp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The type of MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Schema for any parameters the LLM needs to provide to the MCP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.ObjectJsonSchemaPropertyOutput? Parameters { get; set; }

        /// <summary>
        /// The approval policy for the MCP tool<br/>
        /// Default Value: require_approval_all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPApprovalPolicyJsonConverter))]
        public global::G.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// The name of the MCP tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpToolName { get; set; }

        /// <summary>
        /// The description of the MCP tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpToolDescription { get; set; }

        /// <summary>
        /// The id of the MCP server to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerId { get; set; }

        /// <summary>
        /// The name of the MCP server to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// Original inputSchema dict for consistent hashing (pure MCP format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_input_schema")]
        public object? McpInputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOutput" /> class.
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
        /// <param name="integrationType">
        /// The type of MCP tool
        /// </param>
        /// <param name="parameters">
        /// Schema for any parameters the LLM needs to provide to the MCP tool.
        /// </param>
        /// <param name="approvalPolicy">
        /// The approval policy for the MCP tool<br/>
        /// Default Value: require_approval_all
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfigOutput(
            string name,
            string description,
            global::G.IntegrationType integrationType,
            string mcpToolName,
            string mcpToolDescription,
            string mcpServerId,
            string mcpServerName,
            string? id,
            int? responseTimeoutSecs,
            string? type,
            global::G.ObjectJsonSchemaPropertyOutput? parameters,
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
        /// Initializes a new instance of the <see cref="MCPToolConfigOutput" /> class.
        /// </summary>
        public MCPToolConfigOutput()
        {
        }
    }
}