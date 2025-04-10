//HintName: G.IWalletFundingRequestClient.CreateChangellyDeposit.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletFundingRequestClient
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
        global::System.Threading.Tasks.Task<global::G.CreateChagellyDepositResponseDto> CreateChangellyDepositAsync(
            global::G.CreateChagellyDepositRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="amount"></param>
        /// <param name="providerCode"></param>
        /// <param name="quickPay"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChagellyDepositResponseDto> CreateChangellyDepositAsync(
            string? currentCulture = default,
            long? userId = default,
            double? amount = default,
            string? providerCode = default,
            bool? quickPay = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}