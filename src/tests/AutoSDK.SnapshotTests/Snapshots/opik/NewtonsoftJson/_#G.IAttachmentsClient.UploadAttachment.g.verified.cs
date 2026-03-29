//HintName: G.IAttachmentsClient.UploadAttachment.g.cs
#nullable enable

namespace G
{
    public partial interface IAttachmentsClient
    {
        /// <summary>
        /// Upload attachment to MinIO<br/>
        /// Upload attachment to MinIO
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="mimeType"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UploadAttachmentAsync(
            string fileName,
            global::G.UploadAttachmentEntityType entityType,
            global::System.Guid entityId,

            object request,
            string? projectName = default,
            string? mimeType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload attachment to MinIO<br/>
        /// Upload attachment to MinIO
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="mimeType"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UploadAttachmentAsync(
            string fileName,
            global::G.UploadAttachmentEntityType entityType,
            global::System.Guid entityId,
            string? projectName = default,
            string? mimeType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}