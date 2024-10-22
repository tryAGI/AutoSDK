//HintName: G.AnalyticsClient.GetGameAnalytics.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {
        partial void PrepareGetGameAnalyticsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? gameId,
            ref global::G.GetGameAnalyticsType? type,
            ref global::System.DateTime? startedAt,
            ref global::System.DateTime? endedAt,
            ref int? first,
            ref string? after);
        partial void PrepareGetGameAnalyticsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? gameId,
            global::G.GetGameAnalyticsType? type,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            int? first,
            string? after);
        partial void ProcessGetGameAnalyticsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetGameAnalyticsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets an analytics report for one or more games.<br/>
        /// Gets an analytics report for one or more games. The response contains the URLs used to download the reports (CSV files). [Learn more](https://dev.twitch.tv/docs/insights)<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **analytics:read:games** scope.
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="type"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetGameAnalyticsResponse> GetGameAnalyticsAsync(
            string? gameId = default,
            global::G.GetGameAnalyticsType? type = default,
            global::System.DateTime? startedAt = default,
            global::System.DateTime? endedAt = default,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetGameAnalyticsArguments(
                httpClient: HttpClient,
                gameId: ref gameId,
                type: ref type,
                startedAt: ref startedAt,
                endedAt: ref endedAt,
                first: ref first,
                after: ref after);

            var typeValue = type switch
            {
                global::G.GetGameAnalyticsType.OverviewV2 => "overview_v2",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/analytics/games",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("game_id", gameId) 
                .AddOptionalParameter("type", typeValue?.ToString()) 
                .AddOptionalParameter("started_at", startedAt?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("ended_at", endedAt?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("first", first?.ToString()) 
                .AddOptionalParameter("after", after) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareGetGameAnalyticsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                gameId: gameId,
                type: type,
                startedAt: startedAt,
                endedAt: endedAt,
                first: first,
                after: after);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetGameAnalyticsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetGameAnalyticsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.GetGameAnalyticsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}