//HintName: G.ToolsApiClient.CreateToolsWebSearch.g.cs

#nullable enable

namespace G
{
    public partial class ToolsApiClient
    {
        partial void PrepareCreateToolsWebSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.WebSearchRequest request);
        partial void PrepareCreateToolsWebSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.WebSearchRequest request);
        partial void ProcessCreateToolsWebSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateToolsWebSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Web search<br/>
        /// Search the web for information about a given query and return relevant results with source URLs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/tools/web-search \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"query":"How do I get an API key for the Writer API?","include_domains":["dev.writer.com"]}'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.WebSearchResponse> CreateToolsWebSearchAsync(

            global::G.WebSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateToolsWebSearchArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/tools/web-search",
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
            PrepareCreateToolsWebSearchRequest(
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
            ProcessCreateToolsWebSearchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessCreateToolsWebSearchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.WebSearchResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.WebSearchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Web search<br/>
        /// Search the web for information about a given query and return relevant results with source URLs.
        /// </summary>
        /// <param name="query">
        /// The search query.
        /// </param>
        /// <param name="topic">
        /// The search topic category. Use `news` for current events and news articles, or `general` for broader web search.<br/>
        /// Default Value: general
        /// </param>
        /// <param name="searchDepth">
        /// Controls search comprehensiveness:<br/>
        /// - `basic`: Returns fewer but highly relevant results<br/>
        /// - `advanced`: Performs a deeper search with more results<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="chunksPerSource">
        /// Only applies when `search_depth` is `advanced`. Specifies how many text segments to extract from each source. Limited to 3 chunks maximum.
        /// </param>
        /// <param name="maxResults">
        /// Limits the number of search results returned. Cannot exceed 20 sources.
        /// </param>
        /// <param name="timeRange">
        /// Filters results to content published within the specified time range back from the current date. For example, `week` or `w` returns results from the past 7 days.
        /// </param>
        /// <param name="days">
        /// For news topic searches, specifies how many days of news coverage to include.
        /// </param>
        /// <param name="includeRawContent">
        /// Controls how raw content is included in search results:<br/>
        /// - `text`: Returns plain text without formatting markup<br/>
        /// - `markdown`: Returns structured content with markdown formatting (headers, links, bold text)<br/>
        /// - `true`: Same as `markdown`<br/>
        /// - `false`: Raw content is not included (default if unset)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeAnswer">
        /// Whether to include a generated answer to the query in the response. If `false`, only search results are returned.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeDomains">
        /// Domains to include in the search. If unset, the search includes all domains.
        /// </param>
        /// <param name="excludeDomains">
        /// Domains to exclude from the search. If unset, the search includes all domains.
        /// </param>
        /// <param name="country">
        /// Localizes search results to a specific country. Only applies to general topic searches.
        /// </param>
        /// <param name="stream">
        /// Enables streaming of search results as they become available.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.WebSearchResponse> CreateToolsWebSearchAsync(
            string? query = default,
            global::G.WebSearchRequestTopic? topic = default,
            global::G.WebSearchRequestSearchDepth? searchDepth = default,
            int? chunksPerSource = default,
            int? maxResults = default,
            global::G.WebSearchRequestTimeRange? timeRange = default,
            int? days = default,
            global::G.OneOf<global::G.WebSearchRequestIncludeRawContent?, bool?>? includeRawContent = default,
            bool? includeAnswer = default,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::G.WebSearchRequestCountry? country = default,
            bool? stream = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.WebSearchRequest
            {
                Query = query,
                Topic = topic,
                SearchDepth = searchDepth,
                ChunksPerSource = chunksPerSource,
                MaxResults = maxResults,
                TimeRange = timeRange,
                Days = days,
                IncludeRawContent = includeRawContent,
                IncludeAnswer = includeAnswer,
                IncludeDomains = includeDomains,
                ExcludeDomains = excludeDomains,
                Country = country,
                Stream = stream,
            };

            return await CreateToolsWebSearchAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}