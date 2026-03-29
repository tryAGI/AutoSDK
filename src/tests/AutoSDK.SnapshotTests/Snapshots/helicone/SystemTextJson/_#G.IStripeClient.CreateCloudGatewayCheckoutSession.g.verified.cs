//HintName: G.IStripeClient.CreateCloudGatewayCheckoutSession.g.cs
#nullable enable

namespace G
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCloudGatewayCheckoutSessionResponse> CreateCloudGatewayCheckoutSessionAsync(

            global::G.CreateCloudGatewayCheckoutSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="returnUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCloudGatewayCheckoutSessionResponse> CreateCloudGatewayCheckoutSessionAsync(
            double amount,
            string? returnUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}