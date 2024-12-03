//HintName: G.IMemoClient.UpdateMemo.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// UpdateMemo<br/>
        /// UpdateMemo
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoAndLinks> UpdateMemoAsync(
            global::G.UpdateMemoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateMemo<br/>
        /// UpdateMemo
        /// </summary>
        /// <param name="memo"></param>
        /// <param name="folderIds"></param>
        /// <param name="linkedObjects"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoAndLinks> UpdateMemoAsync(
            global::G.Memo memo,
            global::System.Collections.Generic.IList<global::System.Guid> folderIds,
            global::G.MemoLinkedObjects linkedObjects,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}