//HintName: G.IScrapingClient.CancelBatchScrape.g.cs
#nullable enable

namespace G
{
    public partial interface IScrapingClient
    {
        /// <summary>
        /// Cancel a batch scrape job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CancelBatchScrapeResponse> CancelBatchScrapeAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}