//HintName: G.Models.UpdateToolServerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for updating an existing tool server.
    /// </summary>
    public sealed partial class UpdateToolServerRequest
    {
        /// <summary>
        /// The human-readable name of a tool server.<br/>
        /// Example: RAG Search Server
        /// </summary>
        /// <example>RAG Search Server</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A detailed description of what this tool server does.<br/>
        /// Example: Provides Vectara specific functionalities.
        /// </summary>
        /// <example>Provides Vectara specific functionalities.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The URI of the tool server.<br/>
        /// Example: https://api.example.com/vectara_mcp/sse/
        /// </summary>
        /// <example>https://api.example.com/vectara_mcp/sse/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Optional HTTP headers to include when connecting to the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Transport protocol for MCP server connections. Both use Server-Sent Events (SSE).<br/>
        /// - `sse`: Legacy format (https://modelcontextprotocol.io/specification/2024-11-05/basic/transports)<br/>
        /// - `streamable-http`: New format (https://modelcontextprotocol.io/specification/2025-03-26/basic/transports)<br/>
        /// Example: sse
        /// </summary>
        /// <example>sse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolServerTransportJsonConverter))]
        public global::G.ToolServerTransport? Transport { get; set; }

        /// <summary>
        /// Authentication configuration for an LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoteAuthJsonConverter))]
        public global::G.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Whether the tool server is currently enabled and available for use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the tool server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolServerRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of a tool server.<br/>
        /// Example: RAG Search Server
        /// </param>
        /// <param name="description">
        /// A detailed description of what this tool server does.<br/>
        /// Example: Provides Vectara specific functionalities.
        /// </param>
        /// <param name="uri">
        /// The URI of the tool server.<br/>
        /// Example: https://api.example.com/vectara_mcp/sse/
        /// </param>
        /// <param name="headers">
        /// Optional HTTP headers to include when connecting to the server.
        /// </param>
        /// <param name="transport">
        /// Transport protocol for MCP server connections. Both use Server-Sent Events (SSE).<br/>
        /// - `sse`: Legacy format (https://modelcontextprotocol.io/specification/2024-11-05/basic/transports)<br/>
        /// - `streamable-http`: New format (https://modelcontextprotocol.io/specification/2025-03-26/basic/transports)<br/>
        /// Example: sse
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for an LLM
        /// </param>
        /// <param name="enabled">
        /// Whether the tool server is currently enabled and available for use.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the tool server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateToolServerRequest(
            string? name,
            string? description,
            string? uri,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::G.ToolServerTransport? transport,
            global::G.RemoteAuth? auth,
            bool? enabled,
            object? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Uri = uri;
            this.Headers = headers;
            this.Transport = transport;
            this.Auth = auth;
            this.Enabled = enabled;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolServerRequest" /> class.
        /// </summary>
        public UpdateToolServerRequest()
        {
        }
    }
}