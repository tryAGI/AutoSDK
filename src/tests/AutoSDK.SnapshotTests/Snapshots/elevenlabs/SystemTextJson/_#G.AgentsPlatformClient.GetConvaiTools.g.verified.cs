//HintName: G.AgentsPlatformClient.GetConvaiTools.g.cs

#nullable enable

namespace G
{
    public partial class AgentsPlatformClient
    {
        partial void PrepareGetConvaiToolsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? search,
            int? pageSize,
            ref bool? showOnlyOwnedDocuments,
            global::System.Collections.Generic.IList<global::G.ToolTypeFilter>? types,
            ref global::G.SortDirection? sortDirection,
            global::G.ToolSortBy? sortBy,
            ref string? cursor,
            ref string? xiApiKey);
        partial void PrepareGetConvaiToolsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? search,
            int? pageSize,
            bool? showOnlyOwnedDocuments,
            global::System.Collections.Generic.IList<global::G.ToolTypeFilter>? types,
            global::G.SortDirection? sortDirection,
            global::G.ToolSortBy? sortBy,
            string? cursor,
            string? xiApiKey);
        partial void ProcessGetConvaiToolsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetConvaiToolsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Tools<br/>
        /// Get all available tools in the workspace.
        /// </summary>
        /// <param name="search">
        /// If specified, the endpoint returns only tools whose names start with this string.
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only tools owned by you (and not shared from somebody else).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only tools of the given types.
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ToolsResponseModel> GetConvaiToolsAsync(
            string? search = default,
            int? pageSize = default,
            bool? showOnlyOwnedDocuments = default,
            global::System.Collections.Generic.IList<global::G.ToolTypeFilter>? types = default,
            global::G.SortDirection? sortDirection = default,
            global::G.ToolSortBy? sortBy = default,
            string? cursor = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetConvaiToolsArguments(
                httpClient: HttpClient,
                search: ref search,
                pageSize: pageSize,
                showOnlyOwnedDocuments: ref showOnlyOwnedDocuments,
                types: types,
                sortDirection: ref sortDirection,
                sortBy: sortBy,
                cursor: ref cursor,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/convai/tools",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("show_only_owned_documents", showOnlyOwnedDocuments?.ToString())
                .AddOptionalParameter("types", types?.ToString())
                .AddOptionalParameter("sort_direction", sortDirection?.ToValueString())
                .AddOptionalParameter("sort_by", sortBy?.ToString())
                .AddOptionalParameter("cursor", cursor) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetConvaiToolsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                search: search,
                pageSize: pageSize,
                showOnlyOwnedDocuments: showOnlyOwnedDocuments,
                types: types,
                sortDirection: sortDirection,
                sortBy: sortBy,
                cursor: cursor,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetConvaiToolsResponse(
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
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
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
                ProcessGetConvaiToolsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ToolsResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ToolsResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
    }
}