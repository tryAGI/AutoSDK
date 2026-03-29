//HintName: G.Models.StreamableHTTPMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Streamable HTTP MCP server
    /// </summary>
    public sealed partial class StreamableHTTPMCPServer
    {
        /// <summary>
        /// Default Value: streamable_http
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_type")]
        public string? McpServerType { get; set; }

        /// <summary>
        /// The URL of the server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerUrl { get; set; } = default!;

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
        /// The human-friendly ID of the Mcp_server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamableHTTPMCPServer" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// The URL of the server
        /// </param>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="mcpServerType">
        /// Default Value: streamable_http
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
        public StreamableHTTPMCPServer(
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
        /// Initializes a new instance of the <see cref="StreamableHTTPMCPServer" /> class.
        /// </summary>
        public StreamableHTTPMCPServer()
        {
        }
    }
}