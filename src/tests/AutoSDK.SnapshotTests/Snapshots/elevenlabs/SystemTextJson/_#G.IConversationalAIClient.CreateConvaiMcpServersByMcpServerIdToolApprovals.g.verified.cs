//HintName: G.IConversationalAIClient.CreateConvaiMcpServersByMcpServerIdToolApprovals.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Create Mcp Server Tool Approval<br/>
        /// Add approval for a specific MCP tool when using per-tool approval mode.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> CreateConvaiMcpServersByMcpServerIdToolApprovalsAsync(
            string mcpServerId,
            global::G.MCPToolAddApprovalRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Mcp Server Tool Approval<br/>
        /// Add approval for a specific MCP tool when using per-tool approval mode.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="toolName">
        /// The name of the MCP tool
        /// </param>
        /// <param name="toolDescription">
        /// The description of the MCP tool
        /// </param>
        /// <param name="inputSchema">
        /// The input schema of the MCP tool (the schema defined on the MCP server before ElevenLabs does any extra processing)
        /// </param>
        /// <param name="approvalPolicy">
        /// The tool-level approval policy<br/>
        /// Default Value: requires_approval
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> CreateConvaiMcpServersByMcpServerIdToolApprovalsAsync(
            string mcpServerId,
            string toolName,
            string toolDescription,
            string? xiApiKey = default,
            object? inputSchema = default,
            global::G.MCPToolApprovalPolicy? approvalPolicy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}