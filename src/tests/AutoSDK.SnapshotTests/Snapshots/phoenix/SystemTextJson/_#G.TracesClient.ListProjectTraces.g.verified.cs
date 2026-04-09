//HintName: G.TracesClient.ListProjectTraces.g.cs

#nullable enable

namespace G
{
    public partial class TracesClient
    {
        partial void PrepareListProjectTracesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectIdentifier,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            ref global::G.ListProjectTracesSort? sort,
            ref global::G.ListProjectTracesOrder? order,
            ref int? limit,
            ref string? cursor,
            ref bool? includeSpans,
            global::System.Collections.Generic.IList<string>? sessionIdentifier);
        partial void PrepareListProjectTracesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectIdentifier,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::G.ListProjectTracesSort? sort,
            global::G.ListProjectTracesOrder? order,
            int? limit,
            string? cursor,
            bool? includeSpans,
            global::System.Collections.Generic.IList<string>? sessionIdentifier);
        partial void ProcessListProjectTracesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListProjectTracesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List traces for a project
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="startTime">
        /// Inclusive lower bound on trace start time (ISO 8601)
        /// </param>
        /// <param name="endTime">
        /// Exclusive upper bound on trace start time (ISO 8601)
        /// </param>
        /// <param name="sort">
        /// Sort field<br/>
        /// Default Value: start_time
        /// </param>
        /// <param name="order">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit">
        /// Maximum number of traces to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor (Trace GlobalID)
        /// </param>
        /// <param name="includeSpans">
        /// If true, include full span details for each trace. This significantly increases response size and query latency, especially with large page sizes. Prefer fetching spans lazily for individual traces when possible.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sessionIdentifier">
        /// List of session identifiers to filter traces by. Each value can be either a session_id string or a session GlobalID. Only traces belonging to the specified sessions will be returned.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetTracesResponseBody> ListProjectTracesAsync(
            string projectIdentifier,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::G.ListProjectTracesSort? sort = default,
            global::G.ListProjectTracesOrder? order = default,
            int? limit = default,
            string? cursor = default,
            bool? includeSpans = default,
            global::System.Collections.Generic.IList<string>? sessionIdentifier = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListProjectTracesArguments(
                httpClient: HttpClient,
                projectIdentifier: ref projectIdentifier,
                startTime: startTime,
                endTime: endTime,
                sort: ref sort,
                order: ref order,
                limit: ref limit,
                cursor: ref cursor,
                includeSpans: ref includeSpans,
                sessionIdentifier: sessionIdentifier);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/projects/{projectIdentifier}/traces",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("start_time", startTime?.ToString())
                .AddOptionalParameter("end_time", endTime?.ToString())
                .AddOptionalParameter("sort", sort?.ToValueString())
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("include_spans", includeSpans?.ToString().ToLowerInvariant())
                .AddOptionalParameter("session_identifier", sessionIdentifier?.ToString()) 
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
            PrepareListProjectTracesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectIdentifier: projectIdentifier,
                startTime: startTime,
                endTime: endTime,
                sort: sort,
                order: order,
                limit: limit,
                cursor: cursor,
                includeSpans: includeSpans,
                sessionIdentifier: sessionIdentifier);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListProjectTracesResponse(
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
                ProcessListProjectTracesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetTracesResponseBody.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetTracesResponseBody.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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