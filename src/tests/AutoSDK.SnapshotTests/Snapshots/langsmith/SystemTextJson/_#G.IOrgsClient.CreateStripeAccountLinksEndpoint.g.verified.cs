//HintName: G.IOrgsClient.CreateStripeAccountLinksEndpoint.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Stripe Account Links Endpoint<br/>
        /// Kick off a Stripe account link flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateStripeAccountLinksEndpointAsync(
            global::G.StripeAccountLinksCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Stripe Account Links Endpoint<br/>
        /// Kick off a Stripe account link flow.
        /// </summary>
        /// <param name="successPath"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateStripeAccountLinksEndpointAsync(
            string successPath,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}