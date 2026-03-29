//HintName: G.IFoldersClient.CountFolders.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Count Folders<br/>
        /// Count all data folders created by a user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> CountFoldersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}