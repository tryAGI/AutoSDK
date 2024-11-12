//HintName: G.IGuestStarClient.UpdateGuestStarSlot.g.cs
#nullable enable

namespace G
{
    public partial interface IGuestStarClient
    {
        /// <summary>
        /// BETA Allows a user to update the assigned slot for a particular user within the active Guest Star session.<br/>
        /// BETA Allows a user to update the assigned slot for a particular user within the active Guest Star session.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="sourceSlotId"></param>
        /// <param name="destinationSlotId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateGuestStarSlotAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string sourceSlotId,
            string? destinationSlotId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}