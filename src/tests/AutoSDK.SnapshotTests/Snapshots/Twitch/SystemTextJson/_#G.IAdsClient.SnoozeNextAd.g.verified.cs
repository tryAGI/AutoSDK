//HintName: G.IAdsClient.SnoozeNextAd.g.cs
#nullable enable

namespace G
{
    public partial interface IAdsClient
    {
        /// <summary>
        /// Pushes back the timestamp of the upcoming automatic mid-roll ad by 5 minutes.<br/>
        /// If available, pushes back the timestamp of the upcoming automatic mid-roll ad by 5 minutes. This endpoint duplicates the snooze functionality in the creator dashboard’s Ads Manager.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:ads** scope. The `user_id` in the user access token must match the `broadcaster_id`.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SnoozeNextAdResponse> SnoozeNextAdAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}