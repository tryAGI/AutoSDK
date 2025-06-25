//HintName: G.IManageClient.PostApiSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Update API subscription settings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostApiSubscriptionResponse> PostApiSubscriptionAsync(
            global::G.PostApiSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update API subscription settings
        /// </summary>
        /// <param name="rechargeSettings">
        /// The current recharge settings for the API subscription.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostApiSubscriptionResponse> PostApiSubscriptionAsync(
            global::G.RechargeSettings? rechargeSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}