//HintName: G.IApi.GetMCPTools.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get MCP tools for a specific agent
        /// </summary>
        /// <param name="agentId">
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="mcpId">
        /// Example: mcp-server-1
        /// </param>
        /// <param name="componentId">
        /// Example: component-123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MCPToolDefinition>> GetMCPToolsAsync(
            string agentId,
            string mcpId,
            int? version = default,
            string? componentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}