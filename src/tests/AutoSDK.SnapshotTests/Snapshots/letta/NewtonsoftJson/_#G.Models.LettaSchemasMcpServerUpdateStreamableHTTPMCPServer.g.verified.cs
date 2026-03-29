//HintName: G.Models.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update schema for Streamable HTTP MCP server - all fields optional
    /// </summary>
    public sealed partial class LettaSchemasMcpServerUpdateStreamableHTTPMCPServer
    {
        /// <summary>
        /// Default Value: streamable_http
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_type")]
        public string? McpServerType { get; set; }

        /// <summary>
        /// The URL of the server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// The name of the authentication header (e.g., 'Authorization')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_header")]
        public string? AuthHeader { get; set; }

        /// <summary>
        /// The authentication token or API key value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_token")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// Custom HTTP headers to include with requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpServerUpdateStreamableHTTPMCPServer" /> class.
        /// </summary>
        /// <param name="mcpServerType">
        /// Default Value: streamable_http
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
        public LettaSchemasMcpServerUpdateStreamableHTTPMCPServer(
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
        /// Initializes a new instance of the <see cref="LettaSchemasMcpServerUpdateStreamableHTTPMCPServer" /> class.
        /// </summary>
        public LettaSchemasMcpServerUpdateStreamableHTTPMCPServer()
        {
        }
    }
}