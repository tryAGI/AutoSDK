//HintName: G.IToolServersClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IToolServersClient
    {
        /// <summary>
        /// Update tool server<br/>
        /// Update the configuration of a specific tool server.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolServerId">
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolServer> UpdateAsync(
            string toolServerId,

            global::G.UpdateToolServerRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update tool server<br/>
        /// Update the configuration of a specific tool server.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolServerId">
        /// Example: tsr_rag_search
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolServer> UpdateAsync(
            string toolServerId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            string? uri = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::G.ToolServerTransport? transport = default,
            global::G.RemoteAuth? auth = default,
            bool? enabled = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}