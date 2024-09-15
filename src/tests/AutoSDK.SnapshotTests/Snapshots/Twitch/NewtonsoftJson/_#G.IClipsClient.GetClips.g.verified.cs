//HintName: G.IClipsClient.GetClips.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsClient
    {
        /// <summary>
        /// Gets one or more video clips.<br/>
        /// Gets one or more video clips that were captured from streams. For information about clips, see [How to use clips](https://help.twitch.tv/s/article/how-to-use-clips).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).<br/>
        /// __Request Query Parameters:__<br/>
        /// The _id_, _game\_id_, and _broadcaster\_id_ query parameters are mutually exclusive.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="gameId"></param>
        /// <param name="id"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="first"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="isFeatured"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetClipsResponse> GetClipsAsync(
            string? broadcasterId = default,
            string? gameId = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.DateTime startedAt = default,
            global::System.DateTime endedAt = default,
            int first = default,
            string? before = default,
            string? after = default,
            bool isFeatured = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}