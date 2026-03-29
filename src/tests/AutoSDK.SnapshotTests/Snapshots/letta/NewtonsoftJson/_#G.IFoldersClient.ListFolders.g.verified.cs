//HintName: G.IFoldersClient.ListFolders.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// List Folders<br/>
        /// List all data folders created by a user.
        /// </summary>
        /// <param name="before">
        /// Folder ID cursor for pagination. Returns folders that come before this folder ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Folder ID cursor for pagination. Returns folders that come after this folder ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of folders to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for folders by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="name">
        /// Folder name to filter by
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Folder>> ListFoldersAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListFoldersOrder? order = default,
            string? orderBy = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}