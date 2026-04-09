//HintName: G.IFoldersClient.UploadFileToFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Upload File To Folder<br/>
        /// Upload a file to a data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="duplicateHandling">
        /// How to handle duplicate filenames<br/>
        /// Default Value: suffix
        /// </param>
        /// <param name="name">
        /// Optional custom name to override the uploaded file's name
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileMetadata> UploadFileToFolderAsync(
            string folderId,

            global::G.BodyUploadFileToFolder request,
            global::G.DuplicateFileHandling? duplicateHandling = default,
            string? name = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File To Folder<br/>
        /// Upload a file to a data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="duplicateHandling">
        /// How to handle duplicate filenames<br/>
        /// Default Value: suffix
        /// </param>
        /// <param name="name">
        /// Optional custom name to override the uploaded file's name
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileMetadata> UploadFileToFolderAsync(
            string folderId,
            byte[] file,
            string filename,
            global::G.DuplicateFileHandling? duplicateHandling = default,
            string? name = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}