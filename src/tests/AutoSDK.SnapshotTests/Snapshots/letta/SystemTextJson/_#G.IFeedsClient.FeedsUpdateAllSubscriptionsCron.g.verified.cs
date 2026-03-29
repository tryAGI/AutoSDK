//HintName: G.IFeedsClient.FeedsUpdateAllSubscriptionsCron.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Update All Subscriptions Cron Schedule<br/>
        /// Update the cron schedule for all subscriptions of a feed
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsUpdateAllSubscriptionsCronResponse> FeedsUpdateAllSubscriptionsCronAsync(
            string feedId,

            global::G.FeedsUpdateAllSubscriptionsCronRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update All Subscriptions Cron Schedule<br/>
        /// Update the cron schedule for all subscriptions of a feed
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsUpdateAllSubscriptionsCronResponse> FeedsUpdateAllSubscriptionsCronAsync(
            string feedId,
            string cronSchedule,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}