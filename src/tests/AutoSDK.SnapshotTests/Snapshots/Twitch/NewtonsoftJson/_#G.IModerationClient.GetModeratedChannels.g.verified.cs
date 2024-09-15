//HintName: G.IModerationClient.GetModeratedChannels.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Gets a list of channels that the specified user has moderator privileges in.<br/>
        /// Gets a list of channels that the specified user has moderator privileges in.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `user_id` must match the user ID in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `user:read:moderated_channels`
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetModeratedChannelsResponse> GetModeratedChannelsAsync(
            string userId,
            string? after = default,
            int first = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}