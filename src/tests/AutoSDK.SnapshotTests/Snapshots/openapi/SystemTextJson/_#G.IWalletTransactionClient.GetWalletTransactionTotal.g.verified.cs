//HintName: G.IWalletTransactionClient.GetWalletTransactionTotal.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletTransactionClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="walletTypeId"></param>
        /// <param name="userId"></param>
        /// <param name="bTCWithdrawalAddress"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WalletTransactionForTotalResponseDto> GetWalletTransactionTotalAsync(
            int? walletTypeId = default,
            long? userId = default,
            string? bTCWithdrawalAddress = default,
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}