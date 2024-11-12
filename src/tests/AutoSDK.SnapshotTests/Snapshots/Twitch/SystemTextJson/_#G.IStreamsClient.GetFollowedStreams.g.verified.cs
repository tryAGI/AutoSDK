//HintName: G.IStreamsClient.GetFollowedStreams.g.cs
#nullable enable

namespace G
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Gets the list of broadcasters that the user follows and that are streaming live.<br/>
        /// Gets the list of broadcasters that the user follows and that are streaming live.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:follows** scope.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetFollowedStreamsResponse> GetFollowedStreamsAsync(
            string userId,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}