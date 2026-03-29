//HintName: G.IAttachmentsClient.CreateAttachment.g.cs
#nullable enable

namespace G
{
    public partial interface IAttachmentsClient
    {
        /// <summary>
        /// Create attachments array<br/>
        /// Return contents of the files in plain string format
        /// </summary>
        /// <param name="chatflowId"></param>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CreateAttachmentResponse>> CreateAttachmentAsync(
            string chatflowId,
            string chatId,

            global::G.CreateAttachmentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create attachments array<br/>
        /// Return contents of the files in plain string format
        /// </summary>
        /// <param name="chatflowId"></param>
        /// <param name="chatId"></param>
        /// <param name="files">
        /// Files to be uploaded
        /// </param>
        /// <param name="base64">
        /// Return contents of the files in base64 format<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CreateAttachmentResponse>> CreateAttachmentAsync(
            string chatflowId,
            string chatId,
            global::System.Collections.Generic.IList<byte[]> files,
            bool? base64 = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}