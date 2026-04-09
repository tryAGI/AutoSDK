//HintName: G.IFeedsClient.FeedsUpdateSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Update Subscription<br/>
        /// Update subscription configuration (cron schedule, enable/disable)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsUpdateSubscriptionResponse> FeedsUpdateSubscriptionAsync(
            string feedId,
            string subscriptionId,

            global::G.FeedsUpdateSubscriptionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Subscription<br/>
        /// Update subscription configuration (cron schedule, enable/disable)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="disabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsUpdateSubscriptionResponse> FeedsUpdateSubscriptionAsync(
            string feedId,
            string subscriptionId,
            string? cronSchedule = default,
            string? promptTemplate = default,
            bool? disabled = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}