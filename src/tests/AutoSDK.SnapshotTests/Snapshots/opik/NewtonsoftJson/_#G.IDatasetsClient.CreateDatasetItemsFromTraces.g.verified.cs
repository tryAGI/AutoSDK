//HintName: G.IDatasetsClient.CreateDatasetItemsFromTraces.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create dataset items from traces<br/>
        /// Create dataset items from traces with enriched metadata
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromTracesAsync(
            global::System.Guid datasetId,

            global::G.CreateDatasetItemsFromTracesRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset items from traces<br/>
        /// Create dataset items from traces with enriched metadata
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="traceIds">
        /// Set of trace IDs to add to the dataset
        /// </param>
        /// <param name="enrichmentOptions">
        /// Options for enriching trace data
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromTracesAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> traceIds,
            global::G.TraceEnrichmentOptions enrichmentOptions,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}