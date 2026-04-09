//HintName: G.IAttachmentsClient.StartMultiPartUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IAttachmentsClient
    {
        /// <summary>
        /// Start multipart attachment upload<br/>
        /// Start multipart attachment upload
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartMultipartUploadResponse> StartMultiPartUploadAsync(

            global::G.StartMultipartUploadRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start multipart attachment upload<br/>
        /// Start multipart attachment upload
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="numOfFileParts"></param>
        /// <param name="mimeType"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartMultipartUploadResponse> StartMultiPartUploadAsync(
            string fileName,
            int numOfFileParts,
            global::G.StartMultipartUploadRequestEntityType entityType,
            global::System.Guid entityId,
            string path,
            string? mimeType = default,
            string? projectName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}