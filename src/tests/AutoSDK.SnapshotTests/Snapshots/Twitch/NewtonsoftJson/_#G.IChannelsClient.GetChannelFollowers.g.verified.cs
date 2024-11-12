//HintName: G.IChannelsClient.GetChannelFollowers.g.cs
#nullable enable

namespace G
{
    public partial interface IChannelsClient
    {
        /// <summary>
        /// Gets a list of users that follow the specified broadcaster. You can also use this endpoint to see whether a specific user follows the broadcaster.<br/>
        /// Gets a list of users that follow the specified broadcaster. You can also use this endpoint to see whether a specific user follows the broadcaster.<br/>
        /// __Authorization:__<br/>
        /// * Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:read:followers** scope.<br/>
        /// * The ID in the broadcaster\_id query parameter must match the user ID in the access token or the user ID in the access token must be a moderator for the specified broadcaster.<br/>
        /// This endpoint will return specific follower information only if both of the above are true. If a scope is not provided or the user isn’t the broadcaster or a moderator for the specified channel, only the total follower count will be included in the response.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetChannelFollowersResponse> GetChannelFollowersAsync(
            string broadcasterId,
            string? userId = default,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}