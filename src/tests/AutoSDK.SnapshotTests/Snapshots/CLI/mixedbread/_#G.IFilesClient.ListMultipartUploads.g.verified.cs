//HintName: G.IFilesClient.ListMultipartUploads.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List in-progress multipart uploads<br/>
        /// List all in-progress multipart uploads for the authenticated organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultipartUploadListResponse> ListMultipartUploadsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}