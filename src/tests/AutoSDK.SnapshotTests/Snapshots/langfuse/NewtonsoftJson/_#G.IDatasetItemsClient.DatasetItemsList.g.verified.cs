//HintName: G.IDatasetItemsClient.DatasetItemsList.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// Get dataset items. Optionally specify a version to get the items as they existed at that point in time.<br/>
        /// Note: If version parameter is provided, datasetName must also be provided.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="sourceTraceId"></param>
        /// <param name="sourceObservationId"></param>
        /// <param name="version"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedDatasetItems> DatasetItemsListAsync(
            string? datasetName = default,
            string? sourceTraceId = default,
            string? sourceObservationId = default,
            global::System.DateTime? version = default,
            int? page = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}