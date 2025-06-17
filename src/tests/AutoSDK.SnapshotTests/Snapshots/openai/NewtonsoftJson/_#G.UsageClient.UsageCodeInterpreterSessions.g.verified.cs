//HintName: G.UsageClient.UsageCodeInterpreterSessions.g.cs

#nullable enable

namespace G
{
    public partial class UsageClient
    {
        partial void PrepareUsageCodeInterpreterSessionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int startTime,
            ref int? endTime,
            ref global::G.UsageCodeInterpreterSessionsBucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::G.UsageCodeInterpreterSessionsGroupByItem>? groupBy,
            ref int? limit,
            ref string? page);
        partial void PrepareUsageCodeInterpreterSessionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int startTime,
            int? endTime,
            global::G.UsageCodeInterpreterSessionsBucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::G.UsageCodeInterpreterSessionsGroupByItem>? groupBy,
            int? limit,
            string? page);
        partial void ProcessUsageCodeInterpreterSessionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsageCodeInterpreterSessionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get code interpreter sessions usage details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UsageResponse> UsageCodeInterpreterSessionsAsync(
            int startTime,
            int? endTime = default,
            global::G.UsageCodeInterpreterSessionsBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::G.UsageCodeInterpreterSessionsGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUsageCodeInterpreterSessionsArguments(
                httpClient: HttpClient,
                startTime: ref startTime,
                endTime: ref endTime,
                bucketWidth: ref bucketWidth,
                projectIds: projectIds,
                groupBy: groupBy,
                limit: ref limit,
                page: ref page);

            var bucketWidthValue = bucketWidth switch
            {
                global::G.UsageCodeInterpreterSessionsBucketWidth.x1m => "1m",
                global::G.UsageCodeInterpreterSessionsBucketWidth.x1h => "1h",
                global::G.UsageCodeInterpreterSessionsBucketWidth.x1d => "1d",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/organization/usage/code_interpreter_sessions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("start_time", startTime.ToString()) 
                .AddOptionalParameter("end_time", endTime?.ToString()) 
                .AddOptionalParameter("bucket_width", bucketWidth?.ToValueString()) 
                .AddOptionalParameter("project_ids", projectIds, delimiter: ",", explode: true) 
                .AddOptionalParameter("group_by", groupBy, selector: static x => x.ToValueString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("page", page) 
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
            PrepareUsageCodeInterpreterSessionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                startTime: startTime,
                endTime: endTime,
                bucketWidth: bucketWidth,
                projectIds: projectIds,
                groupBy: groupBy,
                limit: limit,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUsageCodeInterpreterSessionsResponse(
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
                ProcessUsageCodeInterpreterSessionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.UsageResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.UsageResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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