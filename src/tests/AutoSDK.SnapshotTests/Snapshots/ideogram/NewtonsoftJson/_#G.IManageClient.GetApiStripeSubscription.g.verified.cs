//HintName: G.IManageClient.GetApiStripeSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve data relevant to connecting to Stripe.
        /// </summary>
        /// <param name="isBusiness"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ManageApiStripeSubscriptionResponse> GetApiStripeSubscriptionAsync(
            bool? isBusiness = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}