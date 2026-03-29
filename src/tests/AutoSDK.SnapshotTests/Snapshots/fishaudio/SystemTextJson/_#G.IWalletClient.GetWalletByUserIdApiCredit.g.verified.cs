//HintName: G.IWalletClient.GetWalletByUserIdApiCredit.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletClient
    {
        /// <summary>
        /// Get API Credit
        /// </summary>
        /// <param name="checkFreeCredit">
        /// Default Value: false
        /// </param>
        /// <param name="userId">
        /// Default Value: self
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWalletApiCreditResponse> GetWalletByUserIdApiCreditAsync(
            string? userId,
            bool? checkFreeCredit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}