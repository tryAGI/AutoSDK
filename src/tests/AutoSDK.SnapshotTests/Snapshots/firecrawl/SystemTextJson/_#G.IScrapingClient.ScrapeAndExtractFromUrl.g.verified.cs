//HintName: G.IScrapingClient.ScrapeAndExtractFromUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IScrapingClient
    {
        /// <summary>
        /// Scrape a single URL and optionally extract information using an LLM
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScrapeResponse> ScrapeAndExtractFromUrlAsync(

            global::G.AllOf<global::G.ScrapeAndExtractFromUrlRequest2, global::G.ScrapeOptions> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scrape a single URL and optionally extract information using an LLM
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScrapeResponse> ScrapeAndExtractFromUrlAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}