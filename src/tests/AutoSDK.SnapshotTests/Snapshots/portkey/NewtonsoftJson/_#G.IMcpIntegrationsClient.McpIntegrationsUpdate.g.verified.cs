//HintName: G.IMcpIntegrationsClient.McpIntegrationsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpIntegrationsClient
    {
        /// <summary>
        /// Update MCP Integration
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpIntegrationsUpdateAsync(
            string mcpIntegrationId,

            global::G.UpdateMcpIntegration request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update MCP Integration
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="configurations">
        /// Auth/config key-value pairs (e.g. headers, client credentials)
        /// </param>
        /// <param name="url"></param>
        /// <param name="authType"></param>
        /// <param name="transport"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> McpIntegrationsUpdateAsync(
            string mcpIntegrationId,
            string? name = default,
            string? description = default,
            global::G.UpdateMcpIntegrationConfigurations? configurations = default,
            string? url = default,
            global::G.UpdateMcpIntegrationAuthType? authType = default,
            global::G.UpdateMcpIntegrationTransport? transport = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}