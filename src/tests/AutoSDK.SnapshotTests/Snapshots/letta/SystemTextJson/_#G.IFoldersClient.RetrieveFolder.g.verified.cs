//HintName: G.IFoldersClient.RetrieveFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Retrieve Folder<br/>
        /// Get a folder by ID
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Folder> RetrieveFolderAsync(
            string folderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}