//HintName: G.IModerationClient.AddBlockedTerm.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Adds a word or phrase to the broadcaster’s list of blocked terms.<br/>
        /// Adds a word or phrase to the broadcaster’s list of blocked terms. These are the terms that the broadcaster doesn’t want used in their chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:blocked\_terms** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddBlockedTermResponse> AddBlockedTermAsync(
            string broadcasterId,
            string moderatorId,
            global::G.AddBlockedTermBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds a word or phrase to the broadcaster’s list of blocked terms.<br/>
        /// Adds a word or phrase to the broadcaster’s list of blocked terms. These are the terms that the broadcaster doesn’t want used in their chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:blocked\_terms** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="text">
        /// The word or phrase to block from being used in the broadcaster’s chat room. The term must contain a minimum of 2 characters and may contain up to a maximum of 500 characters.  <br/>
        ///   <br/>
        /// Terms may include a wildcard character (\*). The wildcard character must appear at the beginning or end of a word or set of characters. For example, \*foo or foo\*.  <br/>
        ///   <br/>
        /// If the blocked term already exists, the response contains the existing blocked term.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddBlockedTermResponse> AddBlockedTermAsync(
            string broadcasterId,
            string moderatorId,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}