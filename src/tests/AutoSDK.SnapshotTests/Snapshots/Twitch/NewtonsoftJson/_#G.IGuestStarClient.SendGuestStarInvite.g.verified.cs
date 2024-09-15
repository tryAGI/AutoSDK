//HintName: G.IGuestStarClient.SendGuestStarInvite.g.cs
#nullable enable

namespace G
{
    public partial interface IGuestStarClient
    {
        /// <summary>
        /// BETA Sends an invite to a specified guest on behalf of the broadcaster for a Guest Star session in progress.<br/>
        /// BETA Sends an invite to a specified guest on behalf of the broadcaster for a Guest Star session in progress.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="guestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SendGuestStarInviteAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string guestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}