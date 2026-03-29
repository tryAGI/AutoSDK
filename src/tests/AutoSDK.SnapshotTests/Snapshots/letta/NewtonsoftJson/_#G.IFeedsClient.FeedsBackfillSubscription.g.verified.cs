//HintName: G.IFeedsClient.FeedsBackfillSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Backfill Subscription<br/>
        /// Start a background job to send historical messages to an agent subscription. Returns immediately with workflow ID. Does not update last_consumed_sequence.
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsBackfillSubscriptionResponse> FeedsBackfillSubscriptionAsync(
            string feedId,
            string subscriptionId,

            global::G.FeedsBackfillSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Backfill Subscription<br/>
        /// Start a background job to send historical messages to an agent subscription. Returns immediately with workflow ID. Does not update last_consumed_sequence.
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="fromSequence"></param>
        /// <param name="toSequence"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsBackfillSubscriptionResponse> FeedsBackfillSubscriptionAsync(
            string feedId,
            string subscriptionId,
            double? fromSequence = default,
            double? toSequence = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}