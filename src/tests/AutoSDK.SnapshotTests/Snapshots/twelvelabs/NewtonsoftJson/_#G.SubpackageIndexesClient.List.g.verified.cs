//HintName: G.SubpackageIndexesClient.List.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageIndexesClient
    {
        partial void PrepareListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? pageLimit,
            ref string? sortBy,
            ref string? sortOption,
            ref string? indexName,
            ref string? modelOptions,
            ref string? modelFamily,
            ref string? createdAt,
            ref string? updatedAt,
            ref string xApiKey);
        partial void PrepareListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? pageLimit,
            string? sortBy,
            string? sortOption,
            string? indexName,
            string? modelOptions,
            string? modelFamily,
            string? createdAt,
            string? updatedAt,
            string xApiKey);
        partial void ProcessListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List indexes<br/>
        /// This method returns a list of the indexes in your account. The platform returns indexes sorted by creation date, with the oldest indexes at the top of the list.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="modelOptions"></param>
        /// <param name="modelFamily"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.IndexesListResponse200> ListAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            string? sortBy = default,
            string? sortOption = default,
            string? indexName = default,
            string? modelOptions = default,
            string? modelFamily = default,
            string? createdAt = default,
            string? updatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListArguments(
                httpClient: HttpClient,
                page: ref page,
                pageLimit: ref pageLimit,
                sortBy: ref sortBy,
                sortOption: ref sortOption,
                indexName: ref indexName,
                modelOptions: ref modelOptions,
                modelFamily: ref modelFamily,
                createdAt: ref createdAt,
                updatedAt: ref updatedAt,
                xApiKey: ref xApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/indexes",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_limit", pageLimit?.ToString())
                .AddOptionalParameter("sort_by", sortBy)
                .AddOptionalParameter("sort_option", sortOption)
                .AddOptionalParameter("index_name", indexName)
                .AddOptionalParameter("model_options", modelOptions)
                .AddOptionalParameter("model_family", modelFamily)
                .AddOptionalParameter("created_at", createdAt)
                .AddOptionalParameter("updated_at", updatedAt) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                pageLimit: pageLimit,
                sortBy: sortBy,
                sortOption: sortOption,
                indexName: indexName,
                modelOptions: modelOptions,
                modelFamily: modelFamily,
                createdAt: createdAt,
                updatedAt: updatedAt,
                xApiKey: xApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // The request has failed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.ListIndexesRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.ListIndexesRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.ListIndexesRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.ListIndexesRequestBadRequestError>(
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
                ProcessListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.IndexesListResponse200.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.IndexesListResponse200.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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