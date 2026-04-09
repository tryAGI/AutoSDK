//HintName: G.IMcpClient.GetMcpServersByServerIdInstances.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// List all instances for an MCP server<br/>
        /// Retrieves a paginated list of user instances (user IDs) associated with a specific Model Control Protocol (MCP) server. This endpoint supports pagination to handle servers with many instances.
        /// </summary>
        /// <param name="serverId">
        /// UUID of the MCP server to list instances for<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="pageNo">
        /// Page number to retrieve<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="limit">
        /// Number of instances to return per page<br/>
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="search">
        /// Filter instances by user ID or instance ID (partial match)<br/>
        /// Example: user_123
        /// </param>
        /// <param name="orderBy">
        /// Field to use for ordering the results<br/>
        /// Default Value: updated_at<br/>
        /// Example: updated_at
        /// </param>
        /// <param name="orderDirection">
        /// Sort direction (ascending or descending)<br/>
        /// Default Value: desc<br/>
        /// Example: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMcpServersByServerIdInstancesResponse> GetMcpServersByServerIdInstancesAsync(
            string serverId,
            double? pageNo = default,
            double? limit = default,
            string? search = default,
            global::G.GetMcpServersByServerIdInstancesOrderBy? orderBy = default,
            global::G.GetMcpServersByServerIdInstancesOrderDirection? orderDirection = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}