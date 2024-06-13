//HintName: G.BitsClient.GetBitsLeaderboard.g.cs

#nullable enable

namespace G
{
    public partial class BitsClient
    {
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
            global::G.GetBitsLeaderboardPeriod period,
            global::System.DateTime startedAt,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
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
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/bits/leaderboard?count={count}&period={periodValue}&started_at={startedAt}&user_id={userId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetBitsLeaderboardResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}