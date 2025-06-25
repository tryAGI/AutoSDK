//HintName: G.IAdsClient.GetAdSchedule.g.cs
#nullable enable

namespace G
{
    public partial interface IAdsClient
    {
        /// <summary>
        /// Returns ad schedule related information.<br/>
        /// This endpoint returns ad schedule related information, including snooze, when the last ad was run, when the next ad is scheduled, and if the channel is currently in pre-roll free time. Note that a new ad cannot be run until 8 minutes after running a previous ad.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:ads** scope. The `user_id` in the user access token must match the `broadcaster_id`.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAdScheduleResponse> GetAdScheduleAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}