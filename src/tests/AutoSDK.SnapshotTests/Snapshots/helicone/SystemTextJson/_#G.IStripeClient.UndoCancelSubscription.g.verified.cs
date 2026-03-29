//HintName: G.IStripeClient.UndoCancelSubscription.g.cs
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
        global::System.Threading.Tasks.Task<double> UndoCancelSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}