//HintName: G.IConduitsClient.GetConduits.g.cs
#nullable enable

namespace G
{
    public partial interface IConduitsClient
    {
        /// <summary>
        /// NEW  Gets the conduits for a client ID.<br/>
        /// NEW Gets the [conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) for a client ID.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConduitsResponse> GetConduitsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}