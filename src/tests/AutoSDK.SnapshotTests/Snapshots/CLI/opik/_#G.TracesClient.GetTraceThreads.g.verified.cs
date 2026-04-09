//HintName: G.TracesClient.GetTraceThreads.g.cs

#nullable enable

namespace G
{
    public partial class TracesClient
    {
        partial void PrepareGetTraceThreadsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? size,
            ref string? projectName,
            ref global::System.Guid? projectId,
            ref bool? truncate,
            ref bool? stripAttachments,
            ref string? filters,
            ref string? sorting,
            ref string? search,
            ref global::System.DateTime? fromTime,
            ref global::System.DateTime? toTime);
        partial void PrepareGetTraceThreadsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? size,
            string? projectName,
            global::System.Guid? projectId,
            bool? truncate,
            bool? stripAttachments,
            string? filters,
            string? sorting,
            string? search,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime);
        partial void ProcessGetTraceThreadsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTraceThreadsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get trace threads<br/>
        /// Get trace threads
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="truncate">
        /// Truncate input, output and metadata to slim payloads<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stripAttachments">
        /// If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="search">
        /// Full-text search across thread fields
        /// </param>
        /// <param name="fromTime">
        /// Filter trace threads created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter trace threads created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TraceThreadPage> GetTraceThreadsAsync(
            int? page = default,
            int? size = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            bool? truncate = default,
            bool? stripAttachments = default,
            string? filters = default,
            string? sorting = default,
            string? search = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTraceThreadsArguments(
                httpClient: HttpClient,
                page: ref page,
                size: ref size,
                projectName: ref projectName,
                projectId: ref projectId,
                truncate: ref truncate,
                stripAttachments: ref stripAttachments,
                filters: ref filters,
                sorting: ref sorting,
                search: ref search,
                fromTime: ref fromTime,
                toTime: ref toTime);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/traces/threads",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("size", size?.ToString())
                .AddOptionalParameter("project_name", projectName)
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("truncate", truncate?.ToString().ToLowerInvariant())
                .AddOptionalParameter("strip_attachments", stripAttachments?.ToString().ToLowerInvariant())
                .AddOptionalParameter("filters", filters)
                .AddOptionalParameter("sorting", sorting)
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
            PrepareGetTraceThreadsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                size: size,
                projectName: projectName,
                projectId: projectId,
                truncate: truncate,
                stripAttachments: stripAttachments,
                filters: filters,
                sorting: sorting,
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
            ProcessGetTraceThreadsResponse(
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
                ProcessGetTraceThreadsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TraceThreadPage.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TraceThreadPage.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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