//HintName: G.IConversationalAIClient.EditConvaiMcpServersByMcpServerIdApprovalPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Update Mcp Server Approval Policy<br/>
        /// Update the approval policy configuration for an MCP server.
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
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> EditConvaiMcpServersByMcpServerIdApprovalPolicyAsync(
            string mcpServerId,
            global::G.MCPApprovalPolicyUpdateRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Mcp Server Approval Policy<br/>
        /// Update the approval policy configuration for an MCP server.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="approvalPolicy">
        /// Defines the MCP server-level approval policy for tool execution.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> EditConvaiMcpServersByMcpServerIdApprovalPolicyAsync(
            string mcpServerId,
            global::G.MCPApprovalPolicy approvalPolicy,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}