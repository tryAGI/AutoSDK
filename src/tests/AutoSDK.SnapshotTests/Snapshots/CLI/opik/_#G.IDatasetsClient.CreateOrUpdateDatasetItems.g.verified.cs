//HintName: G.IDatasetsClient.CreateOrUpdateDatasetItems.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create/update dataset items<br/>
        /// Create/update dataset items based on dataset item id.<br/>
        /// Each item's 'id' field is the stable identifier and upsert key.<br/>
        /// Provide it to update an existing item, or omit it to create a new one.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateOrUpdateDatasetItemsAsync(

            global::G.DatasetItemBatchWrite request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create/update dataset items<br/>
        /// Create/update dataset items based on dataset item id.<br/>
        /// Each item's 'id' field is the stable identifier and upsert key.<br/>
        /// Provide it to update an existing item, or omit it to create a new one.
        /// </summary>
        /// <param name="datasetName">
        /// If null, dataset_id must be provided
        /// </param>
        /// <param name="datasetId">
        /// If null, dataset_name must be provided
        /// </param>
        /// <param name="projectName">
        /// Optional. Associates the batch with a project by name. Ignored if project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Optional. Associates the batch with a project by ID. Takes precedence over project_name.
        /// </param>
        /// <param name="items"></param>
        /// <param name="batchGroupId">
        /// Optional batch group ID to group multiple batches into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateOrUpdateDatasetItemsAsync(
            global::System.Collections.Generic.IList<global::G.DatasetItemWrite> items,
            string? datasetName = default,
            global::System.Guid? datasetId = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::System.Guid? batchGroupId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}