//HintName: G.SpansClient.GetSpanStats.g.cs

#nullable enable

namespace G
{
    public partial class SpansClient
    {
        partial void PrepareGetSpanStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid? projectId,
            ref string? projectName,
            ref global::System.Guid? traceId,
            ref global::G.GetSpanStatsType? type,
            ref string? filters,
            ref string? search,
            ref global::System.DateTime? fromTime,
            ref global::System.DateTime? toTime);
        partial void PrepareGetSpanStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? projectId,
            string? projectName,
            global::System.Guid? traceId,
            global::G.GetSpanStatsType? type,
            string? filters,
            string? search,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime);
        partial void ProcessGetSpanStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSpanStatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get span stats<br/>
        /// Get span stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="traceId"></param>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        /// <param name="search">
        /// Full-text search across span fields
        /// </param>
        /// <param name="fromTime">
        /// Filter spans created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter spans created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectStatsPublic> GetSpanStatsAsync(
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::System.Guid? traceId = default,
            global::G.GetSpanStatsType? type = default,
            string? filters = default,
            string? search = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSpanStatsArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                projectName: ref projectName,
                traceId: ref traceId,
                type: ref type,
                filters: ref filters,
                search: ref search,
                fromTime: ref fromTime,
                toTime: ref toTime);

            var typeValue = type switch
            {
                global::G.GetSpanStatsType.General => "general",
                global::G.GetSpanStatsType.Tool => "tool",
                global::G.GetSpanStatsType.Llm => "llm",
                global::G.GetSpanStatsType.Guardrail => "guardrail",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/spans/stats",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("project_name", projectName)
                .AddOptionalParameter("trace_id", traceId?.ToString())
                .AddOptionalParameter("type", type?.ToValueString())
                .AddOptionalParameter("filters", filters)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("from_time", fromTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("to_time", toTime?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
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
            PrepareGetSpanStatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                projectName: projectName,
                traceId: traceId,
                type: type,
                filters: filters,
                search: search,
                fromTime: fromTime,
                toTime: toTime);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSpanStatsResponse(
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
                ProcessGetSpanStatsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ProjectStatsPublic.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ProjectStatsPublic.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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