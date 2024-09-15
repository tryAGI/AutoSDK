//HintName: G.IChatClient.GetChatters.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Gets the list of users that are connected to the broadcaster’s chat session.<br/>
        /// Gets the list of users that are connected to the broadcaster’s chat session.<br/>
        /// **NOTE**: There is a delay between when users join and leave a chat and when the list is updated accordingly.<br/>
        /// To determine whether a user is a moderator or VIP, use the [Get Moderators](https://dev.twitch.tv/docs/api/reference#get-moderators) and [Get VIPs](https://dev.twitch.tv/docs/api/reference#get-vips) endpoints. You can check the roles of up to 100 users.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:read:chatters** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetChattersResponse> GetChattersAsync(
            string broadcasterId,
            string moderatorId,
            int first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}