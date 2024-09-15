//HintName: G.IBitsClient.GetCheermotes.g.cs
#nullable enable

namespace G
{
    public partial interface IBitsClient
    {
        /// <summary>
        /// Gets a list of Cheermotes that users can use to cheer Bits.<br/>
        /// Gets a list of Cheermotes that users can use to cheer Bits in any Bits-enabled channel’s chat room. Cheermotes are animated emotes that viewers can assign Bits to.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCheermotesResponse> GetCheermotesAsync(
            string? broadcasterId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}