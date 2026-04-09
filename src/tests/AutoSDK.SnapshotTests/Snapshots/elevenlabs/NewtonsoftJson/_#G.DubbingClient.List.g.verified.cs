//HintName: G.DubbingClient.List.g.cs

#nullable enable

namespace G
{
    public partial class DubbingClient
    {
        partial void PrepareListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? cursor,
            ref int? pageSize,
            ref global::G.ListDubsDubbingStatus? dubbingStatus,
            ref global::G.ListDubsFilterByCreator? filterByCreator,
            ref string? orderBy,
            ref global::G.ListDubsOrderDirection? orderDirection,
            ref string? xiApiKey);
        partial void PrepareListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? cursor,
            int? pageSize,
            global::G.ListDubsDubbingStatus? dubbingStatus,
            global::G.ListDubsFilterByCreator? filterByCreator,
            string? orderBy,
            global::G.ListDubsOrderDirection? orderDirection,
            string? xiApiKey);
        partial void ProcessListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Dubs<br/>
        /// List the dubs you have access to.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many dubs to return at maximum. Can not exceed 200, defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="dubbingStatus">
        /// What state the dub is currently in.
        /// </param>
        /// <param name="filterByCreator">
        /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="orderBy">
        /// The field to use for ordering results from this query.<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="orderDirection">
        /// The order direction to use for results from this query.<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DubbingMetadataPageResponseModel> ListAsync(
            string? cursor = default,
            int? pageSize = default,
            global::G.ListDubsDubbingStatus? dubbingStatus = default,
            global::G.ListDubsFilterByCreator? filterByCreator = default,
            string? orderBy = default,
            global::G.ListDubsOrderDirection? orderDirection = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListArguments(
                httpClient: HttpClient,
                cursor: ref cursor,
                pageSize: ref pageSize,
                dubbingStatus: ref dubbingStatus,
                filterByCreator: ref filterByCreator,
                orderBy: ref orderBy,
                orderDirection: ref orderDirection,
                xiApiKey: ref xiApiKey);

            var dubbingStatusValue = dubbingStatus switch
            {
                global::G.ListDubsDubbingStatus.Dubbing => "dubbing",
                global::G.ListDubsDubbingStatus.Dubbed => "dubbed",
                global::G.ListDubsDubbingStatus.Failed => "failed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var filterByCreatorValue = filterByCreator switch
            {
                global::G.ListDubsFilterByCreator.Personal => "personal",
                global::G.ListDubsFilterByCreator.Others => "others",
                global::G.ListDubsFilterByCreator.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderDirectionValue = orderDirection switch
            {
                global::G.ListDubsOrderDirection.Descending => "DESCENDING",
                global::G.ListDubsOrderDirection.Ascending => "ASCENDING",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/dubbing",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("dubbing_status", dubbingStatus?.ToValueString())
                .AddOptionalParameter("filter_by_creator", filterByCreator?.ToValueString())
                .AddOptionalParameter("order_by", orderBy)
                .AddOptionalParameter("order_direction", orderDirection?.ToValueString()) 
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
            PrepareListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cursor: cursor,
                pageSize: pageSize,
                dubbingStatus: dubbingStatus,
                filterByCreator: filterByCreator,
                orderBy: orderBy,
                orderDirection: orderDirection,
                xiApiKey: xiApiKey);

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
                ProcessListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DubbingMetadataPageResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.DubbingMetadataPageResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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