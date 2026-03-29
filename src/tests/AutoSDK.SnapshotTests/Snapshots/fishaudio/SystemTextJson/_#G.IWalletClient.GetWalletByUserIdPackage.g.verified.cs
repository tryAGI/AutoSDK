//HintName: G.IWalletClient.GetWalletByUserIdPackage.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletClient
    {
        /// <summary>
        /// Get User Package
        /// </summary>
        /// <param name="userId">
        /// Default Value: self
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWalletPackageResponse> GetWalletByUserIdPackageAsync(
            string? userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}