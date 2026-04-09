//HintName: G.ModelsClient.SearchRequests.g.cs

#nullable enable

namespace G
{
    public partial class ModelsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_SearchRequestsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKey",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_SearchRequestsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_SearchRequestsSecurityRequirement0,
            };
        partial void PrepareSearchRequestsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref string? cursor,
            ref string? query,
            ref string? imageUrl,
            ref string? videoUrl,
            ref string? endpoint,
            ref bool? excludeApiRequests,
            ref bool? onlyApiRequests,
            ref double? minSimilarity);
        partial void PrepareSearchRequestsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            string? cursor,
            string? query,
            string? imageUrl,
            string? videoUrl,
            string? endpoint,
            bool? excludeApiRequests,
            bool? onlyApiRequests,
            double? minSimilarity);
        partial void ProcessSearchRequestsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchRequestsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search Requests<br/>
        /// Search, filter, and browse your request history. Supports three modes:<br/>
        /// **1. Semantic Search** (`query`, `image_url`, or `video_url` parameter):<br/>
        /// Find visually or conceptually similar results using AI embeddings. Provide a text<br/>
        /// query for text-to-image search, an image URL for image-to-image similarity search,<br/>
        /// or a video URL for video-to-image similarity search.<br/>
        /// **2. Filtered Browse** (no `query`, `image_url`, or `video_url`):<br/>
        /// Browse request history with hard filters. Returns results ordered by creation date (newest first).<br/>
        /// **3. Semantic + Filters** (search params AND filter params):<br/>
        /// Combine semantic search with hard filters. Filters narrow the candidate set before<br/>
        /// ranking by similarity.<br/>
        /// **Filter Options:**<br/>
        /// - `endpoint`: Filter by fal endpoint<br/>
        /// - `exclude_api_requests` / `only_api_requests`: Filter by request source<br/>
        /// **Restricted Request View:**<br/>
        /// For accounts with restricted request view enabled, an admin API key is required.<br/>
        /// Non-admin keys will receive a 403 error.<br/>
        /// **Examples:**<br/>
        /// - Semantic text search: `?query=sunset+landscape`<br/>
        /// - Image similarity: `?image_url=https://...&amp;min_similarity=0.5`<br/>
        /// - Filtered search: `?query=portrait&amp;endpoint=fal-ai/flux/dev`<br/>
        /// - Browse by endpoint: `?endpoint=fal-ai/flux/dev`
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="query">
        /// Text search query for semantic search. Mutually exclusive with image_url and video_url.<br/>
        /// Example: sunset landscape
        /// </param>
        /// <param name="imageUrl">
        /// Image URL for similarity search. Mutually exclusive with query and video_url.<br/>
        /// Example: https://v3.fal.media/files/abc123/output.png
        /// </param>
        /// <param name="videoUrl">
        /// Video URL for similarity search. Mutually exclusive with query and image_url.<br/>
        /// Example: https://v3.fal.media/files/abc123/output.mp4
        /// </param>
        /// <param name="endpoint">
        /// Filter by fal endpoint to scope request history.<br/>
        /// Example: fal-ai/flux/dev
        /// </param>
        /// <param name="excludeApiRequests">
        /// Exclude requests made via API keys (only show playground/UI requests). Mutually exclusive with only_api_requests.<br/>
        /// Example: true
        /// </param>
        /// <param name="onlyApiRequests">
        /// Only include requests made via API keys. Mutually exclusive with exclude_api_requests.<br/>
        /// Example: true
        /// </param>
        /// <param name="minSimilarity">
        /// Minimum similarity score (0-1) for semantic search results. Only applies when query or image_url is provided.<br/>
        /// Example: 0.3F
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchRequestsResponse> SearchRequestsAsync(
            int? limit = default,
            string? cursor = default,
            string? query = default,
            string? imageUrl = default,
            string? videoUrl = default,
            string? endpoint = default,
            bool? excludeApiRequests = default,
            bool? onlyApiRequests = default,
            double? minSimilarity = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSearchRequestsArguments(
                httpClient: HttpClient,
                limit: ref limit,
                cursor: ref cursor,
                query: ref query,
                imageUrl: ref imageUrl,
                videoUrl: ref videoUrl,
                endpoint: ref endpoint,
                excludeApiRequests: ref excludeApiRequests,
                onlyApiRequests: ref onlyApiRequests,
                minSimilarity: ref minSimilarity);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SearchRequestsSecurityRequirements,
                operationName: "SearchRequestsAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/models/requests/search",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("query", query)
                .AddOptionalParameter("image_url", imageUrl)
                .AddOptionalParameter("video_url", videoUrl)
                .AddOptionalParameter("endpoint", endpoint)
                .AddOptionalParameter("exclude_api_requests", excludeApiRequests?.ToString().ToLowerInvariant())
                .AddOptionalParameter("only_api_requests", onlyApiRequests?.ToString().ToLowerInvariant())
                .AddOptionalParameter("min_similarity", minSimilarity?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSearchRequestsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                limit: limit,
                cursor: cursor,
                query: query,
                imageUrl: imageUrl,
                videoUrl: videoUrl,
                endpoint: endpoint,
                excludeApiRequests: excludeApiRequests,
                onlyApiRequests: onlyApiRequests,
                minSimilarity: minSimilarity);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSearchRequestsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request parameters
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.SearchRequestsResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.SearchRequestsResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.SearchRequestsResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.SearchRequestsResponse2>(
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
            // Authentication required
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.SearchRequestsResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.SearchRequestsResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.SearchRequestsResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.SearchRequestsResponse3>(
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
            // Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.SearchRequestsResponse4? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.SearchRequestsResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.SearchRequestsResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.SearchRequestsResponse4>(
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
            // Internal server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.SearchRequestsResponse5? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.SearchRequestsResponse5.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.SearchRequestsResponse5.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.SearchRequestsResponse5>(
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
                ProcessSearchRequestsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.SearchRequestsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.SearchRequestsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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