//HintName: G.Models.StreamableHTTPServerConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for an MCP server using Streamable HTTP
    /// </summary>
    public sealed partial class StreamableHTTPServerConfig
    {
        /// <summary>
        /// The name of the server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerName { get; set; } = default!;

        /// <summary>
        /// Default Value: streamable_http
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPServerTypeJsonConverter))]
        public global::G.MCPServerType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamableHTTPServerConfig" /> class.
        /// </summary>
        /// <param name="serverName">
        /// The name of the server
        /// </param>
        /// <param name="serverUrl">
        /// The URL of the server
        /// </param>
        /// <param name="type">
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
        public StreamableHTTPServerConfig(
            string serverName,
            string serverUrl,
            global::G.MCPServerType? type,
            string? authHeader,
            string? authToken,
            global::System.Collections.Generic.Dictionary<string, string>? customHeaders)
        {
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.Type = type;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.AuthHeader = authHeader;
            this.AuthToken = authToken;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamableHTTPServerConfig" /> class.
        /// </summary>
        public StreamableHTTPServerConfig()
        {
        }
    }
}