//HintName: G.GuestStarClient.DeleteGuestStarSlot.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        /// <summary>
        /// BETA Allows a caller to remove a slot assignment from a user participating in an active Guest Star session.<br/>
        /// BETA Allows a caller to remove a slot assignment from a user participating in an active Guest Star session. This revokes their access to the session immediately and disables their access to publish or subscribe to media within the session.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="guestId"></param>
        /// <param name="slotId"></param>
        /// <param name="shouldReinviteGuest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DeleteGuestStarSlotAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string guestId,
            string slotId,
            string shouldReinviteGuest,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/guest_star/slot?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&session_id={sessionId}&guest_id={guestId}&slot_id={slotId}&should_reinvite_guest={shouldReinviteGuest}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}