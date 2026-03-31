//HintName: G.StoresClient.SearchStoreChunks.g.cs

#nullable enable

namespace G
{
    public partial class StoresClient
    {
        partial void PrepareSearchStoreChunksArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.StoreChunkSearchParams request);
        partial void PrepareSearchStoreChunksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.StoreChunkSearchParams request);
        partial void ProcessSearchStoreChunksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchStoreChunksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Perform semantic search across store chunks<br/>
        /// Perform semantic search across store chunks.<br/>
        /// This endpoint searches through store chunks using semantic similarity matching.<br/>
        /// It supports complex search queries with filters and returns relevance-scored results.<br/>
        /// For the special 'mixedbread/web' store, this endpoint performs web search using<br/>
        /// a mixture of different providers instead of semantic search. Web search results are always<br/>
        /// reranked for consistent scoring.<br/>
        /// Args:<br/>
        ///     search_params: Search configuration including:<br/>
        ///         - query text or embeddings<br/>
        ///         - store_identifiers: List of store identifiers to search<br/>
        ///         - file_ids: Optional list of file IDs to filter chunks by (or tuple of list and condition operator)<br/>
        ///         - metadata filters<br/>
        ///         - pagination parameters<br/>
        ///         - sorting preferences<br/>
        ///     _state: API state dependency<br/>
        ///     _ctx: Service context dependency<br/>
        /// Returns:<br/>
        ///     StoreSearchResponse containing:<br/>
        ///         - List of matched chunks with relevance scores<br/>
        ///         - Pagination details including total result count<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If search parameters are invalid<br/>
        ///     HTTPException (404): If no vector stores are found to search
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StoreSearchResponse> SearchStoreChunksAsync(

            global::G.StoreChunkSearchParams request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSearchStoreChunksArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/stores/search",
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
            PrepareSearchStoreChunksRequest(
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
            ProcessSearchStoreChunksResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
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
                ProcessSearchStoreChunksResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.StoreSearchResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.StoreSearchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Perform semantic search across store chunks<br/>
        /// Perform semantic search across store chunks.<br/>
        /// This endpoint searches through store chunks using semantic similarity matching.<br/>
        /// It supports complex search queries with filters and returns relevance-scored results.<br/>
        /// For the special 'mixedbread/web' store, this endpoint performs web search using<br/>
        /// a mixture of different providers instead of semantic search. Web search results are always<br/>
        /// reranked for consistent scoring.<br/>
        /// Args:<br/>
        ///     search_params: Search configuration including:<br/>
        ///         - query text or embeddings<br/>
        ///         - store_identifiers: List of store identifiers to search<br/>
        ///         - file_ids: Optional list of file IDs to filter chunks by (or tuple of list and condition operator)<br/>
        ///         - metadata filters<br/>
        ///         - pagination parameters<br/>
        ///         - sorting preferences<br/>
        ///     _state: API state dependency<br/>
        ///     _ctx: Service context dependency<br/>
        /// Returns:<br/>
        ///     StoreSearchResponse containing:<br/>
        ///         - List of matched chunks with relevance scores<br/>
        ///         - Pagination details including total result count<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If search parameters are invalid<br/>
        ///     HTTPException (404): If no vector stores are found to search
        /// </summary>
        /// <param name="query">
        /// Search query text
        /// </param>
        /// <param name="storeIdentifiers">
        /// IDs or names of stores to search
        /// </param>
        /// <param name="topK">
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filters">
        /// Optional filter conditions
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </param>
        /// <param name="searchOptions">
        /// Search configuration options
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StoreSearchResponse> SearchStoreChunksAsync(
            global::G.MultiModalQuery query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            int? topK = default,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters = default,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::G.StoreChunkSearchOptions? searchOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.StoreChunkSearchParams
            {
                Query = query,
                StoreIdentifiers = storeIdentifiers,
                TopK = topK,
                Filters = filters,
                FileIds = fileIds,
                SearchOptions = searchOptions,
            };

            return await SearchStoreChunksAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}