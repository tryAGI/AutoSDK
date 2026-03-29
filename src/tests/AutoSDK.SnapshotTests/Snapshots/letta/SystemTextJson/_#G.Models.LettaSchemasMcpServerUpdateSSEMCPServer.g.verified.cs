//HintName: G.Models.LettaSchemasMcpServerUpdateSSEMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update schema for SSE MCP server - all fields optional
    /// </summary>
    public sealed partial class LettaSchemasMcpServerUpdateSSEMCPServer
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
        public string? ServerUrl { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpServerUpdateSSEMCPServer" /> class.
        /// </summary>
        /// <param name="mcpServerType">
        /// Default Value: sse
        /// </param>
        /// <param name="serverUrl">
        /// The URL of the server
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaSchemasMcpServerUpdateSSEMCPServer(
            string? mcpServerType,
            string? serverUrl,
            string? authHeader,
            string? authToken,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders)
        {
            this.McpServerType = mcpServerType;
            this.ServerUrl = serverUrl;
            this.AuthHeader = authHeader;
            this.AuthToken = authToken;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpServerUpdateSSEMCPServer" /> class.
        /// </summary>
        public LettaSchemasMcpServerUpdateSSEMCPServer()
        {
        }
    }
}