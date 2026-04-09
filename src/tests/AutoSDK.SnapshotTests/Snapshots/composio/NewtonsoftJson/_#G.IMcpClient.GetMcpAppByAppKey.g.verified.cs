//HintName: G.IMcpClient.GetMcpAppByAppKey.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// List MCP servers for a specific app<br/>
        /// Retrieves a paginated list of Model Control Protocol (MCP) servers that are configured for a specific application or toolkit. This endpoint allows you to find all MCP server instances that have access to a particular application, such as GitHub, Slack, or Jira.
        /// </summary>
        /// <param name="appKey">
        /// Toolkit or application slug identifier to filter MCP servers by<br/>
        /// Example: github
        /// </param>
        /// <param name="name">
        /// Name substring to filter servers by<br/>
        /// Example: github
        /// </param>
        /// <param name="toolkits"></param>
        /// <param name="authConfigIds"></param>
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
        /// <param name="pageNo">
        /// Page number to retrieve<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="limit">
        /// Number of servers to return per page<br/>
        /// Default Value: 10<br/>
        /// Example: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMcpAppByAppKeyResponse> GetMcpAppByAppKeyAsync(
            string appKey,
            string? name = default,
            string? toolkits = default,
            string? authConfigIds = default,
            global::G.GetMcpAppByAppKeyOrderBy? orderBy = default,
            global::G.GetMcpAppByAppKeyOrderDirection? orderDirection = default,
            double? pageNo = default,
            double? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}