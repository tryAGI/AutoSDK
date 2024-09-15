//HintName: G.IGamesClient.GetGames.g.cs
#nullable enable

namespace G
{
    public partial interface IGamesClient
    {
        /// <summary>
        /// Gets information about specified games.<br/>
        /// Gets information about specified categories or games.<br/>
        /// You may get up to 100 categories or games by specifying their ID or name. You may specify all IDs, all names, or a combination of IDs and names. If you specify a combination of IDs and names, the total number of IDs and names must not exceed 100.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="igdbId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetGamesResponse> GetGamesAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.Collections.Generic.IList<string>? name = default,
            global::System.Collections.Generic.IList<string>? igdbId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}