//HintName: G.IMemoClient.LinkFoldersToMemos.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// LinkFoldersToMemos<br/>
        /// LinkFoldersToMemos
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LinkFoldersToMemosAsync(
            global::G.LinkFoldersToMemosRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// LinkFoldersToMemos<br/>
        /// LinkFoldersToMemos
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="folderIds"></param>
        /// <param name="memoIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> LinkFoldersToMemosAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<string> folderIds,
            global::System.Collections.Generic.IList<string> memoIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}