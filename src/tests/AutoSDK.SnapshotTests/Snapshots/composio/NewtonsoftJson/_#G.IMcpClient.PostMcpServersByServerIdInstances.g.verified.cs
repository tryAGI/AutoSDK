//HintName: G.IMcpClient.PostMcpServersByServerIdInstances.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Create a new MCP server instance<br/>
        /// Creates a new instance for a Model Control Protocol (MCP) server. This endpoint validates that the user has connected accounts for all auth configurations associated with the MCP server before creating the instance.
        /// </summary>
        /// <param name="serverId">
        /// UUID of the MCP server to create an instance for<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostMcpServersByServerIdInstancesResponse> PostMcpServersByServerIdInstancesAsync(
            string serverId,

            global::G.PostMcpServersByServerIdInstancesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new MCP server instance<br/>
        /// Creates a new instance for a Model Control Protocol (MCP) server. This endpoint validates that the user has connected accounts for all auth configurations associated with the MCP server before creating the instance.
        /// </summary>
        /// <param name="serverId">
        /// UUID of the MCP server to create an instance for<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="userId">
        /// The user ID (entity ID) that will be used as both the user identifier and instance ID<br/>
        /// Example: user_123456
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostMcpServersByServerIdInstancesResponse> PostMcpServersByServerIdInstancesAsync(
            string serverId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}