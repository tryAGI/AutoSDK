//HintName: G.IMcpClient.DeleteMcpServersByServerIdInstancesByInstanceId.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Delete an MCP server instance and associated connected accounts<br/>
        /// Removes a user instance from the MCP server and deletes all connected accounts for that user that are associated with the auth configurations of this specific MCP server. Connected accounts for other auth configurations are not affected.
        /// </summary>
        /// <param name="serverId">
        /// UUID of the MCP server<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="instanceId">
        /// The user ID to remove from this server<br/>
        /// Example: user_123456
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteMcpServersByServerIdInstancesByInstanceIdResponse> DeleteMcpServersByServerIdInstancesByInstanceIdAsync(
            string serverId,
            string instanceId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}