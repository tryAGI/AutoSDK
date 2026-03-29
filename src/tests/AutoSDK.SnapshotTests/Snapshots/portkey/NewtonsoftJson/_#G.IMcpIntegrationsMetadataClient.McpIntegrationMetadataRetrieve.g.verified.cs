//HintName: G.IMcpIntegrationsMetadataClient.McpIntegrationMetadataRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpIntegrationsMetadataClient
    {
        /// <summary>
        /// Get MCP Integration Metadata
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpIntegrationMetadata> McpIntegrationMetadataRetrieveAsync(
            string mcpIntegrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}