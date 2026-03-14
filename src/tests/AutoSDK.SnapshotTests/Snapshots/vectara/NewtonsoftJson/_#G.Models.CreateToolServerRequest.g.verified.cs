//HintName: G.Models.CreateToolServerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for creating a new tool server.
    /// </summary>
    public sealed partial class CreateToolServerRequest
    {
        /// <summary>
        /// The human-readable name of a tool server.<br/>
        /// Example: RAG Search Server
        /// </summary>
        /// <example>RAG Search Server</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of tool server.<br/>
        /// Example: mcp
        /// </summary>
        /// <example>mcp</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolServerType Type { get; set; }

        /// <summary>
        /// A detailed description of what this tool server does.<br/>
        /// Example: Provides RAG search capabilities for documents.
        /// </summary>
        /// <example>Provides RAG search capabilities for documents.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The URI of the tool server.<br/>
        /// Example: https://api.example.com/rag_search
        /// </summary>
        /// <example>https://api.example.com/rag_search</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Optional HTTP headers to include when connecting to the server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Transport protocol for MCP server connections. Both use Server-Sent Events (SSE).<br/>
        /// - `sse`: Legacy format (https://modelcontextprotocol.io/specification/2024-11-05/basic/transports)<br/>
        /// - `streamable-http`: New format (https://modelcontextprotocol.io/specification/2025-03-26/basic/transports)<br/>
        /// Example: sse
        /// </summary>
        /// <example>sse</example>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolServerTransport Transport { get; set; } = default!;

        /// <summary>
        /// Authentication configuration for an LLM
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth")]
        public global::G.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Whether the tool server is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the tool server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolServerRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of a tool server.<br/>
        /// Example: RAG Search Server
        /// </param>
        /// <param name="type">
        /// The type of tool server.<br/>
        /// Example: mcp
        /// </param>
        /// <param name="description">
        /// A detailed description of what this tool server does.<br/>
        /// Example: Provides RAG search capabilities for documents.
        /// </param>
        /// <param name="uri">
        /// The URI of the tool server.<br/>
        /// Example: https://api.example.com/rag_search
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
        /// Whether the tool server is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the tool server.
        /// </param>
        public CreateToolServerRequest(
            string name,
            string uri,
            global::G.ToolServerTransport transport,
            global::G.ToolServerType type,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::G.RemoteAuth? auth,
            bool? enabled,
            object? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Transport = transport;
            this.Type = type;
            this.Description = description;
            this.Headers = headers;
            this.Auth = auth;
            this.Enabled = enabled;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolServerRequest" /> class.
        /// </summary>
        public CreateToolServerRequest()
        {
        }
    }
}