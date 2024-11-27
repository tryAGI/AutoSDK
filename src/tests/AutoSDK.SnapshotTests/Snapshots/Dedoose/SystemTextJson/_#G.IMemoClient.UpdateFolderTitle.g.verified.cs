//HintName: G.IMemoClient.UpdateFolderTitle.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// UpdateFolderTitle<br/>
        /// UpdateFolderTitle
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> UpdateFolderTitleAsync(
            global::G.UpdateFolderTitleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateFolderTitle<br/>
        /// UpdateFolderTitle
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="folderId"></param>
        /// <param name="title"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> UpdateFolderTitleAsync(
            global::System.Guid projectId,
            global::System.Guid folderId,
            string title,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}