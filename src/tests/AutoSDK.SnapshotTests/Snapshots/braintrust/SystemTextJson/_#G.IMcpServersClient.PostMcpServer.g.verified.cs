//HintName: G.IMcpServersClient.PostMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Create mcp_server<br/>
        /// Create a new mcp_server. If there is an existing mcp_server with the same name as the one specified in the request, will return the existing mcp_server unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServer> PostMcpServerAsync(

            global::G.CreateMCPServer request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create mcp_server<br/>
        /// Create a new mcp_server. If there is an existing mcp_server with the same name as the one specified in the request, will return the existing mcp_server unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the MCP server belongs under
        /// </param>
        /// <param name="name">
        /// Name of the MCP server. Within a project, MCP server names are unique
        /// </param>
        /// <param name="description">
        /// Textual description of the MCP server
        /// </param>
        /// <param name="url">
        /// URL of the MCP server endpoint
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServer> PostMcpServerAsync(
            global::System.Guid projectId,
            string name,
            string url,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}