//HintName: G.Api.WebSearch.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareWebSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string q,
            ref string? country,
            ref string? searchLang,
            ref string? uiLang,
            ref int? count,
            ref int? offset,
            ref global::G.WebSearchSafesearch? safesearch,
            ref string? freshness,
            ref bool? textDecorations,
            ref bool? spellcheck,
            ref string? resultFilter,
            ref string? gogglesId,
            ref global::G.WebSearchUnits? units,
            ref bool? extraSnippets,
            ref bool? summary);
        partial void PrepareWebSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string q,
            string? country,
            string? searchLang,
            string? uiLang,
            int? count,
            int? offset,
            global::G.WebSearchSafesearch? safesearch,
            string? freshness,
            bool? textDecorations,
            bool? spellcheck,
            string? resultFilter,
            string? gogglesId,
            global::G.WebSearchUnits? units,
            bool? extraSnippets,
            bool? summary);
        partial void ProcessWebSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessWebSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Web Search<br/>
        /// Search the web using Brave Search. Returns web results, videos, news,<br/>
        /// locations, infoboxes, discussions, FAQs, and related content.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="country">
        /// Default Value: us
        /// </param>
        /// <param name="searchLang">
        /// Default Value: en
        /// </param>
        /// <param name="uiLang">
        /// Default Value: en-US
        /// </param>
        /// <param name="count">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="safesearch">
        /// Default Value: moderate
        /// </param>
        /// <param name="freshness"></param>
        /// <param name="textDecorations">
        /// Default Value: true
        /// </param>
        /// <param name="spellcheck">
        /// Default Value: true
        /// </param>
        /// <param name="resultFilter"></param>
        /// <param name="gogglesId"></param>
        /// <param name="units"></param>
        /// <param name="extraSnippets">
        /// Default Value: false
        /// </param>
        /// <param name="summary">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.WebSearchResponse> WebSearchAsync(
            string q,
            string? country = default,
            string? searchLang = default,
            string? uiLang = default,
            int? count = default,
            int? offset = default,
            global::G.WebSearchSafesearch? safesearch = default,
            string? freshness = default,
            bool? textDecorations = default,
            bool? spellcheck = default,
            string? resultFilter = default,
            string? gogglesId = default,
            global::G.WebSearchUnits? units = default,
            bool? extraSnippets = default,
            bool? summary = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareWebSearchArguments(
                httpClient: HttpClient,
                q: ref q,
                country: ref country,
                searchLang: ref searchLang,
                uiLang: ref uiLang,
                count: ref count,
                offset: ref offset,
                safesearch: ref safesearch,
                freshness: ref freshness,
                textDecorations: ref textDecorations,
                spellcheck: ref spellcheck,
                resultFilter: ref resultFilter,
                gogglesId: ref gogglesId,
                units: ref units,
                extraSnippets: ref extraSnippets,
                summary: ref summary);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/web/search",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("q", q)
                .AddOptionalParameter("country", country)
                .AddOptionalParameter("search_lang", searchLang)
                .AddOptionalParameter("ui_lang", uiLang)
                .AddOptionalParameter("count", count?.ToString())
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("safesearch", safesearch?.ToValueString())
                .AddOptionalParameter("freshness", freshness)
                .AddOptionalParameter("text_decorations", textDecorations?.ToString().ToLowerInvariant())
                .AddOptionalParameter("spellcheck", spellcheck?.ToString().ToLowerInvariant())
                .AddOptionalParameter("result_filter", resultFilter)
                .AddOptionalParameter("goggles_id", gogglesId)
                .AddOptionalParameter("units", units?.ToValueString())
                .AddOptionalParameter("extra_snippets", extraSnippets?.ToString().ToLowerInvariant())
                .AddOptionalParameter("summary", summary?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareWebSearchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                q: q,
                country: country,
                searchLang: searchLang,
                uiLang: uiLang,
                count: count,
                offset: offset,
                safesearch: safesearch,
                freshness: freshness,
                textDecorations: textDecorations,
                spellcheck: spellcheck,
                resultFilter: resultFilter,
                gogglesId: gogglesId,
                units: units,
                extraSnippets: extraSnippets,
                summary: summary);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessWebSearchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Unauthorized — invalid or missing API key.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.ErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.ErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
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
            // Rate limit exceeded.
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.ErrorResponse? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.ErrorResponse.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.ErrorResponse.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
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
                ProcessWebSearchResponseContent(
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
    }
}