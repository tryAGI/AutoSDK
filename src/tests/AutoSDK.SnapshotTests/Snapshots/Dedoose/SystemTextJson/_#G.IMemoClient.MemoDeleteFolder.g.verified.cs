//HintName: G.IMemoClient.MemoDeleteFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// DeleteFolder.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoFolder> MemoDeleteFolderAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid id = default,
            global::System.Guid projectId = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}