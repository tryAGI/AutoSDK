//HintName: G.IBatchesClient.ListBatches.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// List Batches<br/>
        /// Retrieve all batches created by your organization.
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataResponseBatchList> ListBatchesAsync(
            int? take = default,
            int? skip = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}