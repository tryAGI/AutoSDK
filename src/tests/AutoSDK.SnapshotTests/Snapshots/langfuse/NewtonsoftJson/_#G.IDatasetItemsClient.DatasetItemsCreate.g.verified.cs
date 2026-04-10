//HintName: G.IDatasetItemsClient.DatasetItemsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// Create a dataset item
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetItem> DatasetItemsCreateAsync(

            global::G.CreateDatasetItemRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dataset item
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="input"></param>
        /// <param name="expectedOutput"></param>
        /// <param name="metadata"></param>
        /// <param name="sourceTraceId"></param>
        /// <param name="sourceObservationId"></param>
        /// <param name="id">
        /// Dataset items are upserted on their id. Id needs to be unique (project-level) and cannot be reused across datasets.
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetItem> DatasetItemsCreateAsync(
            string datasetName,
            object? input = default,
            object? expectedOutput = default,
            object? metadata = default,
            string? sourceTraceId = default,
            string? sourceObservationId = default,
            string? id = default,
            global::G.DatasetStatus? status = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}