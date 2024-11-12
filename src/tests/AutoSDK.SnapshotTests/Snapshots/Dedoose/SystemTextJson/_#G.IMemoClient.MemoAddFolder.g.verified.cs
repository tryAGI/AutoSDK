//HintName: G.IMemoClient.MemoAddFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// AddFolder.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="parentFolderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> MemoAddFolderAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? title = default,
            global::System.Guid? parentFolderId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}