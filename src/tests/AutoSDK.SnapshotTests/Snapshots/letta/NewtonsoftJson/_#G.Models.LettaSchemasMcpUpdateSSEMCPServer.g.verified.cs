//HintName: G.Models.LettaSchemasMcpUpdateSSEMCPServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update an SSE MCP server
    /// </summary>
    public sealed partial class LettaSchemasMcpUpdateSSEMCPServer
    {
        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// The URL of the server (MCP SSE client will connect to this URL)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// The access token or API key for the MCP server (used for SSE authentication)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

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
        /// Initializes a new instance of the <see cref="LettaSchemasMcpUpdateSSEMCPServer" /> class.
        /// </summary>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="serverUrl">
        /// The URL of the server (MCP SSE client will connect to this URL)
        /// </param>
        /// <param name="token">
        /// The access token or API key for the MCP server (used for SSE authentication)
        /// </param>
        /// <param name="customHeaders">
        /// Custom authentication headers as key-value pairs
        /// </param>
        public LettaSchemasMcpUpdateSSEMCPServer(
            string? serverName,
            string? serverUrl,
            string? token,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders)
        {
            this.ServerName = serverName;
            this.ServerUrl = serverUrl;
            this.Token = token;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMcpUpdateSSEMCPServer" /> class.
        /// </summary>
        public LettaSchemasMcpUpdateSSEMCPServer()
        {
        }
    }
}