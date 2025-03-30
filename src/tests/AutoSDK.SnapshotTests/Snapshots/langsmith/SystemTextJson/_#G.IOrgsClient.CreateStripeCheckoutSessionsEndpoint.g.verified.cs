//HintName: G.IOrgsClient.CreateStripeCheckoutSessionsEndpoint.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Stripe Checkout Sessions Endpoint<br/>
        /// Kick off a Stripe checkout session flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateStripeCheckoutSessionsEndpointAsync(
            global::G.StripeCheckoutSessionsCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Stripe Checkout Sessions Endpoint<br/>
        /// Kick off a Stripe checkout session flow.
        /// </summary>
        /// <param name="amountCents"></param>
        /// <param name="successPath"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateStripeCheckoutSessionsEndpointAsync(
            int amountCents,
            string successPath,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}