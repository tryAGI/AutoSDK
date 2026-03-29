//HintName: G.IBatchClient.ListBatches.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// List your organization's batches.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListBatchesResponse> ListBatchesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}