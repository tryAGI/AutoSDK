//HintName: G.IMcpClient.GetMcpById.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Get MCP server details by ID<br/>
        /// Retrieves detailed configuration information for a specific Model Control Protocol (MCP) server. The returned data includes connection details, associated applications, enabled tools, and authentication configuration.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the MCP server to retrieve, update, or delete<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMcpByIdResponse> GetMcpByIdAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}