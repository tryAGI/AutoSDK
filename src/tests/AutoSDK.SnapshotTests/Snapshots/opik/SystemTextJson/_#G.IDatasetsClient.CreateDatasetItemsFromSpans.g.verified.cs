//HintName: G.IDatasetsClient.CreateDatasetItemsFromSpans.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create dataset items from spans<br/>
        /// Create dataset items from spans with enriched metadata
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromSpansAsync(
            global::System.Guid datasetId,

            global::G.CreateDatasetItemsFromSpansRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset items from spans<br/>
        /// Create dataset items from spans with enriched metadata
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="spanIds">
        /// Set of span IDs to add to the dataset
        /// </param>
        /// <param name="enrichmentOptions">
        /// Options for enriching span data
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromSpansAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> spanIds,
            global::G.SpanEnrichmentOptions enrichmentOptions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}