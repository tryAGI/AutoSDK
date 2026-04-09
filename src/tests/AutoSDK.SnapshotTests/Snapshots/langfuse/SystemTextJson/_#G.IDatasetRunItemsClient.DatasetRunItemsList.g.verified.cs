//HintName: G.IDatasetRunItemsClient.DatasetRunItemsList.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetRunItemsClient
    {
        /// <summary>
        /// List dataset run items
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="runName"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedDatasetRunItems> DatasetRunItemsListAsync(
            string datasetId,
            string runName,
            int? page = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}