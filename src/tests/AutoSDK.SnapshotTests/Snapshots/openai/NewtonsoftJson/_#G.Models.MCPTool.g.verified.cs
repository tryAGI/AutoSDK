//HintName: G.Models.MCPTool.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Give the model access to additional tools via remote Model Context Protocol <br/>
    /// (MCP) servers. [Learn more about MCP](/docs/guides/tools-remote-mcp).
    /// </summary>
    public sealed partial class MCPTool
    {
        /// <summary>
        /// The type of the MCP tool. Always `mcp`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MCPToolType Type { get; set; }

        /// <summary>
        /// A label for this MCP server, used to identify it in tool calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerLabel { get; set; } = default!;

        /// <summary>
        /// The URL for the MCP server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerUrl { get; set; } = default!;

        /// <summary>
        /// Optional HTTP headers to send to the MCP server. Use for authentication<br/>
        /// or other purposes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// List of allowed tool names or a filter object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_tools")]
        public global::G.OneOf<global::System.Collections.Generic.IList<string>, global::G.MCPToolAllowedTools>? AllowedTools { get; set; }

        /// <summary>
        /// Specify which of the MCP server's tools require approval.<br/>
        /// Default Value: always
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_approval")]
        public global::G.OneOf<global::G.MCPToolRequireApprovalEnum, global::G.MCPToolRequireApprovalEnum2?>? RequireApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the MCP tool. Always `mcp`.
        /// </param>
        /// <param name="serverLabel">
        /// A label for this MCP server, used to identify it in tool calls.
        /// </param>
        /// <param name="serverUrl">
        /// The URL for the MCP server.
        /// </param>
        /// <param name="headers">
        /// Optional HTTP headers to send to the MCP server. Use for authentication<br/>
        /// or other purposes.
        /// </param>
        /// <param name="allowedTools">
        /// List of allowed tool names or a filter object.
        /// </param>
        /// <param name="requireApproval">
        /// Specify which of the MCP server's tools require approval.<br/>
        /// Default Value: always
        /// </param>
        public MCPTool(
            string serverLabel,
            string serverUrl,
            global::G.MCPToolType type,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, global::G.MCPToolAllowedTools>? allowedTools,
            global::G.OneOf<global::G.MCPToolRequireApprovalEnum, global::G.MCPToolRequireApprovalEnum2?>? requireApproval)
        {
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.Type = type;
            this.Headers = headers;
            this.AllowedTools = allowedTools;
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        public MCPTool()
        {
        }
    }
}