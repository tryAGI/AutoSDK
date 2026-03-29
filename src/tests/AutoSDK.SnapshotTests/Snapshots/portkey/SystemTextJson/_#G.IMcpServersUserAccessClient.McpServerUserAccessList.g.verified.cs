//HintName: G.IMcpServersUserAccessClient.McpServerUserAccessList.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersUserAccessClient
    {
        /// <summary>
        /// List MCP Server User Access
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="search"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerUserAccessListResponse> McpServerUserAccessListAsync(
            string mcpServerId,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}