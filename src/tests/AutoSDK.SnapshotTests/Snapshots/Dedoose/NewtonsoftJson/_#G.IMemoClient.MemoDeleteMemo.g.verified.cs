//HintName: G.IMemoClient.MemoDeleteMemo.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// DeleteMemo.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="createdUserId"></param>
        /// <param name="lastEditUserId"></param>
        /// <param name="createStamp"></param>
        /// <param name="lastEditStamp"></param>
        /// <param name="folderId"></param>
        /// <param name="dataURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Memo> MemoDeleteMemoAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid id = default,
            global::System.Guid projectId = default,
            string? title = default,
            global::System.Guid createdUserId = default,
            global::System.Guid lastEditUserId = default,
            global::System.DateTime createStamp = default,
            global::System.DateTime lastEditStamp = default,
            global::System.Guid folderId = default,
            string? dataURI = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}