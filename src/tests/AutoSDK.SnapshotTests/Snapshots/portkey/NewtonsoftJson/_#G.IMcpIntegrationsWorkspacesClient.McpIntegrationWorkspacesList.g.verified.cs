//HintName: G.IMcpIntegrationsWorkspacesClient.McpIntegrationWorkspacesList.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpIntegrationsWorkspacesClient
    {
        /// <summary>
        /// List MCP Integration Workspaces
        /// </summary>
        /// <param name="version"></param>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::G.McpIntegrationWorkspacesListResponse, global::G.McpIntegrationWorkspacesLegacyResponse>> McpIntegrationWorkspacesListAsync(
            string mcpIntegrationId,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}