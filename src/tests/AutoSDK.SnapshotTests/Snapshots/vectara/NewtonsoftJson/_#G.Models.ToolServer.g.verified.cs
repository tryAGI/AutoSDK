//HintName: G.Models.ToolServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a tool server that can provide various functionalities.
    /// </summary>
    public sealed partial class ToolServer
    {
        /// <summary>
        /// Unique identifier for a tool server.<br/>
        /// Example: tsr_rag_search
        /// </summary>
        /// <example>tsr_rag_search</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolServerTypeJsonConverter))]
        public global::G.ToolServerType Type { get; set; }

        /// <summary>
        /// A detailed description of what this tool server does.<br/>
        /// Example: Provides RAG search capabilities for documents.
        /// </summary>
        /// <example>Provides RAG search capabilities for documents.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The URI of the server.<br/>
        /// Example: https://api.example.com/sse/
        /// </summary>
        /// <example>https://api.example.com/sse/</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Optional HTTP headers to include when connecting to the server.<br/>
        /// Example: {"Content-Type":"application/json"}
        /// </summary>
        /// <example>{"Content-Type":"application/json"}</example>
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolServerTransportJsonConverter))]
        public global::G.ToolServerTransport Transport { get; set; } = default!;

        /// <summary>
        /// Whether the tool server is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Arbitrary metadata associated with the tool server.<br/>
        /// Example: {"version":"1.0"}
        /// </summary>
        /// <example>{"version":"1.0"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Timestamp when the tool server was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the tool server was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolServer" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of a tool server.<br/>
        /// Example: RAG Search Server
        /// </param>
        /// <param name="uri">
        /// The URI of the server.<br/>
        /// Example: https://api.example.com/sse/
        /// </param>
        /// <param name="transport">
        /// Transport protocol for MCP server connections. Both use Server-Sent Events (SSE).<br/>
        /// - `sse`: Legacy format (https://modelcontextprotocol.io/specification/2024-11-05/basic/transports)<br/>
        /// - `streamable-http`: New format (https://modelcontextprotocol.io/specification/2025-03-26/basic/transports)<br/>
        /// Example: sse
        /// </param>
        /// <param name="enabled">
        /// Whether the tool server is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="id">
        /// Unique identifier for a tool server.<br/>
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="type">
        /// The type of tool server.<br/>
        /// Example: mcp
        /// </param>
        /// <param name="description">
        /// A detailed description of what this tool server does.<br/>
        /// Example: Provides RAG search capabilities for documents.
        /// </param>
        /// <param name="headers">
        /// Optional HTTP headers to include when connecting to the server.<br/>
        /// Example: {"Content-Type":"application/json"}
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the tool server.<br/>
        /// Example: {"version":"1.0"}
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the tool server was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the tool server was last updated.
        /// </param>
        public ToolServer(
            string name,
            string uri,
            global::G.ToolServerTransport transport,
            bool enabled,
            string? id,
            global::G.ToolServerType type,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Headers = headers;
            this.Transport = transport;
            this.Enabled = enabled;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolServer" /> class.
        /// </summary>
        public ToolServer()
        {
        }
    }
}