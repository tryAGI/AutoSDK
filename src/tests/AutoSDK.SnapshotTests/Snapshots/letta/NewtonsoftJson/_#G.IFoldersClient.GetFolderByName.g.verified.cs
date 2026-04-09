//HintName: G.IFoldersClient.GetFolderByName.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Get Folder By Name<br/>
        /// **Deprecated**: Please use the list endpoint `GET /v1/folders?name=` instead.<br/>
        /// Get a folder by name.
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> GetFolderByNameAsync(
            string folderName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}