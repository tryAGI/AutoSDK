//HintName: G.IBitsClient.GetBitsLeaderboard.g.cs
#nullable enable

namespace G
{
    public partial interface IBitsClient
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
        global::System.Threading.Tasks.Task<global::G.GetBitsLeaderboardResponse> GetBitsLeaderboardAsync(
            int? count = default,
            global::G.GetBitsLeaderboardPeriod? period = default,
            global::System.DateTime? startedAt = default,
            string? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}