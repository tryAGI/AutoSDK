//HintName: G.IChatClient.GetUserChatColor.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Gets the color used for the user’s name in chat.<br/>
        /// Gets the color used for the user’s name in chat.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserChatColorResponse> GetUserChatColorAsync(
            global::System.Collections.Generic.IList<string> userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}