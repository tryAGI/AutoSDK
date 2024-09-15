//HintName: G.IRaidsClient.CancelARaid.g.cs
#nullable enable

namespace G
{
    public partial interface IRaidsClient
    {
        /// <summary>
        /// Cancel a pending raid.<br/>
        /// Cancel a pending raid.<br/>
        /// You can cancel a raid at any point up until the broadcaster clicks **Raid Now** in the Twitch UX or the 90-second countdown expires.<br/>
        /// **Rate Limit**: The limit is 10 requests within a 10-minute window.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:raids** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CancelARaidAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}