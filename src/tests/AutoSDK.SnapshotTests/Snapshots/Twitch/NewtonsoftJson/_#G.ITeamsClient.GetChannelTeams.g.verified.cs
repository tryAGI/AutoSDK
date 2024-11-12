//HintName: G.ITeamsClient.GetChannelTeams.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Gets the list of Twitch teams that the broadcaster is a member of.<br/>
        /// Gets the list of Twitch teams that the broadcaster is a member of.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetChannelTeamsResponse> GetChannelTeamsAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}