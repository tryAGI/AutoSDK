//HintName: G.IMcpServersClient.PutMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Create or replace mcp_server<br/>
        /// Create or replace mcp_server. If there is an existing mcp_server with the same name as the one specified in the request, will replace the existing mcp_server with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServer> PutMcpServerAsync(

            global::G.CreateMCPServer request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace mcp_server<br/>
        /// Create or replace mcp_server. If there is an existing mcp_server with the same name as the one specified in the request, will replace the existing mcp_server with the provided fields
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServer> PutMcpServerAsync(
            global::System.Guid projectId,
            string name,
            string url,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}