//HintName: G.IFundTransferRequestClient.CreateInternal.g.cs
#nullable enable

namespace G
{
    public partial interface IFundTransferRequestClient
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
        global::System.Threading.Tasks.Task<string> CreateInternalAsync(
            global::G.FundTransferInternalRequestForCreateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="walletTypeId"></param>
        /// <param name="recipientWalletTypeId"></param>
        /// <param name="amount"></param>
        /// <param name="productSubscriptionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateInternalAsync(
            string? currentCulture = default,
            long? userId = default,
            int? walletTypeId = default,
            int? recipientWalletTypeId = default,
            double? amount = default,
            long? productSubscriptionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}