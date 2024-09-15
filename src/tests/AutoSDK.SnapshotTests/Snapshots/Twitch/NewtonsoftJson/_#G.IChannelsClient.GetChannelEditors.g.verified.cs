//HintName: G.IChannelsClient.GetChannelEditors.g.cs
#nullable enable

namespace G
{
    public partial interface IChannelsClient
    {
        /// <summary>
        /// Gets the broadcaster’s list editors.<br/>
        /// Gets the broadcaster’s list editors.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:editors** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetChannelEditorsResponse> GetChannelEditorsAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}