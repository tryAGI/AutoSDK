//HintName: G.IMemoClient.DeleteFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// DeleteFolder<br/>
        /// DeleteFolder
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> DeleteFolderAsync(
            global::G.DeleteFolderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteFolder<br/>
        /// DeleteFolder
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> DeleteFolderAsync(
            global::G.MemoFolder folder,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}