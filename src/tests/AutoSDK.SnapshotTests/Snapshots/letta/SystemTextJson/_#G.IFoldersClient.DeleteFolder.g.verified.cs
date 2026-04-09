//HintName: G.IFoldersClient.DeleteFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Delete Folder<br/>
        /// Delete a data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteFolderAsync(
            string folderId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}