//HintName: G.ISubscriptionsClient.CancelSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// Cancel subscription
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}