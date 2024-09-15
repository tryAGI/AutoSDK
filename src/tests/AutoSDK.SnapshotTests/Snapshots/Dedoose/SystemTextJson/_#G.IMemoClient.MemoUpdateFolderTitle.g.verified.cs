//HintName: G.IMemoClient.MemoUpdateFolderTitle.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// UpdateFolderTitle.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="folderId"></param>
        /// <param name="title"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> MemoUpdateFolderTitleAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid folderId = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}