//HintName: G.AnalyticsClient.GetGameAnalytics.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {
        partial void PrepareGetGameAnalyticsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string gameId,
            ref global::G.GetGameAnalyticsType type,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            ref int first,
            ref string after);
        partial void PrepareGetGameAnalyticsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string gameId,
            global::G.GetGameAnalyticsType type,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            int first,
            string after);
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
            string gameId,
            global::G.GetGameAnalyticsType type,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetGameAnalyticsArguments(
                httpClient: _httpClient,
                gameId: ref gameId,
                type: ref type,
                startedAt: startedAt,
                endedAt: endedAt,
                first: ref first,
                after: ref after);

            var typeValue = type switch
            {
                global::G.GetGameAnalyticsType.OverviewV2 => "overview_v2",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/analytics/games?game_id={gameId}&type={typeValue}&started_at={startedAt:yyyy-MM-ddTHH:mm:ssZ}&ended_at={endedAt:yyyy-MM-ddTHH:mm:ssZ}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetGameAnalyticsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                gameId: gameId,
                type: type,
                startedAt: startedAt,
                endedAt: endedAt,
                first: first,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetGameAnalyticsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetGameAnalyticsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetGameAnalyticsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}