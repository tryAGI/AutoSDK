//HintName: G.IConduitsClient.GetConduitShards.g.cs
#nullable enable

namespace G
{
    public partial interface IConduitsClient
    {
        /// <summary>
        /// NEW Gets a lists of all shards for a conduit.<br/>
        /// NEW Gets a lists of all shards for a [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="conduitId"></param>
        /// <param name="status"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConduitShardsResponse> GetConduitShardsAsync(
            string conduitId,
            string? status = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}