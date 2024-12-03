//HintName: G.IMemoClient.AddFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// AddFolder<br/>
        /// AddFolder
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> AddFolderAsync(
            global::G.AddFolderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddFolder<br/>
        /// AddFolder
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="parentFolderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> AddFolderAsync(
            global::System.Guid projectId,
            string title,
            global::System.Guid parentFolderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}