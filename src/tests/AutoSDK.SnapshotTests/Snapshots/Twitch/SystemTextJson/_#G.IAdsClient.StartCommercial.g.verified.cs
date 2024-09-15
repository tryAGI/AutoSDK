//HintName: G.IAdsClient.StartCommercial.g.cs
#nullable enable

namespace G
{
    public partial interface IAdsClient
    {
        /// <summary>
        /// Starts a commercial on the specified channel.<br/>
        /// Starts a commercial on the specified channel.<br/>
        /// **NOTE**: Only partners and affiliates may run commercials and they must be streaming live at the time.<br/>
        /// **NOTE**: Only the broadcaster may start a commercial; the broadcaster’s editors and moderators may not start commercials on behalf of the broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:edit:commercial** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartCommercialResponse> StartCommercialAsync(
            global::G.StartCommercialBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts a commercial on the specified channel.<br/>
        /// Starts a commercial on the specified channel.<br/>
        /// **NOTE**: Only partners and affiliates may run commercials and they must be streaming live at the time.<br/>
        /// **NOTE**: Only the broadcaster may start a commercial; the broadcaster’s editors and moderators may not start commercials on behalf of the broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:edit:commercial** scope.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the partner or affiliate broadcaster that wants to run the commercial. This ID must match the user ID found in the OAuth token.
        /// </param>
        /// <param name="length">
        /// The length of the commercial to run, in seconds. Twitch tries to serve a commercial that’s the requested length, but it may be shorter or longer. The maximum length you should request is 180 seconds.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartCommercialResponse> StartCommercialAsync(
            string broadcasterId,
            int length,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}