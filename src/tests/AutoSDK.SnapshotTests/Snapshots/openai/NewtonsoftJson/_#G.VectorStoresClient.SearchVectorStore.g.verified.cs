//HintName: G.VectorStoresClient.SearchVectorStore.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        partial void PrepareSearchVectorStoreArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string vectorStoreId,
            global::G.VectorStoreSearchRequest request);
        partial void PrepareSearchVectorStoreRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string vectorStoreId,
            global::G.VectorStoreSearchRequest request);
        partial void ProcessSearchVectorStoreResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchVectorStoreResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search a vector store for relevant chunks based on a query and file attributes filter.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VectorStoreSearchResultsPage> SearchVectorStoreAsync(
            string vectorStoreId,
            global::G.VectorStoreSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSearchVectorStoreArguments(
                httpClient: HttpClient,
                vectorStoreId: ref vectorStoreId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/vector_stores/{vectorStoreId}/search",
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
            PrepareSearchVectorStoreRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                vectorStoreId: vectorStoreId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSearchVectorStoreResponse(
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
                ProcessSearchVectorStoreResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.VectorStoreSearchResultsPage.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::G.VectorStoreSearchResultsPage.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Search a vector store for relevant chunks based on a query and file attributes filter.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="filters">
        /// A filter to apply based on file attributes.
        /// </param>
        /// <param name="maxNumResults">
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="query">
        /// A query string for a search
        /// </param>
        /// <param name="rankingOptions">
        /// Ranking options for search.
        /// </param>
        /// <param name="rewriteQuery">
        /// Whether to rewrite the natural language query for vector search.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VectorStoreSearchResultsPage> SearchVectorStoreAsync(
            string vectorStoreId,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> query,
            global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>? filters = default,
            int? maxNumResults = default,
            global::G.VectorStoreSearchRequestRankingOptions? rankingOptions = default,
            bool? rewriteQuery = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.VectorStoreSearchRequest
            {
                Filters = filters,
                MaxNumResults = maxNumResults,
                Query = query,
                RankingOptions = rankingOptions,
                RewriteQuery = rewriteQuery,
            };

            return await SearchVectorStoreAsync(
                vectorStoreId: vectorStoreId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}