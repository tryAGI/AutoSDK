//HintName: G.IFoldersClient.ListFilesForFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// List Files For Folder<br/>
        /// List paginated files associated with a data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// File ID cursor for pagination. Returns files that come before this file ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// File ID cursor for pagination. Returns files that come after this file ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of files to return<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="order">
        /// Sort order for files by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="includeContent">
        /// Whether to include full file content<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FileMetadata>> ListFilesForFolderAsync(
            string folderId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListFilesForFolderOrder? order = default,
            string? orderBy = default,
            bool? includeContent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}