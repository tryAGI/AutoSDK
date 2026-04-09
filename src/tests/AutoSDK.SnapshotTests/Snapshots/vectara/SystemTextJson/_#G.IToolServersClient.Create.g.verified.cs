//HintName: G.IToolServersClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IToolServersClient
    {
        /// <summary>
        /// Create tool server<br/>
        /// Create a new tool server to expose tools for use by agents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolServer> CreateAsync(

            global::G.CreateToolServerRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create tool server<br/>
        /// Create a new tool server to expose tools for use by agents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolServer> CreateAsync(
            string name,
            string uri,
            global::G.ToolServerTransport transport,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.ToolServerType type = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::G.RemoteAuth? auth = default,
            bool? enabled = default,
            object? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}