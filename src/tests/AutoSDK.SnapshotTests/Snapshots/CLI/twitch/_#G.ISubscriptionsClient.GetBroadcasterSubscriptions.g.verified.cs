﻿//HintName: G.ISubscriptionsClient.GetBroadcasterSubscriptions.g.cs
#nullable enable

namespace G
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// Gets a list of users that subscribe to the specified broadcaster.<br/>
        /// Gets a list of users that subscribe to the specified broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:subscriptions** scope.<br/>
        /// A Twitch extensions may use an app access token if the broadcaster has granted the **channel:read:subscriptions** scope from within the Twitch Extensions manager.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetBroadcasterSubscriptionsResponse> GetBroadcasterSubscriptionsAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId = default,
            string? first = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}