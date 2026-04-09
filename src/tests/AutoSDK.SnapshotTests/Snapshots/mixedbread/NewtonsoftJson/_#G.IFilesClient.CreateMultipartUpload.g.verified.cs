//HintName: G.IFilesClient.CreateMultipartUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Create multipart upload<br/>
        /// Initiate a multipart upload and receive presigned URLs for uploading parts directly to storage.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateMultipartUploadResponse> CreateMultipartUploadAsync(

            global::G.CreateMultipartUploadRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create multipart upload<br/>
        /// Initiate a multipart upload and receive presigned URLs for uploading parts directly to storage.
        /// </summary>
        /// <param name="filename">
        /// Name of the file including extension
        /// </param>
        /// <param name="fileSize">
        /// Total size of the file in bytes
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the file
        /// </param>
        /// <param name="partCount">
        /// Number of parts to split the upload into<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateMultipartUploadResponse> CreateMultipartUploadAsync(
            string filename,
            long fileSize,
            string mimeType,
            int? partCount = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}