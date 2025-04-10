//HintName: G.IOrderClient.PlaceWithWalletPayment.g.cs
#nullable enable

namespace G
{
    public partial interface IOrderClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrderForPlaceWithWalletPaymentResponseDto> PlaceWithWalletPaymentAsync(
            global::G.OrderForPlaceWithWalletPaymentRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="walletTypeEnumId"></param>
        /// <param name="shopModeIsInfin8Direct"></param>
        /// <param name="secondWalletTypeEnumId"></param>
        /// <param name="userId"></param>
        /// <param name="lineItems"></param>
        /// <param name="appPurchase"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrderForPlaceWithWalletPaymentResponseDto> PlaceWithWalletPaymentAsync(
            string? currentCulture = default,
            int? walletTypeEnumId = default,
            bool? shopModeIsInfin8Direct = default,
            int? secondWalletTypeEnumId = default,
            long? userId = default,
            global::System.Collections.Generic.IList<global::G.OrderLineItemDto>? lineItems = default,
            bool? appPurchase = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}