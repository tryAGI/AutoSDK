//HintName: G.ISubpackageCreditsClient.CreateCoinbaseCharge.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageCreditsClient
    {
        /// <summary>
        /// Create a Coinbase charge for crypto payment<br/>
        /// Create a Coinbase charge for crypto payment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreditsCreateCoinbaseChargeResponse200> CreateCoinbaseChargeAsync(

            global::G.CreateChargeRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Coinbase charge for crypto payment<br/>
        /// Create a Coinbase charge for crypto payment
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="sender"></param>
        /// <param name="chainId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreditsCreateCoinbaseChargeResponse200> CreateCoinbaseChargeAsync(
            double amount,
            string sender,
            global::G.CreateChargeRequestChainId chainId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}