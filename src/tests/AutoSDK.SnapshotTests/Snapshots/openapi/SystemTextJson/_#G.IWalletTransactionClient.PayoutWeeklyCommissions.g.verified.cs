//HintName: G.IWalletTransactionClient.PayoutWeeklyCommissions.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletTransactionClient
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
        global::System.Threading.Tasks.Task<string> PayoutWeeklyCommissionsAsync(
            global::G.WalletTransactionForPayoutCommissionsRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="payoutPeriodId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PayoutWeeklyCommissionsAsync(
            string? currentCulture = default,
            long? payoutPeriodId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}