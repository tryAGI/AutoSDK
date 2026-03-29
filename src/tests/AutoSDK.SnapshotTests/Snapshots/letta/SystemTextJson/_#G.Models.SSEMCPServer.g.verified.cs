//HintName: G.Models.SSEMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An SSE MCP server
    /// </summary>
    public sealed partial class SSEMCPServer
    {
        /// <summary>
        /// Default Value: sse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_type")]
        public string? McpServerType { get; set; }

        /// <summary>
        /// The URL of the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// The name of the authentication header (e.g., 'Authorization')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_header")]
        public string? AuthHeader { get; set; }

        /// <summary>
        /// The authentication token or API key value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_token")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// Custom HTTP headers to include with requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomHeaders { get; set; }

        /// <summary>
        /// The human-friendly ID of the Mcp_server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSEMCPServer" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// The URL of the server
        /// </param>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="mcpServerType">
        /// Default Value: sse
        /// </param>
        /// <param name="authHeader">
        /// The name of the authentication header (e.g., 'Authorization')
        /// </param>
        /// <param name="authToken">
        /// The authentication token or API key value
        /// </param>
        /// <param name="customHeaders">
        /// Custom HTTP headers to include with requests
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Mcp_server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSEMCPServer(
            string serverUrl,
            string serverName,
            string? mcpServerType,
            string? authHeader,
            string? authToken,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders,
            string? id)
        {
            this.McpServerType = mcpServerType;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.AuthHeader = authHeader;
            this.AuthToken = authToken;
            this.CustomHeaders = customHeaders;
            this.Id = id;
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSEMCPServer" /> class.
        /// </summary>
        public SSEMCPServer()
        {
        }
    }
}