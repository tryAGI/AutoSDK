//HintName: G.IApi.PatentSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Patent Search<br/>
        /// Search Google Patents for patent documents and applications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatentSearchResponse> PatentSearchAsync(

            global::G.PatentSearchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patent Search<br/>
        /// Search Google Patents for patent documents and applications.
        /// </summary>
        /// <param name="q">
        /// Search query string.<br/>
        /// Example: apple inc
        /// </param>
        /// <param name="gl">
        /// Country code for localized results (ISO 3166-1 alpha-2).<br/>
        /// Example: us
        /// </param>
        /// <param name="hl">
        /// Language code for the interface language (ISO 639-1).<br/>
        /// Example: en
        /// </param>
        /// <param name="num">
        /// Number of results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="page">
        /// Page number for pagination.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="autocorrect">
        /// Whether to autocorrect the query spelling.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatentSearchResponse> PatentSearchAsync(
            string q,
            string? gl = default,
            string? hl = default,
            int? num = default,
            int? page = default,
            bool? autocorrect = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}