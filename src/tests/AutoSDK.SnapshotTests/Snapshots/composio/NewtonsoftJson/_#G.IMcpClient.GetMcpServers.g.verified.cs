//HintName: G.IMcpClient.GetMcpServers.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// List MCP servers with optional filters and pagination<br/>
        /// Retrieves a paginated list of MCP servers associated with the authenticated project. Results can be filtered by name, toolkit, or authentication configuration ID. MCP servers are used to provide Model Control Protocol integration points for connecting AI assistants to your applications and services.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::G.GetMcpServersResponse> GetMcpServersAsync(
            string? name = default,
            string? toolkits = default,
            string? authConfigIds = default,
            global::G.GetMcpServersOrderBy? orderBy = default,
            global::G.GetMcpServersOrderDirection? orderDirection = default,
            double? pageNo = default,
            double? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}