//HintName: G.TracesClient.GetTracesByProject.g.cs

#nullable enable

namespace G
{
    public partial class TracesClient
    {
        partial void PrepareGetTracesByProjectArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? size,
            ref string? projectName,
            ref global::System.Guid? projectId,
            ref string? filters,
            ref bool? truncate,
            ref bool? stripAttachments,
            ref string? sorting,
            ref string? exclude,
            ref string? search,
            ref global::System.DateTime? fromTime,
            ref global::System.DateTime? toTime);
        partial void PrepareGetTracesByProjectRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? size,
            string? projectName,
            global::System.Guid? projectId,
            string? filters,
            bool? truncate,
            bool? stripAttachments,
            string? sorting,
            string? exclude,
            string? search,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime);
        partial void ProcessGetTracesByProjectResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTracesByProjectResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get traces by project_name or project_id<br/>
        /// Get traces by project_name or project_id
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="filters"></param>
        /// <param name="truncate">
        /// Truncate input, output and metadata to slim payloads<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stripAttachments">
        /// If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="exclude"></param>
        /// <param name="search">
        /// Full-text search across trace fields
        /// </param>
        /// <param name="fromTime">
        /// Filter traces created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter traces created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TracePagePublic> GetTracesByProjectAsync(
            int? page = default,
            int? size = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            string? filters = default,
            bool? truncate = default,
            bool? stripAttachments = default,
            string? sorting = default,
            string? exclude = default,
            string? search = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTracesByProjectArguments(
                httpClient: HttpClient,
                page: ref page,
                size: ref size,
                projectName: ref projectName,
                projectId: ref projectId,
                filters: ref filters,
                truncate: ref truncate,
                stripAttachments: ref stripAttachments,
                sorting: ref sorting,
                exclude: ref exclude,
                search: ref search,
                fromTime: ref fromTime,
                toTime: ref toTime);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/traces",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("size", size?.ToString())
                .AddOptionalParameter("project_name", projectName)
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("filters", filters)
                .AddOptionalParameter("truncate", truncate?.ToString().ToLowerInvariant())
                .AddOptionalParameter("strip_attachments", stripAttachments?.ToString().ToLowerInvariant())
                .AddOptionalParameter("sorting", sorting)
                .AddOptionalParameter("exclude", exclude)
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
            PrepareGetTracesByProjectRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                size: size,
                projectName: projectName,
                projectId: projectId,
                filters: filters,
                truncate: truncate,
                stripAttachments: stripAttachments,
                sorting: sorting,
                exclude: exclude,
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
            ProcessGetTracesByProjectResponse(
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
                ProcessGetTracesByProjectResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TracePagePublic.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TracePagePublic.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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