//HintName: G.IWalletsClient.GetWallets.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletsClient
    {
        /// <summary>
        /// Get Information for All Wallets<br/>
        /// Returns the balance of all wallets.
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GetWalletResponseDto>> GetWalletsAsync(
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}