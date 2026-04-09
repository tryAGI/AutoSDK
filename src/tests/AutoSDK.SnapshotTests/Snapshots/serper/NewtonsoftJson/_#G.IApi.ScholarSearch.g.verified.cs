//HintName: G.IApi.ScholarSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Scholar Search<br/>
        /// Search Google Scholar for academic papers, articles, theses, and citations.<br/>
        /// Supports filtering by year range and finding papers that cite a specific work.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScholarSearchResponse> ScholarSearchAsync(

            global::G.ScholarSearchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scholar Search<br/>
        /// Search Google Scholar for academic papers, articles, theses, and citations.<br/>
        /// Supports filtering by year range and finding papers that cite a specific work.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScholarSearchResponse> ScholarSearchAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}