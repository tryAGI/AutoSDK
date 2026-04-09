//HintName: G.IMcpServersUserAccessClient.McpServerUserAccessBulkUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersUserAccessClient
    {
        /// <summary>
        /// Bulk Update MCP Server User Access
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerUserAccessBulkUpdateResponse> McpServerUserAccessBulkUpdateAsync(
            string mcpServerId,

            global::G.BulkUpdateMcpServerUserAccess request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Server User Access
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="userAccess"></param>
        /// <param name="defaultUserAccess">
        /// Server default when user has no explicit override
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerUserAccessBulkUpdateResponse> McpServerUserAccessBulkUpdateAsync(
            string mcpServerId,
            global::System.Collections.Generic.IList<global::G.BulkUpdateMcpServerUserAccessUserAcces>? userAccess = default,
            global::G.BulkUpdateMcpServerUserAccessDefaultUserAccess? defaultUserAccess = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}