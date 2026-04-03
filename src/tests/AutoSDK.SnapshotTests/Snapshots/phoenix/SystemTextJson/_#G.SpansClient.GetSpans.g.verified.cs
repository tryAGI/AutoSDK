//HintName: G.SpansClient.GetSpans.g.cs

#nullable enable

namespace G
{
    public partial class SpansClient
    {
        partial void PrepareGetSpansArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectIdentifier,
            ref string? cursor,
            ref int? limit,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::System.Collections.Generic.IList<string>? traceId,
            ref string? parentId,
            global::System.Collections.Generic.IList<string>? name,
            global::System.Collections.Generic.IList<string>? spanKind,
            global::System.Collections.Generic.IList<string>? statusCode);
        partial void PrepareGetSpansRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectIdentifier,
            string? cursor,
            int? limit,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::System.Collections.Generic.IList<string>? traceId,
            string? parentId,
            global::System.Collections.Generic.IList<string>? name,
            global::System.Collections.Generic.IList<string>? spanKind,
            global::System.Collections.Generic.IList<string>? statusCode);
        partial void ProcessGetSpansResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSpansResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List spans with simple filters (no DSL)<br/>
        /// Return spans within a project filtered by time range. Supports cursor-based pagination.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor (Span Global ID)
        /// </param>
        /// <param name="limit">
        /// Maximum number of spans to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="startTime">
        /// Inclusive lower bound time
        /// </param>
        /// <param name="endTime">
        /// Exclusive upper bound time
        /// </param>
        /// <param name="traceId">
        /// Filter by one or more trace IDs
        /// </param>
        /// <param name="parentId">
        /// Filter by parent span ID. Use "null" to get root spans only.
        /// </param>
        /// <param name="name">
        /// Filter by span name(s)
        /// </param>
        /// <param name="spanKind">
        /// Filter by span kind(s). Values: LLM, CHAIN, TOOL, RETRIEVER, EMBEDDING, AGENT, RERANKER, GUARDRAIL, EVALUATOR, UNKNOWN
        /// </param>
        /// <param name="statusCode">
        /// Filter by status code(s). Values: OK, ERROR, UNSET
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SpansResponseBody> GetSpansAsync(
            string projectIdentifier,
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Collections.Generic.IList<string>? traceId = default,
            string? parentId = default,
            global::System.Collections.Generic.IList<string>? name = default,
            global::System.Collections.Generic.IList<string>? spanKind = default,
            global::System.Collections.Generic.IList<string>? statusCode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSpansArguments(
                httpClient: HttpClient,
                projectIdentifier: ref projectIdentifier,
                cursor: ref cursor,
                limit: ref limit,
                startTime: startTime,
                endTime: endTime,
                traceId: traceId,
                parentId: ref parentId,
                name: name,
                spanKind: spanKind,
                statusCode: statusCode);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/projects/{projectIdentifier}/spans",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("start_time", startTime?.ToString())
                .AddOptionalParameter("end_time", endTime?.ToString())
                .AddOptionalParameter("trace_id", traceId?.ToString())
                .AddOptionalParameter("parent_id", parentId)
                .AddOptionalParameter("name", name?.ToString())
                .AddOptionalParameter("span_kind", spanKind?.ToString())
                .AddOptionalParameter("status_code", statusCode?.ToString()) 
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
            PrepareGetSpansRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectIdentifier: projectIdentifier,
                cursor: cursor,
                limit: limit,
                startTime: startTime,
                endTime: endTime,
                traceId: traceId,
                parentId: parentId,
                name: name,
                spanKind: spanKind,
                statusCode: statusCode);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSpansResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                string? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<string>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not Found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                string? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<string>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unprocessable Entity
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                string? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<string>(
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
                ProcessGetSpansResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.SpansResponseBody.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.SpansResponseBody.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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