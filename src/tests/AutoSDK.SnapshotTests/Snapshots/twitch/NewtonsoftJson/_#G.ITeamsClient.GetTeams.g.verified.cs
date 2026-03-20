//HintName: G.ITeamsClient.GetTeams.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Gets information about the specified Twitch team.<br/>
        /// Gets information about the specified Twitch team. [Read More](https://help.twitch.tv/s/article/twitch-teams)<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTeamsResponse> GetTeamsAsync(
            string? name = default,
            string? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}