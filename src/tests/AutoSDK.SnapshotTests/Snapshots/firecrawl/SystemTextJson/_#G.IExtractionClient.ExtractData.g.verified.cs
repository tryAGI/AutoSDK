//HintName: G.IExtractionClient.ExtractData.g.cs
#nullable enable

namespace G
{
    public partial interface IExtractionClient
    {
        /// <summary>
        /// Extract structured data from pages using LLMs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractResponse> ExtractDataAsync(

            global::G.ExtractDataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract structured data from pages using LLMs
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="prompt">
        /// Prompt to guide the extraction process
        /// </param>
        /// <param name="schema">
        /// Schema to define the structure of the extracted data. Must conform to [JSON Schema](https://json-schema.org/).
        /// </param>
        /// <param name="enableWebSearch">
        /// When true, the extraction will use web search to find additional data<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ignoreSitemap">
        /// When true, sitemap.xml files will be ignored during website scanning<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeSubdomains">
        /// When true, subdomains of the provided URLs will also be scanned<br/>
        /// Default Value: true
        /// </param>
        /// <param name="showSources">
        /// When true, the sources used to extract the data will be included in the response as `sources` key<br/>
        /// Default Value: false
        /// </param>
        /// <param name="scrapeOptions"></param>
        /// <param name="ignoreInvalidURLs">
        /// If invalid URLs are specified in the urls array, they will be ignored. Instead of them failing the entire request, an extract using the remaining valid URLs will be performed, and the invalid URLs will be returned in the invalidURLs field of the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractResponse> ExtractDataAsync(
            global::System.Collections.Generic.IList<string> urls,
            string? prompt = default,
            object? schema = default,
            bool? enableWebSearch = default,
            bool? ignoreSitemap = default,
            bool? includeSubdomains = default,
            bool? showSources = default,
            global::G.ScrapeOptions? scrapeOptions = default,
            bool? ignoreInvalidURLs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}