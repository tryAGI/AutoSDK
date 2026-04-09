//HintName: G.IApi.CreateExtract.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve raw web content from specified URLs<br/>
        /// Extract web page content from one or more specified URLs using Tavily Extract.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.extract("https://en.wikipedia.org/wiki/Artificial_intelligence")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateExtractResponse> CreateExtractAsync(

            global::G.CreateExtractRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve raw web content from specified URLs<br/>
        /// Extract web page content from one or more specified URLs using Tavily Extract.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="query">
        /// User intent for reranking extracted content chunks. When provided, chunks are reranked based on relevance to this query.
        /// </param>
        /// <param name="chunksPerSource">
        /// Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `raw_content` length. Chunks will appear in the `raw_content` field as: `&lt;chunk 1&gt; [...] &lt;chunk 2&gt; [...] &lt;chunk 3&gt;`. Available only when `query` is provided. Must be between 1 and 5.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="extractDepth">
        /// The depth of the extraction process. `advanced` extraction retrieves more data, including tables and embedded content, with higher success but may increase latency.`basic` extraction costs 1 credit per 5 successful URL extractions, while `advanced` extraction costs 2 credits per 5 successful URL extractions.<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="includeImages">
        /// Include a list of images extracted from the URLs in the response. Default is false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFavicon">
        /// Whether to include the favicon URL for each result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="format">
        /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="timeout">
        /// Maximum time in seconds to wait for the URL extraction before timing out. Must be between 1.0 and 60.0 seconds. If not specified, default timeouts are applied based on extract_depth: 10 seconds for basic extraction and 30 seconds for advanced extraction.<br/>
        /// Default Value: None
        /// </param>
        /// <param name="includeUsage">
        /// Whether to include credit usage information in the response. `NOTE:`The value may be 0 if the total successful URL extractions has not yet reached 5 calls. See our [Credits &amp; Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateExtractResponse> CreateExtractAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> urls,
            string? query = default,
            int? chunksPerSource = default,
            global::G.CreateExtractRequestExtractDepth? extractDepth = default,
            bool? includeImages = default,
            bool? includeFavicon = default,
            global::G.CreateExtractRequestFormat? format = default,
            float? timeout = default,
            bool? includeUsage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}