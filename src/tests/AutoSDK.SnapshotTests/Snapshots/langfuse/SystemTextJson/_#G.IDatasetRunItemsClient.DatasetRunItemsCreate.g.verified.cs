//HintName: G.IDatasetRunItemsClient.DatasetRunItemsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetRunItemsClient
    {
        /// <summary>
        /// Create a dataset run item
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetRunItem> DatasetRunItemsCreateAsync(

            global::G.CreateDatasetRunItemRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dataset run item
        /// </summary>
        /// <param name="runName"></param>
        /// <param name="runDescription">
        /// Description of the run. If run exists, description will be updated.
        /// </param>
        /// <param name="metadata">
        /// Metadata of the dataset run, updates run if run already exists
        /// </param>
        /// <param name="datasetItemId"></param>
        /// <param name="observationId"></param>
        /// <param name="traceId">
        /// traceId should always be provided. For compatibility with older SDK versions it can also be inferred from the provided observationId.
        /// </param>
        /// <param name="datasetVersion">
        /// ISO 8601 timestamp (RFC 3339, Section 5.6) in UTC (e.g., "2026-01-21T14:35:42Z").<br/>
        /// Specifies the dataset version to use for this experiment run. <br/>
        /// If provided, the experiment will use dataset items as they existed at or before this timestamp.<br/>
        /// If not provided, uses the latest version of dataset items.
        /// </param>
        /// <param name="createdAt">
        /// Optional timestamp to set the createdAt field of the dataset run item. If not provided or null, defaults to current timestamp.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetRunItem> DatasetRunItemsCreateAsync(
            string runName,
            string datasetItemId,
            string? runDescription = default,
            object? metadata = default,
            string? observationId = default,
            string? traceId = default,
            global::System.DateTime? datasetVersion = default,
            global::System.DateTime? createdAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}