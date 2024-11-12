//HintName: G.IGamesClient.GetTopGames.g.cs
#nullable enable

namespace G
{
    public partial interface IGamesClient
    {
        /// <summary>
        /// Gets information about all broadcasts on Twitch.<br/>
        /// Gets information about all broadcasts on Twitch.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTopGamesResponse> GetTopGamesAsync(
            int? first = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}