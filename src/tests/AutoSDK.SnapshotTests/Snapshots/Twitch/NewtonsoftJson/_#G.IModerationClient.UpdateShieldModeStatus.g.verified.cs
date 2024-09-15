//HintName: G.IModerationClient.UpdateShieldModeStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
        /// <summary>
        /// Activates or deactivates the broadcaster’s Shield Mode.<br/>
        /// Activates or deactivates the broadcaster’s Shield Mode.<br/>
        /// Twitch’s Shield Mode feature is like a panic button that broadcasters can push to protect themselves from chat abuse coming from one or more accounts. When activated, Shield Mode applies the overrides that the broadcaster configured in the Twitch UX. If the broadcaster hasn’t configured Shield Mode, it applies default overrides.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:shield\_mode** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateShieldModeStatusResponse> UpdateShieldModeStatusAsync(
            string broadcasterId,
            string moderatorId,
            global::G.UpdateShieldModeStatusBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Activates or deactivates the broadcaster’s Shield Mode.<br/>
        /// Activates or deactivates the broadcaster’s Shield Mode.<br/>
        /// Twitch’s Shield Mode feature is like a panic button that broadcasters can push to protect themselves from chat abuse coming from one or more accounts. When activated, Shield Mode applies the overrides that the broadcaster configured in the Twitch UX. If the broadcaster hasn’t configured Shield Mode, it applies default overrides.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:shield\_mode** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="isActive">
        /// A Boolean value that determines whether to activate Shield Mode. Set to **true** to activate Shield Mode; otherwise, **false** to deactivate Shield Mode.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateShieldModeStatusResponse> UpdateShieldModeStatusAsync(
            string broadcasterId,
            string moderatorId,
            bool isActive,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}