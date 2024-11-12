//HintName: G.IModerationClient.DeleteChatMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Removes a single chat message or all chat messages from the broadcaster’s chat room.<br/>
        /// Removes a single chat message or all chat messages from the broadcaster’s chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:chat\_messages** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteChatMessagesAsync(
            string broadcasterId,
            string moderatorId,
            string? messageId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}