//HintName: G.IWalletTransactionClient.BTCCurrentRate.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletTransactionClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="request"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BTCForCurrentRateResponseDto> BTCCurrentRateAsync(
            object? request = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}