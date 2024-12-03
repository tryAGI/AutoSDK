//HintName: G.IMemoClient.AddMemo.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// AddMemo<br/>
        /// AddMemo
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoAndLinks> AddMemoAsync(
            global::G.AddMemoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddMemo<br/>
        /// AddMemo
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="dataPath"></param>
        /// <param name="folderIds"></param>
        /// <param name="linkedObjects"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoAndLinks> AddMemoAsync(
            global::System.Guid projectId,
            string title,
            string dataPath,
            global::System.Collections.Generic.IList<global::System.Guid> folderIds,
            global::G.MemoLinkedObjects linkedObjects,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}