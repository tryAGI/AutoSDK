//HintName: G.ICustomerClient.UpdateCustomerWithdrawal.g.cs
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
        global::System.Threading.Tasks.Task<string> UpdateCustomerWithdrawalAsync(
            global::G.CustomerForUpdateWithdrawalRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="id"></param>
        /// <param name="btcAddress"></param>
        /// <param name="usdtAddress"></param>
        /// <param name="tusdtAddress"></param>
        /// <param name="xtera"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCustomerWithdrawalAsync(
            string? currentCulture = default,
            long? id = default,
            string? btcAddress = default,
            string? usdtAddress = default,
            string? tusdtAddress = default,
            bool? xtera = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}