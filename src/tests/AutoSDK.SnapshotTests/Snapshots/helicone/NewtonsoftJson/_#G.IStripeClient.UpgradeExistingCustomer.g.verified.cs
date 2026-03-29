//HintName: G.IStripeClient.UpgradeExistingCustomer.g.cs
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
        global::System.Threading.Tasks.Task<string> UpgradeExistingCustomerAsync(

            global::G.UpgradeToProRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addons"></param>
        /// <param name="seats"></param>
        /// <param name="uiMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpgradeExistingCustomerAsync(
            global::G.UpgradeToProRequestAddons? addons = default,
            double? seats = default,
            global::G.UpgradeToProRequestUiMode? uiMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}