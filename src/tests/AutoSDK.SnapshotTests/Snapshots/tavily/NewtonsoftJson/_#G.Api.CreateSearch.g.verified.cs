//HintName: G.Api.CreateSearch.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreateSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateSearchRequest request);
        partial void PrepareCreateSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateSearchRequest request);
        partial void ProcessCreateSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search for data based on a query<br/>
        /// Execute a search query using Tavily Search.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.search("Who is Leo Messi?")<br/>
        /// print(response)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.CreateSearchResponse> CreateSearchAsync(

            global::G.CreateSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateSearchArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/search",
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
            PrepareCreateSearchRequest(
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
            ProcessCreateSearchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request - Your request is invalid.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.CreateSearchResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.CreateSearchResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.CreateSearchResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateSearchResponse2>(
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
                global::G.CreateSearchResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.CreateSearchResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.CreateSearchResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateSearchResponse3>(
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
            // Too many requests - Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.CreateSearchResponse4? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.CreateSearchResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.CreateSearchResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateSearchResponse4>(
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
                global::G.CreateSearchResponse5? __value_432 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_432 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_432 = global::G.CreateSearchResponse5.FromJson(__content_432, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_432 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_432 = global::G.CreateSearchResponse5.FromJson(__content_432, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_432 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateSearchResponse5>(
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
                global::G.CreateSearchResponse6? __value_433 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_433 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_433 = global::G.CreateSearchResponse6.FromJson(__content_433, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_433 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_433 = global::G.CreateSearchResponse6.FromJson(__content_433, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_433 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateSearchResponse6>(
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
                global::G.CreateSearchResponse7? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.CreateSearchResponse7.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.CreateSearchResponse7.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateSearchResponse7>(
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
                ProcessCreateSearchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateSearchResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateSearchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Search for data based on a query<br/>
        /// Execute a search query using Tavily Search.
        /// </summary>
        /// <param name="query">
        /// The search query to execute with Tavily.<br/>
        /// Example: who is Leo Messi?
        /// </param>
        /// <param name="searchDepth">
        /// Controls the latency vs. relevance tradeoff and how `results[].content` is generated:<br/>
        /// - `advanced`: Highest relevance with increased latency. Best for detailed, high-precision queries. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
        /// - `basic`: A balanced option for relevance and latency. Ideal for general-purpose searches. Returns one NLP summary per URL.<br/>
        /// - `fast`: Prioritizes lower latency while maintaining good relevance. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
        /// - `ultra-fast`: Minimizes latency above all else. Best for time-critical use cases. Returns one NLP summary per URL.<br/>
        /// **Cost**:<br/>
        /// - `basic`, `fast`, `ultra-fast`: 1 API Credit<br/>
        /// - `advanced`: 2 API Credits<br/>
        /// See [Search Best Practices](/documentation/best-practices/best-practices-search#search-depth) for guidance on choosing the right search depth.<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="chunksPerSource">
        /// Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `content` length. Chunks will appear in the `content` field as: `&lt;chunk 1&gt; [...] &lt;chunk 2&gt; [...] &lt;chunk 3&gt;`. Available only when `search_depth` is `advanced`.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of search results to return.<br/>
        /// Default Value: 5<br/>
        /// Example: 1
        /// </param>
        /// <param name="topic">
        /// The category of the search.`news` is useful for retrieving real-time updates, particularly about politics, sports, and major current events covered by mainstream media sources. `general` is for broader, more general-purpose searches that may include a wide range of sources.<br/>
        /// Default Value: general
        /// </param>
        /// <param name="timeRange">
        /// The time range back from the current date to filter results based on publish date or last updated date. Useful when looking for sources that have published or updated data.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startDate">
        /// Will return all results after the specified start date based on publish date or last updated date. Required to be written in the format YYYY-MM-DD<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: 2025-02-09
        /// </param>
        /// <param name="endDate">
        /// Will return all results before the specified end date based on publish date or last updated date. Required to be written in the format YYYY-MM-DD<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: 2025-12-29
        /// </param>
        /// <param name="includeAnswer">
        /// Include an LLM-generated answer to the provided query. `basic` or `true` returns a quick answer. `advanced` returns a more detailed answer.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRawContent">
        /// Include the cleaned and parsed HTML content of each search result. `markdown` or `true` returns search result content in markdown format. `text` returns the plain text from the results and may increase latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeImages">
        /// Include images in the response. Returns both a top-level `images` list of query-related images and an `images` array inside each result object with images extracted from that specific source.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeImageDescriptions">
        /// When `include_images` is `true`, also add a descriptive text for each image.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFavicon">
        /// Whether to include the favicon URL for each result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeDomains">
        /// A list of domains to specifically include in the search results. Maximum 300 domains.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to specifically exclude from the search results. Maximum 150 domains.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="country">
        /// Boost search results from a specific country. This will prioritize content from the selected country in the search results. Available only if topic is `general`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoParameters">
        /// When `auto_parameters` is enabled, Tavily automatically configures search parameters based on your query's content and intent. You can still set other parameters manually, and your explicit values will override the automatic ones. The parameters `include_answer`, `include_raw_content`, and `max_results` must always be set manually, as they directly affect response size. Note: `search_depth` may be automatically set to advanced when it's likely to improve results. This uses 2 API credits per request. To avoid the extra cost, you can explicitly set `search_depth` to `basic`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="exactMatch">
        /// Ensure that only search results containing the exact quoted phrase(s) in the query are returned, bypassing synonyms or semantic variations. Wrap target phrases in quotes within your query (e.g. `"John Smith" CEO Acme Corp`). Punctuation is typically ignored inside quotes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeUsage">
        /// Whether to include credit usage information in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="safeSearch">
        /// 🔒 Enterprise only. <br/>
        ///  whether to filter out adult or unsafe content from results. Not supported for `fast` or `ultra-fast` search depths.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateSearchResponse> CreateSearchAsync(
            string query,
            global::G.CreateSearchRequestSearchDepth? searchDepth = default,
            int? chunksPerSource = default,
            int? maxResults = default,
            global::G.CreateSearchRequestTopic? topic = default,
            global::G.CreateSearchRequestTimeRange? timeRange = default,
            string? startDate = default,
            string? endDate = default,
            global::G.OneOf<bool?, global::G.CreateSearchRequestIncludeAnswer?>? includeAnswer = default,
            global::G.OneOf<bool?, global::G.CreateSearchRequestIncludeRawContent?>? includeRawContent = default,
            bool? includeImages = default,
            bool? includeImageDescriptions = default,
            bool? includeFavicon = default,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::G.CreateSearchRequestCountry? country = default,
            bool? autoParameters = default,
            bool? exactMatch = default,
            bool? includeUsage = default,
            bool? safeSearch = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateSearchRequest
            {
                Query = query,
                SearchDepth = searchDepth,
                ChunksPerSource = chunksPerSource,
                MaxResults = maxResults,
                Topic = topic,
                TimeRange = timeRange,
                StartDate = startDate,
                EndDate = endDate,
                IncludeAnswer = includeAnswer,
                IncludeRawContent = includeRawContent,
                IncludeImages = includeImages,
                IncludeImageDescriptions = includeImageDescriptions,
                IncludeFavicon = includeFavicon,
                IncludeDomains = includeDomains,
                ExcludeDomains = excludeDomains,
                Country = country,
                AutoParameters = autoParameters,
                ExactMatch = exactMatch,
                IncludeUsage = includeUsage,
                SafeSearch = safeSearch,
            };

            return await CreateSearchAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}