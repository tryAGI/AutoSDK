//HintName: G.IDocumentsClient.DocumentCrawlWebsite.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// crawl_website<br/>
        /// Upload the content of a publicly accessible website for ingestion into a GroundX bucket. This is done by following links within a specified URL, recursively, up to a specified depth or number of pages.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IngestResponse> DocumentCrawlWebsiteAsync(

            global::G.WebsiteCrawlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// crawl_website<br/>
        /// Upload the content of a publicly accessible website for ingestion into a GroundX bucket. This is done by following links within a specified URL, recursively, up to a specified depth or number of pages.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="websites"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.IngestResponse> DocumentCrawlWebsiteAsync(
            global::System.Collections.Generic.IList<global::G.WebsiteCrawlRequestWebsite> websites,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}