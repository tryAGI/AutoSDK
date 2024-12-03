//HintName: G.IAdminClient.ProcessPaymentAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// ProcessPayment<br/>
        /// ProcessPayment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProcessPaymentAsAdminAsync(
            global::G.ProcessPaymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ProcessPayment<br/>
        /// ProcessPayment
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="amount"></param>
        /// <param name="memo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ProcessPaymentAsAdminAsync(
            global::System.Guid accountId,
            double amount,
            string memo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}