//HintName: G.Models.LettaSchemasMcpUpdateStreamableHTTPMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update a Streamable HTTP MCP server
    /// </summary>
    public sealed partial class LettaSchemasMcpUpdateStreamableHTTPMCPServer
    {
        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// The URL path for the streamable HTTP server (e.g., 'example/mcp')
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
        /// Custom authentication headers as key-value pairs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpUpdateStreamableHTTPMCPServer" /> class.
        /// </summary>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="serverUrl">
        /// The URL path for the streamable HTTP server (e.g., 'example/mcp')
        /// </param>
        /// <param name="authHeader">
        /// The name of the authentication header (e.g., 'Authorization')
        /// </param>
        /// <param name="authToken">
        /// The authentication token or API key value
        /// </param>
        /// <param name="customHeaders">
        /// Custom authentication headers as key-value pairs
        /// </param>
        public LettaSchemasMcpUpdateStreamableHTTPMCPServer(
            string? serverName,
            string? serverUrl,
            string? authHeader,
            string? authToken,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders)
        {
            this.ServerName = serverName;
            this.ServerUrl = serverUrl;
            this.AuthHeader = authHeader;
            this.AuthToken = authToken;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpUpdateStreamableHTTPMCPServer" /> class.
        /// </summary>
        public LettaSchemasMcpUpdateStreamableHTTPMCPServer()
        {
        }
    }
}