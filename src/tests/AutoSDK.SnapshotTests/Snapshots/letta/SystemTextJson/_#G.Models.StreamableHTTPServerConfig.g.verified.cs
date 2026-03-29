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
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// Default Value: streamable_http
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPServerTypeJsonConverter))]
        public global::G.MCPServerType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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