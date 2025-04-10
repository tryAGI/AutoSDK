//HintName: G.IXGatewayClient.XGatewayTransactionsCallback.g.cs
#nullable enable

namespace G
{
    public partial interface IXGatewayClient
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
        global::System.Threading.Tasks.Task XGatewayTransactionsCallbackAsync(
            global::G.XGatewayTransactionsCallbackRequest request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="callbackType"></param>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <param name="customerId"></param>
        /// <param name="hash"></param>
        /// <param name="id"></param>
        /// <param name="network"></param>
        /// <param name="status"></param>
        /// <param name="transactionHash"></param>
        /// <param name="type"></param>
        /// <param name="info"></param>
        /// <param name="fees"></param>
        /// <param name="eur"></param>
        /// <param name="usd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task XGatewayTransactionsCallbackAsync(
            string? callbackType,
            string amount,
            string currency,
            string customerId,
            string? hash,
            string id,
            string? network,
            string? status,
            string? transactionHash,
            string? type,
            global::G.TransactionInfo? info,
            global::G.FeesInfo? fees,
            string? eur,
            string? usd,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}