//HintName: G.IGuestStarClient.GetChannelGuestStarSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IGuestStarClient
    {
        /// <summary>
        /// BETA Gets the channel settings for configuration of the Guest Star feature for a particular host.<br/>
        /// BETA Gets the channel settings for configuration of the Guest Star feature for a particular host.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:read:guest_star`, `channel:manage:guest_star`, `moderator:read:guest_star` or `moderator:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetChannelGuestStarSettingsResponse> GetChannelGuestStarSettingsAsync(
            string broadcasterId,
            string moderatorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}