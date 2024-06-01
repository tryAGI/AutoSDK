//HintName: G.BitsClient.GetBitsLeaderboard.g.cs

#nullable enable

namespace G
{
    public partial class BitsClient
    {
        /// <summary>
        /// Gets the Bits leaderboard for the authenticated broadcaster.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="period"></param>
        /// <param name="startedAt"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetBitsLeaderboardResponse> GetBitsLeaderboardAsync(
            int count,
            GetBitsLeaderboardPeriod period,
            global::System.DateTime startedAt,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var periodValue = period switch
            {
                GetBitsLeaderboardPeriod.Day => "day",
                GetBitsLeaderboardPeriod.Week => "week",
                GetBitsLeaderboardPeriod.Month => "month",
                GetBitsLeaderboardPeriod.Year => "year",
                GetBitsLeaderboardPeriod.All => "all",
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetBitsLeaderboardResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}