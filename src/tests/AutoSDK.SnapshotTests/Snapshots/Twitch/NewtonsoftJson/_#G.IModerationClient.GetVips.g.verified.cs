//HintName: G.IModerationClient.GetVips.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Gets a list of the broadcaster’s VIPs.<br/>
        /// Gets a list of the broadcaster’s VIPs.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:vips** scope. If your app also adds and removes VIP status, you can use the **channel:manage:vips** scope instead.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetVIPsResponse> GetVipsAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId = default,
            int first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}