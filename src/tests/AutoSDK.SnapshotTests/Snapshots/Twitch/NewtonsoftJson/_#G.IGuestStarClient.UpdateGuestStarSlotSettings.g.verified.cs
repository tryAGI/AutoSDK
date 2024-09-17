//HintName: G.IGuestStarClient.UpdateGuestStarSlotSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IGuestStarClient
    {
        /// <summary>
        /// BETA Allows a user to update slot settings for a particular guest within a Guest Star session.<br/>
        /// BETA Allows a user to update slot settings for a particular guest within a Guest Star session, such as allowing the user to share audio or video within the call as a host. These settings will be broadcasted to all subscribers which control their view of the guest in that slot. One or more of the optional parameters to this API can be specified at any time.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="slotId"></param>
        /// <param name="isAudioEnabled"></param>
        /// <param name="isVideoEnabled"></param>
        /// <param name="isLive"></param>
        /// <param name="volume"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateGuestStarSlotSettingsAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string slotId,
            bool? isAudioEnabled = default,
            bool? isVideoEnabled = default,
            bool? isLive = default,
            int? volume = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}