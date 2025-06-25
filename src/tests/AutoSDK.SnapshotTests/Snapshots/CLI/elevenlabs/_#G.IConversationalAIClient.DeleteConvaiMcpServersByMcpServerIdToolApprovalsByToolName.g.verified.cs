//HintName: G.IConversationalAIClient.DeleteConvaiMcpServersByMcpServerIdToolApprovalsByToolName.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Delete Mcp Server Tool Approval<br/>
        /// Remove approval for a specific MCP tool when using per-tool approval mode.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="toolName">
        /// Name of the MCP tool to remove approval for.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> DeleteConvaiMcpServersByMcpServerIdToolApprovalsByToolNameAsync(
            string mcpServerId,
            string toolName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}