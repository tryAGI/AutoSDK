//HintName: G.IStreamsClient.GetStreams.g.cs
#nullable enable

namespace G
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Gets a list of all streams.<br/>
        /// Gets a list of all streams. The list is in descending order by the number of viewers watching the stream. Because viewers come and go during a stream, it’s possible to find duplicate or missing streams in the list as you page through the results.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userLogin"></param>
        /// <param name="gameId"></param>
        /// <param name="type"></param>
        /// <param name="language"></param>
        /// <param name="first"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetStreamsResponse> GetStreamsAsync(
            global::System.Collections.Generic.IList<string>? userId = default,
            global::System.Collections.Generic.IList<string>? userLogin = default,
            global::System.Collections.Generic.IList<string>? gameId = default,
            global::G.GetStreamsType? type = default,
            global::System.Collections.Generic.IList<string>? language = default,
            int first = default,
            string? before = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}