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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConfirmCheckoutSessionCompletionEndpointAsync(
            global::G.StripeCheckoutSessionsConfirm request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Confirm Checkout Session Completion Endpoint<br/>
        /// Complete a Stripe checkout session flow.
        /// </summary>
        /// <param name="stripeSessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConfirmCheckoutSessionCompletionEndpointAsync(
            string stripeSessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}