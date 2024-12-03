//HintName: G.IVideosClient.GetVideos.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Gets information about one or more published videos.<br/>
        /// Gets information about one or more published videos. You may get videos by ID, by user, or by game/category.<br/>
        /// You may apply several filters to get a subset of the videos. The filters are applied as an AND operation to each video. For example, if _language_ is set to ‘de’ and _game\_id_ is set to 21779, the response includes only videos that show playing League of Legends by users that stream in German. The filters apply only if you get videos by user ID or game ID.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="gameId"></param>
        /// <param name="language"></param>
        /// <param name="period"></param>
        /// <param name="sort"></param>
        /// <param name="type"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetVideosResponse> GetVideosAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? userId = default,
            string? gameId = default,
            string? language = default,
            global::G.GetVideosPeriod? period = default,
            global::G.GetVideosSort? sort = default,
            global::G.GetVideosType? type = default,
            string? first = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}