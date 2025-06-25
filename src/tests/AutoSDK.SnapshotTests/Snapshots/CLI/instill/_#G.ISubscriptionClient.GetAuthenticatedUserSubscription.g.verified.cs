﻿//HintName: G.ISubscriptionClient.GetAuthenticatedUserSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface ISubscriptionClient
    {
        /// <summary>
        /// Get the subscription of the authenticated user<br/>
        /// Returns the subscription details of the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAuthenticatedUserSubscriptionResponse> GetAuthenticatedUserSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}