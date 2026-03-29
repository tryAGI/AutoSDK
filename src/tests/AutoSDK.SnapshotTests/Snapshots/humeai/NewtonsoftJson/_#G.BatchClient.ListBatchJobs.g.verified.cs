//HintName: G.BatchClient.ListBatchJobs.g.cs

#nullable enable

namespace G
{
    public partial class BatchClient
    {
        partial void PrepareListBatchJobsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref global::G.ListBatchJobsStatus? status,
            ref long? when,
            ref long? timestampMs,
            ref global::G.ListBatchJobsSortBy? sortBy,
            ref global::G.ListBatchJobsDirection? direction);
        partial void PrepareListBatchJobsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            global::G.ListBatchJobsStatus? status,
            long? when,
            long? timestampMs,
            global::G.ListBatchJobsSortBy? sortBy,
            global::G.ListBatchJobsDirection? direction);
        partial void ProcessListBatchJobsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListBatchJobsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List batch jobs<br/>
        /// List all batch inference jobs
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="status"></param>
        /// <param name="when"></param>
        /// <param name="timestampMs"></param>
        /// <param name="sortBy"></param>
        /// <param name="direction"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.InferenceJob>> ListBatchJobsAsync(
            int? limit = default,
            global::G.ListBatchJobsStatus? status = default,
            long? when = default,
            long? timestampMs = default,
            global::G.ListBatchJobsSortBy? sortBy = default,
            global::G.ListBatchJobsDirection? direction = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListBatchJobsArguments(
                httpClient: HttpClient,
                limit: ref limit,
                status: ref status,
                when: ref when,
                timestampMs: ref timestampMs,
                sortBy: ref sortBy,
                direction: ref direction);

            var statusValue = status switch
            {
                global::G.ListBatchJobsStatus.Queued => "QUEUED",
                global::G.ListBatchJobsStatus.InProgress => "IN_PROGRESS",
                global::G.ListBatchJobsStatus.Completed => "COMPLETED",
                global::G.ListBatchJobsStatus.Failed => "FAILED",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortByValue = sortBy switch
            {
                global::G.ListBatchJobsSortBy.Created => "created",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.ListBatchJobsDirection.Asc => "asc",
                global::G.ListBatchJobsDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v0/batch/jobs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("status", status?.ToValueString())
                .AddOptionalParameter("when", when?.ToString())
                .AddOptionalParameter("timestamp_ms", timestampMs?.ToString())
                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                .AddOptionalParameter("direction", direction?.ToValueString()) 
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
            PrepareListBatchJobsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                limit: limit,
                status: status,
                when: when,
                timestampMs: timestampMs,
                sortBy: sortBy,
                direction: direction);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListBatchJobsResponse(
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
                ProcessListBatchJobsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.InferenceJob>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.InferenceJob>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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