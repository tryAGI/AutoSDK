//HintName: G.IRefsClient.RefsReadBatchRefsReadBatchPost.g.cs
#nullable enable

namespace G
{
    public partial interface IRefsClient
    {
        /// <summary>
        /// Refs Read Batch
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RefsReadBatchRes> RefsReadBatchRefsReadBatchPostAsync(

            global::G.RefsReadBatchReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Refs Read Batch
        /// </summary>
        /// <param name="refs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RefsReadBatchRes> RefsReadBatchRefsReadBatchPostAsync(
            global::System.Collections.Generic.IList<string> refs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}