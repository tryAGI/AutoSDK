//HintName: G.IPollsClient.GetPolls.g.cs
#nullable enable

namespace G
{
    public partial interface IPollsClient
    {
        /// <summary>
        /// Gets a list of polls that the broadcaster created.<br/>
        /// Gets a list of polls that the broadcaster created.<br/>
        /// Polls are available for 90 days after they’re created.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:polls** or **channel:manage:polls** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPollsResponse> GetPollsAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id = default,
            string? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}