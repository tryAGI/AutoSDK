//HintName: G.IMemoClient.DeleteMemo.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// DeleteMemo<br/>
        /// DeleteMemo
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Memo> DeleteMemoAsync(
            global::G.DeleteMemoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteMemo<br/>
        /// DeleteMemo
        /// </summary>
        /// <param name="memo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Memo> DeleteMemoAsync(
            global::G.Memo memo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}