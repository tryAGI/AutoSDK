//HintName: G.IWalletTransactionClient.CreateWalletTransaction.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletTransactionClient
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
        global::System.Threading.Tasks.Task<string> CreateWalletTransactionAsync(
            global::G.WalletTransactionForCreateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="walletTypeIdEnum"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWalletTransactionAsync(
            string? currentCulture = default,
            long? userId = default,
            string? userName = default,
            int? walletTypeIdEnum = default,
            double? amount = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}