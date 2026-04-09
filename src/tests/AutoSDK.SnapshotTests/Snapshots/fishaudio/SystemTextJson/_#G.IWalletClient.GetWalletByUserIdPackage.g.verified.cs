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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWalletPackageResponse> GetWalletByUserIdPackageAsync(
            string? userId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}