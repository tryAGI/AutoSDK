//HintName: G.IToolRouterClient.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Create a presigned download URL for a mount file<br/>
        /// Generates a presigned download URL for a file in a workbench session mount. Accepts a relative path within the mount.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session<br/>
        /// Example: trs_123456789
        /// </param>
        /// <param name="mountId">
        /// ID of the storage mount<br/>
        /// Example: files
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlResponse> PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlAsync(
            string sessionId,
            string mountId,

            global::G.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a presigned download URL for a mount file<br/>
        /// Generates a presigned download URL for a file in a workbench session mount. Accepts a relative path within the mount.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session<br/>
        /// Example: trs_123456789
        /// </param>
        /// <param name="mountId">
        /// ID of the storage mount<br/>
        /// Example: files
        /// </param>
        /// <param name="mountRelativePath">
        /// Relative file path within the mount<br/>
        /// Example: report.pdf
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlResponse> PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlAsync(
            string sessionId,
            string mountId,
            string mountRelativePath,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}