//HintName: G.IAttachmentsClient.DeleteAttachments.g.cs
#nullable enable

namespace G
{
    public partial interface IAttachmentsClient
    {
        /// <summary>
        /// Delete attachments<br/>
        /// Delete attachments
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAttachmentsAsync(

            global::G.CompleteMultipartUploadRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete attachments<br/>
        /// Delete attachments
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="fileSize"></param>
        /// <param name="mimeType"></param>
        /// <param name="uploadId"></param>
        /// <param name="uploadedFileParts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteAttachmentsAsync(
            string fileName,
            global::G.CompleteMultipartUploadRequestEntityType entityType,
            global::System.Guid entityId,
            long fileSize,
            string uploadId,
            global::System.Collections.Generic.IList<global::G.MultipartUploadPart> uploadedFileParts,
            string? projectName = default,
            string? mimeType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}