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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPToolTypeJsonConverter))]
        public global::G.MCPToolType Type { get; set; }

        /// <summary>
        /// A label for this MCP server, used to identify it in tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// The URL for the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// Optional HTTP headers to send to the MCP server. Use for authentication<br/>
        /// or other purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// List of allowed tool names or a filter object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::G.MCPToolAllowedTools>))]
        public global::G.OneOf<global::System.Collections.Generic.IList<string>, global::G.MCPToolAllowedTools>? AllowedTools { get; set; }

        /// <summary>
        /// Specify which of the MCP server's tools require approval.<br/>
        /// Default Value: always
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MCPToolRequireApprovalEnum, global::G.MCPToolRequireApprovalEnum2?>))]
        public global::G.OneOf<global::G.MCPToolRequireApprovalEnum, global::G.MCPToolRequireApprovalEnum2?>? RequireApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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