//HintName: G.IStripeClient.CancelSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> CancelSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}