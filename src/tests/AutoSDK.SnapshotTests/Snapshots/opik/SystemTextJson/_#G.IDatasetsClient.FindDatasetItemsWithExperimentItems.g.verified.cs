//HintName: G.IDatasetsClient.FindDatasetItemsWithExperimentItems.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Find dataset items with experiment items<br/>
        /// Find dataset items with experiment items
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="experimentIds"></param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="search"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetItemPageCompare> FindDatasetItemsWithExperimentItemsAsync(
            global::System.Guid id,
            string experimentIds,
            int? page = default,
            int? size = default,
            string? filters = default,
            string? sorting = default,
            string? search = default,
            bool? truncate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}