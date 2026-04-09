//HintName: G.IToolRouterClient.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Create a presigned upload URL for a mount file<br/>
        /// Generates a presigned upload URL for uploading a file to a workbench session mount. The caller should PUT the file content directly to the returned URL.
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
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse> PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlAsync(
            string sessionId,
            string mountId,

            global::G.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a presigned upload URL for a mount file<br/>
        /// Generates a presigned upload URL for uploading a file to a workbench session mount. The caller should PUT the file content directly to the returned URL.
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
        /// Supports subdirectories (e.g. "data/output.csv", "images/charts/chart.png")<br/>
        /// Example: report.pdf
        /// </param>
        /// <param name="mimetype">
        /// MIME type of the file being uploaded<br/>
        /// Example: application/pdf
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse> PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlAsync(
            string sessionId,
            string mountId,
            string mountRelativePath,
            string? mimetype = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}