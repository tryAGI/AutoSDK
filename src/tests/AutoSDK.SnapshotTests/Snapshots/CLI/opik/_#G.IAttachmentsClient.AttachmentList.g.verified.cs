//HintName: G.IAttachmentsClient.AttachmentList.g.cs
#nullable enable

namespace G
{
    public partial interface IAttachmentsClient
    {
        /// <summary>
        /// Attachments list for entity<br/>
        /// Attachments list for entity
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 100
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AttachmentPage> AttachmentListAsync(
            global::System.Guid projectId,
            global::G.AttachmentListEntityType entityType,
            global::System.Guid entityId,
            string path,
            int? page = default,
            int? size = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}