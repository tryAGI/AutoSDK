//HintName: G.Models.StreamableHttpTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A transport that can stream HTTP requests and responses. Next ID: 6
    /// </summary>
    public sealed partial class StreamableHttpTransport
    {
        /// <summary>
        /// The full URL for the MCPServer endpoint. Example: "https://api.example.com/mcp"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Optional: Fields for authentication headers, timeouts, etc., if needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// HTTP timeout for regular operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public string? Timeout { get; set; }

        /// <summary>
        /// Timeout for SSE read operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sseReadTimeout")]
        public string? SseReadTimeout { get; set; }

        /// <summary>
        /// Whether to close the client session when the transport closes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminateOnClose")]
        public bool? TerminateOnClose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamableHttpTransport" /> class.
        /// </summary>
        /// <param name="url">
        /// The full URL for the MCPServer endpoint. Example: "https://api.example.com/mcp"
        /// </param>
        /// <param name="headers">
        /// Optional: Fields for authentication headers, timeouts, etc., if needed.
        /// </param>
        /// <param name="timeout">
        /// HTTP timeout for regular operations.
        /// </param>
        /// <param name="sseReadTimeout">
        /// Timeout for SSE read operations.
        /// </param>
        /// <param name="terminateOnClose">
        /// Whether to close the client session when the transport closes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamableHttpTransport(
            string? url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? timeout,
            string? sseReadTimeout,
            bool? terminateOnClose)
        {
            this.Url = url;
            this.Headers = headers;
            this.Timeout = timeout;
            this.SseReadTimeout = sseReadTimeout;
            this.TerminateOnClose = terminateOnClose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamableHttpTransport" /> class.
        /// </summary>
        public StreamableHttpTransport()
        {
        }
    }
}