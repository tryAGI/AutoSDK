//HintName: G.IOrdersClient.PlaceOrder.g.cs
#nullable enable

namespace G
{
    public partial interface IOrdersClient
    {
        /// <summary>
        /// Place Order<br/>
        /// Places an order for the user.
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PlaceOrderResponseDto> PlaceOrderAsync(
            global::G.PlaceOrderRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Place Order<br/>
        /// Places an order for the user.
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="items"></param>
        /// <param name="walletType"></param>
        /// <param name="cryptoOption"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PlaceOrderResponseDto> PlaceOrderAsync(
            global::System.Collections.Generic.IList<global::G.OrderItemDto> items,
            string? currentCulture = default,
            global::G.WalletType? walletType = default,
            global::G.CryptoOption? cryptoOption = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}