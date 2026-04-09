//HintName: G.IToolRouterClient.PostToolRouterSessionBySessionIdMountsByMountIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Delete a file from a session mount<br/>
        /// Deletes a file from a workbench session storage mount. S3 delete is idempotent — deleting a non-existent file succeeds silently.
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
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse> PostToolRouterSessionBySessionIdMountsByMountIdDeleteAsync(
            string sessionId,
            string mountId,

            global::G.PostToolRouterSessionBySessionIdMountsByMountIdDeleteRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a file from a session mount<br/>
        /// Deletes a file from a workbench session storage mount. S3 delete is idempotent — deleting a non-existent file succeeds silently.
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
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse> PostToolRouterSessionBySessionIdMountsByMountIdDeleteAsync(
            string sessionId,
            string mountId,
            string mountRelativePath,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}