//HintName: G.IApi.ListRecords.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListRecordsResponse> ListRecordsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.ListRecordsResponse>> ListRecordsAsResponseAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets a paginated response wrapper for the endpoint.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides applied to the current page request and any subsequent page traversal.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKPage<global::G.ListRecordsResponseDataItem, global::G.ListRecordsResponse>> ListRecordsAsPageAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);


        /// <summary>
        /// Enumerates all items exposed by the paginated endpoint.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides applied to every page request.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.ListRecordsResponseDataItem> ListRecordsAsItemsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}