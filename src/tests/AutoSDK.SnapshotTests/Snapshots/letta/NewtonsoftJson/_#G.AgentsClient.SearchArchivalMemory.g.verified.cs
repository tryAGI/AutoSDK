//HintName: G.AgentsClient.SearchArchivalMemory.g.cs

#nullable enable

namespace G
{
    public partial class AgentsClient
    {
        partial void PrepareSearchArchivalMemoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            ref string query,
            global::System.Collections.Generic.IList<string>? tags,
            ref global::G.SearchArchivalMemoryTagMatchMode? tagMatchMode,
            int? topK,
            global::System.DateTime? startDatetime,
            global::System.DateTime? endDatetime);
        partial void PrepareSearchArchivalMemoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            string query,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.SearchArchivalMemoryTagMatchMode? tagMatchMode,
            int? topK,
            global::System.DateTime? startDatetime,
            global::System.DateTime? endDatetime);
        partial void ProcessSearchArchivalMemoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchArchivalMemoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search Archival Memory<br/>
        /// Search archival memory using semantic (embedding-based) search with optional temporal filtering.<br/>
        /// This endpoint allows manual triggering of archival memory searches, enabling users to query<br/>
        /// an agent's archival memory store directly via the API. The search uses the same functionality<br/>
        /// as the agent's archival_memory_search tool but is accessible for external API usage.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="query">
        /// String to search for using semantic similarity
        /// </param>
        /// <param name="tags">
        /// Optional list of tags to filter search results
        /// </param>
        /// <param name="tagMatchMode">
        /// How to match tags - 'any' to match passages with any of the tags, 'all' to match only passages with all tags<br/>
        /// Default Value: any
        /// </param>
        /// <param name="topK">
        /// Maximum number of results to return. Uses system default if not specified
        /// </param>
        /// <param name="startDatetime">
        /// Filter results to passages created after this datetime
        /// </param>
        /// <param name="endDatetime">
        /// Filter results to passages created before this datetime
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ArchivalMemorySearchResponse> SearchArchivalMemoryAsync(
            string agentId,
            string query,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.SearchArchivalMemoryTagMatchMode? tagMatchMode = default,
            int? topK = default,
            global::System.DateTime? startDatetime = default,
            global::System.DateTime? endDatetime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSearchArchivalMemoryArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                query: ref query,
                tags: tags,
                tagMatchMode: ref tagMatchMode,
                topK: topK,
                startDatetime: startDatetime,
                endDatetime: endDatetime);

            var tagMatchModeValue = tagMatchMode switch
            {
                global::G.SearchArchivalMemoryTagMatchMode.Any => "any",
                global::G.SearchArchivalMemoryTagMatchMode.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/agents/{agentId}/archival-memory/search",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("query", query)
                .AddOptionalParameter("tags", tags?.ToString())
                .AddOptionalParameter("tag_match_mode", tagMatchMode?.ToValueString())
                .AddOptionalParameter("top_k", topK?.ToString())
                .AddOptionalParameter("start_datetime", startDatetime?.ToString())
                .AddOptionalParameter("end_datetime", endDatetime?.ToString()) 
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
            PrepareSearchArchivalMemoryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                query: query,
                tags: tags,
                tagMatchMode: tagMatchMode,
                topK: topK,
                startDatetime: startDatetime,
                endDatetime: endDatetime);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSearchArchivalMemoryResponse(
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
                ProcessSearchArchivalMemoryResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ArchivalMemorySearchResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ArchivalMemorySearchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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