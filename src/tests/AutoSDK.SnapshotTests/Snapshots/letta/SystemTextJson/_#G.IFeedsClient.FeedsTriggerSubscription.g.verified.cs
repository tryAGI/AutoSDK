//HintName: G.IFeedsClient.FeedsTriggerSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Trigger Subscription<br/>
        /// Immediately trigger a subscription to process pending messages
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsTriggerSubscriptionResponse> FeedsTriggerSubscriptionAsync(
            string feedId,
            string subscriptionId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Subscription<br/>
        /// Immediately trigger a subscription to process pending messages
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsTriggerSubscriptionResponse> FeedsTriggerSubscriptionAsync(
            string feedId,
            string subscriptionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}