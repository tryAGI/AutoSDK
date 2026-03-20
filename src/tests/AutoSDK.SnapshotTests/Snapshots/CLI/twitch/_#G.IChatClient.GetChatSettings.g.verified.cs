//HintName: G.IChatClient.GetChatSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Gets the broadcaster’s chat settings.<br/>
        /// Gets the broadcaster’s chat settings.<br/>
        /// For an overview of chat settings, see [Chat Commands for Broadcasters and Moderators](https://help.twitch.tv/s/article/chat-commands#AllMods) and [Moderator Preferences](https://help.twitch.tv/s/article/setting-up-moderation-for-your-twitch-channel#modpreferences).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetChatSettingsResponse> GetChatSettingsAsync(
            string broadcasterId,
            string? moderatorId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}