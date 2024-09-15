//HintName: G.IMemoClient.MemoAddMemoFolderLinks.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// AddMemoFolderLinks.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="folderIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoAddMemoFolderLinksResponse> MemoAddMemoFolderLinksAsync(
            string? token = default,
            global::System.Guid projectId = default,
            string? memoId = default,
            global::System.Collections.Generic.IList<string>? folderIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}