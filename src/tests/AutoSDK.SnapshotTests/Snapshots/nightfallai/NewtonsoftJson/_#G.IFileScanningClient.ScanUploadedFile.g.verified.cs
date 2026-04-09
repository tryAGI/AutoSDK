//HintName: G.IFileScanningClient.ScanUploadedFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFileScanningClient
    {
        /// <summary>
        /// Scan an uploaded file<br/>
        /// Triggers an asynchronous scan of a previously uploaded and completed file.<br/>
        /// Results are delivered via webhook or alert configuration.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScanFileResponse> ScanUploadedFileAsync(
            global::System.Guid fileId,

            global::G.ScanFileRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scan an uploaded file<br/>
        /// Triggers an asynchronous scan of a previously uploaded and completed file.<br/>
        /// Results are delivered via webhook or alert configuration.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="policyUUID"></param>
        /// <param name="policy"></param>
        /// <param name="requestMetadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScanFileResponse> ScanUploadedFileAsync(
            global::System.Guid fileId,
            string? policyUUID = default,
            global::G.FileScanPolicy? policy = default,
            string? requestMetadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}