//HintName: G.CallsClient.ListCalls.g.cs

#nullable enable

namespace G
{
    public partial class CallsClient
    {
        partial void PrepareListCallsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? fromNumber,
            ref string? toNumber,
            ref int? from,
            ref int? to,
            ref int? limit,
            ref bool? ascending,
            ref global::G.ListCallsSortBy? sortBy,
            ref string? startDate,
            ref string? endDate,
            ref bool? completed,
            ref string? batchId,
            ref string? answeredBy,
            ref bool? inbound,
            ref string? campaignId);
        partial void PrepareListCallsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? fromNumber,
            string? toNumber,
            int? from,
            int? to,
            int? limit,
            bool? ascending,
            global::G.ListCallsSortBy? sortBy,
            string? startDate,
            string? endDate,
            bool? completed,
            string? batchId,
            string? answeredBy,
            bool? inbound,
            string? campaignId);
        partial void ProcessListCallsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListCallsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Calls<br/>
        /// Returns metadata for calls dispatched by your account.
        /// </summary>
        /// <param name="fromNumber"></param>
        /// <param name="toNumber"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="ascending">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="completed"></param>
        /// <param name="batchId"></param>
        /// <param name="answeredBy"></param>
        /// <param name="inbound"></param>
        /// <param name="campaignId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListCallsResponse> ListCallsAsync(
            string? fromNumber = default,
            string? toNumber = default,
            int? from = default,
            int? to = default,
            int? limit = default,
            bool? ascending = default,
            global::G.ListCallsSortBy? sortBy = default,
            string? startDate = default,
            string? endDate = default,
            bool? completed = default,
            string? batchId = default,
            string? answeredBy = default,
            bool? inbound = default,
            string? campaignId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListCallsArguments(
                httpClient: HttpClient,
                fromNumber: ref fromNumber,
                toNumber: ref toNumber,
                from: ref from,
                to: ref to,
                limit: ref limit,
                ascending: ref ascending,
                sortBy: ref sortBy,
                startDate: ref startDate,
                endDate: ref endDate,
                completed: ref completed,
                batchId: ref batchId,
                answeredBy: ref answeredBy,
                inbound: ref inbound,
                campaignId: ref campaignId);

            var sortByValue = sortBy switch
            {
                global::G.ListCallsSortBy.CreatedAt => "created_at",
                global::G.ListCallsSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/calls",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("from_number", fromNumber)
                .AddOptionalParameter("to_number", toNumber)
                .AddOptionalParameter("from", from?.ToString())
                .AddOptionalParameter("to", to?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("ascending", ascending?.ToString().ToLowerInvariant())
                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                .AddOptionalParameter("start_date", startDate)
                .AddOptionalParameter("end_date", endDate)
                .AddOptionalParameter("completed", completed?.ToString().ToLowerInvariant())
                .AddOptionalParameter("batch_id", batchId)
                .AddOptionalParameter("answered_by", answeredBy)
                .AddOptionalParameter("inbound", inbound?.ToString().ToLowerInvariant())
                .AddOptionalParameter("campaign_id", campaignId) 
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
            PrepareListCallsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fromNumber: fromNumber,
                toNumber: toNumber,
                from: from,
                to: to,
                limit: limit,
                ascending: ascending,
                sortBy: sortBy,
                startDate: startDate,
                endDate: endDate,
                completed: completed,
                batchId: batchId,
                answeredBy: answeredBy,
                inbound: inbound,
                campaignId: campaignId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListCallsResponse(
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
                ProcessListCallsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListCallsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListCallsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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