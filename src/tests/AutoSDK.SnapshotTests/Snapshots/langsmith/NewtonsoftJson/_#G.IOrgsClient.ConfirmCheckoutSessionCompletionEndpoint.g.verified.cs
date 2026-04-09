//HintName: G.IOrgsClient.ConfirmCheckoutSessionCompletionEndpoint.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Confirm Checkout Session Completion Endpoint<br/>
        /// Complete a Stripe checkout session flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConfirmCheckoutSessionCompletionEndpointAsync(

            global::G.StripeCheckoutSessionsConfirm request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Confirm Checkout Session Completion Endpoint<br/>
        /// Complete a Stripe checkout session flow.
        /// </summary>
        /// <param name="stripeSessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConfirmCheckoutSessionCompletionEndpointAsync(
            string stripeSessionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}