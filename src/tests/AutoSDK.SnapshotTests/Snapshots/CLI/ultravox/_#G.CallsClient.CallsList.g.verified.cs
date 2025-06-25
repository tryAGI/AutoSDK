//HintName: G.CallsClient.CallsList.g.cs

#nullable enable

namespace G
{
    public partial class CallsClient
    {
        partial void PrepareCallsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? cursor,
            ref string? durationMax,
            ref string? durationMin,
            ref global::System.DateTime? fromDate,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            ref int? pageSize,
            ref string? search,
            ref string? sort,
            ref global::System.DateTime? toDate,
            ref global::System.Guid? voiceId);
        partial void PrepareCallsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? cursor,
            string? durationMax,
            string? durationMin,
            global::System.DateTime? fromDate,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            int? pageSize,
            string? search,
            string? sort,
            global::System.DateTime? toDate,
            global::System.Guid? voiceId);
        partial void ProcessCallsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCallsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="durationMax"></param>
        /// <param name="durationMin"></param>
        /// <param name="fromDate"></param>
        /// <param name="metadata"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="toDate"></param>
        /// <param name="voiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedCallList> CallsListAsync(
            string? cursor = default,
            string? durationMax = default,
            string? durationMin = default,
            global::System.DateTime? fromDate = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            global::System.DateTime? toDate = default,
            global::System.Guid? voiceId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCallsListArguments(
                httpClient: HttpClient,
                cursor: ref cursor,
                durationMax: ref durationMax,
                durationMin: ref durationMin,
                fromDate: ref fromDate,
                metadata: metadata,
                pageSize: ref pageSize,
                search: ref search,
                sort: ref sort,
                toDate: ref toDate,
                voiceId: ref voiceId);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/calls",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("cursor", cursor) 
                .AddOptionalParameter("durationMax", durationMax) 
                .AddOptionalParameter("durationMin", durationMin) 
                .AddOptionalParameter("fromDate", fromDate?.ToString("yyyy-MM-dd")) 
                .AddOptionalParameter("metadata", metadata?.ToString()) 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("sort", sort) 
                .AddOptionalParameter("toDate", toDate?.ToString("yyyy-MM-dd")) 
                .AddOptionalParameter("voiceId", voiceId?.ToString()) 
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
            PrepareCallsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cursor: cursor,
                durationMax: durationMax,
                durationMin: durationMin,
                fromDate: fromDate,
                metadata: metadata,
                pageSize: pageSize,
                search: search,
                sort: sort,
                toDate: toDate,
                voiceId: voiceId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCallsListResponse(
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
                ProcessCallsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PaginatedCallList.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PaginatedCallList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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