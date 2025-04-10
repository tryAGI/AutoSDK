//HintName: G.IWalletsClient.GetWallet.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletsClient
    {
        /// <summary>
        /// Get Wallet Information<br/>
        /// Returns the balance of the wallet.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWalletResponseDto> GetWalletAsync(
            global::G.WalletType id,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}