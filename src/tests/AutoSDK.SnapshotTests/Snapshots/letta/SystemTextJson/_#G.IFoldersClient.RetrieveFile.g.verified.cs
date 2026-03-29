//HintName: G.IFoldersClient.RetrieveFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Retrieve File<br/>
        /// Retrieve a file from a folder by ID.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="fileId">
        /// The ID of the file in the format 'file-&lt;uuid4&gt;'
        /// </param>
        /// <param name="includeContent">
        /// Whether to include full file content<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileMetadata> RetrieveFileAsync(
            string folderId,
            string fileId,
            bool? includeContent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}