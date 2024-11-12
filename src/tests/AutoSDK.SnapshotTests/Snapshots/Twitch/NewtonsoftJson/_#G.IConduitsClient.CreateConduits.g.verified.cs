//HintName: G.IConduitsClient.CreateConduits.g.cs
#nullable enable

namespace G
{
    public partial interface IConduitsClient
    {
        /// <summary>
        /// NEW Creates a new conduit.<br/>
        /// NEW Creates a new [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateConduitsResponse> CreateConduitsAsync(
            global::G.CreateConduitsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// NEW Creates a new conduit.<br/>
        /// NEW Creates a new [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="shardCount">
        /// The number of shards to create for this conduit.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateConduitsResponse> CreateConduitsAsync(
            int shardCount,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}