//HintName: G.IMcpServersCapabilitiesClient.McpServerCapabilitiesList.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersCapabilitiesClient
    {
        /// <summary>
        /// List MCP Server Capabilities
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="type"></param>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerCapabilitiesListResponse> McpServerCapabilitiesListAsync(
            string mcpServerId,
            int? page = default,
            int? pageSize = default,
            global::G.McpServerCapabilitiesListType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}