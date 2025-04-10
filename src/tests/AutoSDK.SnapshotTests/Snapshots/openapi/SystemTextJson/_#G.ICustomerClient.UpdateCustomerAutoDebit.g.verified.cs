//HintName: G.ICustomerClient.UpdateCustomerAutoDebit.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomerClient
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
        global::System.Threading.Tasks.Task<string> UpdateCustomerAutoDebitAsync(
            global::G.CustomerForUpdateAutoDebitRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="autoPurchaseDWallet">
        /// Default Value: false
        /// </param>
        /// <param name="cappingRemaining"></param>
        /// <param name="membershipQuantity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCustomerAutoDebitAsync(
            string? currentCulture = default,
            bool? autoPurchaseDWallet = default,
            double? cappingRemaining = default,
            int? membershipQuantity = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}