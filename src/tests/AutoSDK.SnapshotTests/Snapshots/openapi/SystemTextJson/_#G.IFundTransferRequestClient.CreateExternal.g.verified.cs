//HintName: G.IFundTransferRequestClient.CreateExternal.g.cs
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
        global::System.Threading.Tasks.Task<string> CreateExternalAsync(
            global::G.FundTransferExternalRequestForCreateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="originWalletTypeEnumId"></param>
        /// <param name="walletTypeEnumId"></param>
        /// <param name="destinationWalletUserId"></param>
        /// <param name="amount"></param>
        /// <param name="transferChargePercent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateExternalAsync(
            string? currentCulture = default,
            long? userId = default,
            int? originWalletTypeEnumId = default,
            int? walletTypeEnumId = default,
            long? destinationWalletUserId = default,
            double? amount = default,
            double? transferChargePercent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}