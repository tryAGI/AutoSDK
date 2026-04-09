//HintName: G.IDatasetsClient.ApiDatasetsViewsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Put dataset view<br/>
        /// Overwrite view data with updated filters and other information for a specific dataset.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetView> ApiDatasetsViewsUpdateAsync(
            string id,

            global::G.DatasetViewRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put dataset view<br/>
        /// Overwrite view data with updated filters and other information for a specific dataset.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data">
        /// Custom view data
        /// </param>
        /// <param name="dataset">
        /// Dataset ID
        /// </param>
        /// <param name="filterGroup"></param>
        /// <param name="order">
        /// Position of the tab, starting at the left in data manager and increasing as the tabs go left to right
        /// </param>
        /// <param name="ordering">
        /// Ordering parameters
        /// </param>
        /// <param name="selectedItems">
        /// Selected items
        /// </param>
        /// <param name="user">
        /// User who made this view
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetView> ApiDatasetsViewsUpdateAsync(
            string id,
            int dataset,
            object? data = default,
            global::G.FilterGroupRequest? filterGroup = default,
            int? order = default,
            object? ordering = default,
            object? selectedItems = default,
            int? user = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}