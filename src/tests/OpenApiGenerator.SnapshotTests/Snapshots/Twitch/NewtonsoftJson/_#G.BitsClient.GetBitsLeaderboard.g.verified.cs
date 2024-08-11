//HintName: G.BitsClient.GetBitsLeaderboard.g.cs

#nullable enable

namespace G
{
    public partial class BitsClient
    {
        partial void PrepareGetBitsLeaderboardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int count,
            ref global::G.GetBitsLeaderboardPeriod? period,
            global::System.DateTime startedAt,
            ref string? userId);
        partial void PrepareGetBitsLeaderboardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int count,
            global::G.GetBitsLeaderboardPeriod? period,
            global::System.DateTime startedAt,
            string? userId);
        partial void ProcessGetBitsLeaderboardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetBitsLeaderboardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the Bits leaderboard for the authenticated broadcaster.<br/>
        /// Gets the Bits leaderboard for the authenticated broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **bits:read** scope.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="period"></param>
        /// <param name="startedAt"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetBitsLeaderboardResponse> GetBitsLeaderboardAsync(
            int count,
            global::G.GetBitsLeaderboardPeriod? period,
            global::System.DateTime startedAt,
            string? userId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetBitsLeaderboardArguments(
                httpClient: _httpClient,
                count: ref count,
                period: ref period,
                startedAt: startedAt,
                userId: ref userId);

            var periodValue = period switch
            {
                global::G.GetBitsLeaderboardPeriod.Day => "day",
                global::G.GetBitsLeaderboardPeriod.Week => "week",
                global::G.GetBitsLeaderboardPeriod.Month => "month",
                global::G.GetBitsLeaderboardPeriod.Year => "year",
                global::G.GetBitsLeaderboardPeriod.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/bits/leaderboard?count={count}&period={periodValue}&started_at={startedAt:yyyy-MM-ddTHH:mm:ssZ}&user_id={userId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetBitsLeaderboardRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                count: count,
                period: period,
                startedAt: startedAt,
                userId: userId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetBitsLeaderboardResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetBitsLeaderboardResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetBitsLeaderboardResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}