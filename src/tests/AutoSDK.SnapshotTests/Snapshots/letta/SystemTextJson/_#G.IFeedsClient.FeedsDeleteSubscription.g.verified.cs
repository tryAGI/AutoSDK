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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsDeleteSubscriptionResponse> FeedsDeleteSubscriptionAsync(
            string feedId,
            string subscriptionId,

            object request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Subscription<br/>
        /// Remove agent subscription from a feed (by subscription_id)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsDeleteSubscriptionResponse> FeedsDeleteSubscriptionAsync(
            string feedId,
            string subscriptionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}