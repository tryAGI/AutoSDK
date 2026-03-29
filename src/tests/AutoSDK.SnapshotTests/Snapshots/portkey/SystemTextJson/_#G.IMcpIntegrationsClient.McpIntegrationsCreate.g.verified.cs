//HintName: G.IMcpIntegrationsClient.McpIntegrationsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpIntegrationsClient
    {
        /// <summary>
        /// Create MCP Integration<br/>
        /// Create a new MCP Integration. Requires either organisation_id (with admin API key) or workspace_id in body.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpIntegrationCreateResponse> McpIntegrationsCreateAsync(

            global::G.CreateMcpIntegration request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create MCP Integration<br/>
        /// Create a new MCP Integration. Requires either organisation_id (with admin API key) or workspace_id in body.
        /// </summary>
        /// <param name="organisationId">
        /// Organisation ID (optional; required when using org admin API key without workspace_id)
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID (optional; to create at workspace level)
        /// </param>
        /// <param name="slug">
        /// Optional slug; must be unique within organisation
        /// </param>
        /// <param name="name">
        /// Display name of the MCP integration
        /// </param>
        /// <param name="description"></param>
        /// <param name="configurations">
        /// Auth/config key-value pairs (e.g. headers, client credentials)
        /// </param>
        /// <param name="url">
        /// MCP server URL
        /// </param>
        /// <param name="authType"></param>
        /// <param name="transport"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpIntegrationCreateResponse> McpIntegrationsCreateAsync(
            string name,
            string url,
            global::G.CreateMcpIntegrationAuthType authType,
            global::G.CreateMcpIntegrationTransport transport,
            global::System.Guid? organisationId = default,
            global::System.Guid? workspaceId = default,
            string? slug = default,
            string? description = default,
            global::G.CreateMcpIntegrationConfigurations? configurations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}