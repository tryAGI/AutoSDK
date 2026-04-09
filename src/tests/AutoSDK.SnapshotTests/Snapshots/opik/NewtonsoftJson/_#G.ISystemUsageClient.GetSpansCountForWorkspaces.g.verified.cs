//HintName: G.ISystemUsageClient.GetSpansCountForWorkspaces.g.cs
#nullable enable

namespace G
{
    public partial interface ISystemUsageClient
    {
        /// <summary>
        /// Get spans count on previous day for all available workspaces<br/>
        /// Get spans count on previous day for all available workspaces
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpansCountResponse> GetSpansCountForWorkspacesAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}