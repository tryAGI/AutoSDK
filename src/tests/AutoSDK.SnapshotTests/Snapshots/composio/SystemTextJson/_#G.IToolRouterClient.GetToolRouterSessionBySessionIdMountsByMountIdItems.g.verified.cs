//HintName: G.IToolRouterClient.GetToolRouterSessionBySessionIdMountsByMountIdItems.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// List files in a session mount<br/>
        /// Lists files in a workbench session storage mount with cursor-based pagination. Use the download_url endpoint with the returned mount_relative_path to get a presigned download URL.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session<br/>
        /// Example: trs_123456789
        /// </param>
        /// <param name="mountId">
        /// ID of the storage mount<br/>
        /// Example: files
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from the previous response next_cursor field
        /// </param>
        /// <param name="limit">
        /// Maximum number of files to return per page (1-500)<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="mountRelativePrefix">
        /// Filter results to files under this mount-relative path prefix (e.g. "data/" lists only files in the data/ subdirectory)<br/>
        /// Example: data/
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse> GetToolRouterSessionBySessionIdMountsByMountIdItemsAsync(
            string sessionId,
            string mountId,
            string? cursor = default,
            double? limit = default,
            string? mountRelativePrefix = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}