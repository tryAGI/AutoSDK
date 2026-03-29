//HintName: G.Api.ListPublicGenerationsGet.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareListPublicGenerationsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AnyOf<global::G.AssetType?, global::G.GenerationType?, object>? type,
            global::System.DateTime? createdBefore,
            global::System.DateTime? createdAfter,
            ref string? promptQuery,
            global::System.Guid? agentThreadId,
            ref string? ids,
            global::G.PagingParams? pagingParams);
        partial void PrepareListPublicGenerationsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AnyOf<global::G.AssetType?, global::G.GenerationType?, object>? type,
            global::System.DateTime? createdBefore,
            global::System.DateTime? createdAfter,
            string? promptQuery,
            global::System.Guid? agentThreadId,
            string? ids,
            global::G.PagingParams? pagingParams);
        partial void ProcessListPublicGenerationsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPublicGenerationsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdAfter"></param>
        /// <param name="promptQuery"></param>
        /// <param name="agentThreadId"></param>
        /// <param name="ids"></param>
        /// <param name="pagingParams">
        /// Default Value: {"limit":100,"offset":0}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PagedResponseGeneration> ListPublicGenerationsGetAsync(
            global::G.AnyOf<global::G.AssetType?, global::G.GenerationType?, object>? type = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? createdAfter = default,
            string? promptQuery = default,
            global::System.Guid? agentThreadId = default,
            string? ids = default,
            global::G.PagingParams? pagingParams = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListPublicGenerationsGetArguments(
                httpClient: HttpClient,
                type: ref type,
                createdBefore: createdBefore,
                createdAfter: createdAfter,
                promptQuery: ref promptQuery,
                agentThreadId: agentThreadId,
                ids: ref ids,
                pagingParams: pagingParams);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/public/generations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("type", type?.ToString())
                .AddOptionalParameter("created_before", createdBefore?.ToString())
                .AddOptionalParameter("created_after", createdAfter?.ToString())
                .AddOptionalParameter("prompt_query", promptQuery)
                .AddOptionalParameter("agent_thread_id", agentThreadId?.ToString())
                .AddOptionalParameter("ids", ids) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListPublicGenerationsGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                type: type,
                createdBefore: createdBefore,
                createdAfter: createdAfter,
                promptQuery: promptQuery,
                agentThreadId: agentThreadId,
                ids: ids,
                pagingParams: pagingParams);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListPublicGenerationsGetResponse(
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
                ProcessListPublicGenerationsGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PagedResponseGeneration.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PagedResponseGeneration.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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