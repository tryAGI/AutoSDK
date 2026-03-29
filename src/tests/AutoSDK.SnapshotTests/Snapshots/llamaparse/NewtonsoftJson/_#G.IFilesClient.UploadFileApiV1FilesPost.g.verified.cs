//HintName: G.IFilesClient.UploadFileApiV1FilesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload File<br/>
        /// Upload a file directly using multipart/form-data.
        /// </summary>
        /// <param name="externalFileId"></param>
        /// <param name="storageType"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> UploadFileApiV1FilesPostAsync(

            global::G.BodyUploadFileApiV1FilesPost request,
            string? externalFileId = default,
            string? storageType = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Upload a file directly using multipart/form-data.
        /// </summary>
        /// <param name="externalFileId"></param>
        /// <param name="storageType"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> UploadFileApiV1FilesPostAsync(
            byte[] uploadFile,
            string uploadFilename,
            string? externalFileId = default,
            string? storageType = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}