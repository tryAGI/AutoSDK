//HintName: G.IFeedsClient.FeedsDeleteSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Delete Subscription<br/>
        /// Remove agent subscription from a feed (by subscription_id)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsDeleteSubscriptionResponse> FeedsDeleteSubscriptionAsync(
            string feedId,
            string subscriptionId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Subscription<br/>
        /// Remove agent subscription from a feed (by subscription_id)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsDeleteSubscriptionResponse> FeedsDeleteSubscriptionAsync(
            string feedId,
            string subscriptionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}