//HintName: G.IModerationClient.RemoveChannelModerator.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Removes a moderator from the broadcaster’s chat room.<br/>
        /// Removes a moderator from the broadcaster’s chat room.<br/>
        /// **Rate Limits**: The broadcaster may remove a maximum of 10 moderators within a 10-second window.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:moderators** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveChannelModeratorAsync(
            string broadcasterId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}