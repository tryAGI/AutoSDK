//HintName: G.IModerationClient.RemoveBlockedTerm.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Removes the word or phrase from the broadcaster’s list of blocked terms.<br/>
        /// Removes the word or phrase from the broadcaster’s list of blocked terms.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:blocked\_terms** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RemoveBlockedTermAsync(
            string broadcasterId,
            string moderatorId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}