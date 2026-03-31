//HintName: G.Api.CreateCrawl.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreateCrawlArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateCrawlRequest request);
        partial void PrepareCreateCrawlRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateCrawlRequest request);
        partial void ProcessCreateCrawlResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateCrawlResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Initiate a web crawl from a base URL<br/>
        /// Tavily Crawl is a graph-based website traversal tool that can explore hundreds of paths in parallel with built-in extraction and intelligent discovery.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.crawl("https://docs.tavily.com", instructions="Find all pages on the Python SDK")<br/>
        /// print(response)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.CreateCrawlResponse> CreateCrawlAsync(

            global::G.CreateCrawlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateCrawlArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/crawl",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateCrawlRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateCrawlResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request - Your request is invalid.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.CreateCrawlResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.CreateCrawlResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.CreateCrawlResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateCrawlResponse2>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized - Your API key is wrong or missing.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.CreateCrawlResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.CreateCrawlResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.CreateCrawlResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateCrawlResponse3>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden - URL is not supported.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.CreateCrawlResponse4? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.CreateCrawlResponse4.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.CreateCrawlResponse4.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateCrawlResponse4>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests - Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.CreateCrawlResponse5? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.CreateCrawlResponse5.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.CreateCrawlResponse5.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateCrawlResponse5>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Key limit or Plan Limit exceeded
            if ((int)__response.StatusCode == 432)
            {
                string? __content_432 = null;
                global::System.Exception? __exception_432 = null;
                global::G.CreateCrawlResponse6? __value_432 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_432 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_432 = global::G.CreateCrawlResponse6.FromJson(__content_432, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_432 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_432 = global::G.CreateCrawlResponse6.FromJson(__content_432, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_432 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateCrawlResponse6>(
                    message: __content_432 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_432,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_432,
                    ResponseObject = __value_432,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // PayGo limit exceeded
            if ((int)__response.StatusCode == 433)
            {
                string? __content_433 = null;
                global::System.Exception? __exception_433 = null;
                global::G.CreateCrawlResponse7? __value_433 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_433 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_433 = global::G.CreateCrawlResponse7.FromJson(__content_433, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_433 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_433 = global::G.CreateCrawlResponse7.FromJson(__content_433, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_433 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateCrawlResponse7>(
                    message: __content_433 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_433,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_433,
                    ResponseObject = __value_433,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal Server Error - We had a problem with our server.
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.CreateCrawlResponse8? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.CreateCrawlResponse8.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.CreateCrawlResponse8.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateCrawlResponse8>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateCrawlResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateCrawlResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.CreateCrawlResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Initiate a web crawl from a base URL<br/>
        /// Tavily Crawl is a graph-based website traversal tool that can explore hundreds of paths in parallel with built-in extraction and intelligent discovery.
        /// </summary>
        /// <param name="url">
        /// The root URL to begin the crawl.<br/>
        /// Example: docs.tavily.com
        /// </param>
        /// <param name="instructions">
        /// Natural language instructions for the crawler. When specified, the mapping cost increases to 2 API credits per 10 successful pages instead of 1 API credit per 10 pages.<br/>
        /// Example: Find all pages about the Python SDK
        /// </param>
        /// <param name="chunksPerSource">
        /// Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `raw_content` length. Chunks will appear in the `raw_content` field as: `&lt;chunk 1&gt; [...] &lt;chunk 2&gt; [...] &lt;chunk 3&gt;`. Available only when `instructions` are provided. Must be between 1 and 5.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="maxDepth">
        /// Max depth of the crawl. Defines how far from the base URL the crawler can explore.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxBreadth">
        /// Max number of links to follow per level of the tree (i.e., per page).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="limit">
        /// Total number of links the crawler will process before stopping.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="selectPaths">
        /// Regex patterns to select only URLs with specific path patterns (e.g., `/docs/.*`, `/api/v1.*`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="selectDomains">
        /// Regex patterns to select crawling to specific domains or subdomains (e.g., `^docs\.example\.com$`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="excludePaths">
        /// Regex patterns to exclude URLs with specific path patterns (e.g., `/private/.*`, `/admin/.*`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="excludeDomains">
        /// Regex patterns to exclude specific domains or subdomains from crawling (e.g., `^private\.example\.com$`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="allowExternal">
        /// Whether to include external domain links in the final results list.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeImages">
        /// Whether to include images in the crawl results.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="extractDepth">
        /// Advanced extraction retrieves more data, including tables and embedded content, with higher success but may increase latency. `basic` extraction costs 1 credit per 5 successful extractions, while `advanced` extraction costs 2 credits per 5 successful extractions.<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="format">
        /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="includeFavicon">
        /// Whether to include the favicon URL for each result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Maximum time in seconds to wait for the crawl operation before timing out. Must be between 10 and 150 seconds.<br/>
        /// Default Value: 150
        /// </param>
        /// <param name="includeUsage">
        /// Whether to include credit usage information in the response. `NOTE:`The value may be 0 if the total use of /extract and /map have not yet reached minimum requirements. See our [Credits &amp; Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateCrawlResponse> CreateCrawlAsync(
            string url,
            string? instructions = default,
            int? chunksPerSource = default,
            int? maxDepth = default,
            int? maxBreadth = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? selectPaths = default,
            global::System.Collections.Generic.IList<string>? selectDomains = default,
            global::System.Collections.Generic.IList<string>? excludePaths = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            bool? allowExternal = default,
            bool? includeImages = default,
            global::G.CreateCrawlRequestExtractDepth? extractDepth = default,
            global::G.CreateCrawlRequestFormat? format = default,
            bool? includeFavicon = default,
            float? timeout = default,
            bool? includeUsage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.CreateCrawlRequest
            {
                Url = url,
                Instructions = instructions,
                ChunksPerSource = chunksPerSource,
                MaxDepth = maxDepth,
                MaxBreadth = maxBreadth,
                Limit = limit,
                SelectPaths = selectPaths,
                SelectDomains = selectDomains,
                ExcludePaths = excludePaths,
                ExcludeDomains = excludeDomains,
                AllowExternal = allowExternal,
                IncludeImages = includeImages,
                ExtractDepth = extractDepth,
                Format = format,
                IncludeFavicon = includeFavicon,
                Timeout = timeout,
                IncludeUsage = includeUsage,
            };

            return await CreateCrawlAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}