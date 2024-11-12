//HintName: G.IModerationClient.GetAutomodSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Gets the broadcaster’s AutoMod settings.<br/>
        /// Gets the broadcaster’s AutoMod settings. The settings are used to automatically block inappropriate or harassing messages from appearing in the broadcaster’s chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:read:automod\_settings** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAutoModSettingsResponse> GetAutomodSettingsAsync(
            string broadcasterId,
            string moderatorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}