//HintName: G.IDatasetsClient.ListDatasets.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List datasets
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="name">
        /// An optional dataset name to filter by
        /// </param>
        /// <param name="limit">
        /// The max number of datasets to return at a time.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDatasetsResponseBody> ListDatasetsAsync(
            string? cursor = default,
            string? name = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}