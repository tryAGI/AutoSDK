//HintName: G.ISubscriptionsClient.GetSubscriptionPaymentLink.g.cs
#nullable enable

namespace G
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// Get subscription checkout link
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetSubscriptionPaymentLinkAsync(

            global::G.SubscriptionPaymentLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get subscription checkout link
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task GetSubscriptionPaymentLinkAsync(
            string? planId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}