//HintName: G.IStripeClient.UpgradeExistingCustomerToTeamBundle.g.cs
#nullable enable

namespace G
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpgradeExistingCustomerToTeamBundleAsync(

            global::G.UpgradeToTeamBundleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpgradeExistingCustomerToTeamBundleAsync(
            global::G.UpgradeToTeamBundleRequestUiMode? uiMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}