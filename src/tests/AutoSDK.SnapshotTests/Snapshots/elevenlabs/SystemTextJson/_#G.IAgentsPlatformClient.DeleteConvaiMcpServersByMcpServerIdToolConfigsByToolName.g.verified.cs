//HintName: G.IAgentsPlatformClient.DeleteConvaiMcpServersByMcpServerIdToolConfigsByToolName.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Mcp Tool Configuration Override<br/>
        /// Remove configuration overrides for a specific MCP tool.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="toolName">
        /// Name of the MCP tool to remove config overrides for.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> DeleteConvaiMcpServersByMcpServerIdToolConfigsByToolNameAsync(
            string mcpServerId,
            string toolName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}