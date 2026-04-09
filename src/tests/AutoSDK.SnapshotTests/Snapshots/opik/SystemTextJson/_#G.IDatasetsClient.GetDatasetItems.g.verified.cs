//HintName: G.IDatasetsClient.GetDatasetItems.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset items<br/>
        /// Get dataset items
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="version">
        /// Version hash or tag to fetch specific dataset version
        /// </param>
        /// <param name="filters"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetItemPagePublic> GetDatasetItemsAsync(
            global::System.Guid id,
            int? page = default,
            int? size = default,
            string? version = default,
            string? filters = default,
            bool? truncate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}