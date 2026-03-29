//HintName: G.IMcpServersClient.McpServersList.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// List MCP Servers<br/>
        /// List MCP Servers for the workspace. Requires workspace_id or x-portkey-api-key header.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="currentPage">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerListResponse> McpServersListAsync(
            string? workspaceId = default,
            int? currentPage = default,
            int? pageSize = default,
            string? id = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}