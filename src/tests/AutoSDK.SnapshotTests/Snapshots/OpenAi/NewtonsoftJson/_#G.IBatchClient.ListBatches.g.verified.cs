//HintName: G.IBatchClient.ListBatches.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// List your organization's batches.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListBatchesResponse> ListBatchesAsync(
            string? after = default,
            int? limit = 20,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}