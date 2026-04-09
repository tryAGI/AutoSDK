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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetSubscriptionPaymentLinkAsync(

            global::G.SubscriptionPaymentLinkRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get subscription checkout link
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task GetSubscriptionPaymentLinkAsync(
            string? planId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}