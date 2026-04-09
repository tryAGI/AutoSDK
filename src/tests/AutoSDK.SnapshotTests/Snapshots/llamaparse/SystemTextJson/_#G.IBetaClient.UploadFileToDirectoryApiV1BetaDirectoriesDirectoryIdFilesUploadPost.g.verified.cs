//HintName: G.IBetaClient.UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Upload File To Directory<br/>
        /// Upload a file directly to a directory.<br/>
        /// Uploads a file and creates a directory file entry in a single operation.<br/>
        /// If unique_id or display_name are not provided, they will be derived from the file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsync(
            string directoryId,

            global::G.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File To Directory<br/>
        /// Upload a file directly to a directory.<br/>
        /// Uploads a file and creates a directory file entry in a single operation.<br/>
        /// If unique_id or display_name are not provided, they will be derived from the file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
        /// <param name="uniqueId"></param>
        /// <param name="displayName"></param>
        /// <param name="externalFileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DirectoryFileResponse> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsync(
            string directoryId,
            byte[] uploadFile,
            string uploadFilename,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            string? externalFileId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}