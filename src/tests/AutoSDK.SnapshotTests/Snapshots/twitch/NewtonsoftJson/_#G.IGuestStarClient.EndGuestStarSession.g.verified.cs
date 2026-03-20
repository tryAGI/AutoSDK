//HintName: G.IGuestStarClient.EndGuestStarSession.g.cs
#nullable enable

namespace G
{
    public partial interface IGuestStarClient
    {
        /// <summary>
        /// BETA Programmatically ends a Guest Star session on behalf of the broadcaster.<br/>
        /// BETA Programmatically ends a Guest Star session on behalf of the broadcaster. Performs the same action as if the host clicked the “End Call” button in the Guest Star UI.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task EndGuestStarSessionAsync(
            string broadcasterId,
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}