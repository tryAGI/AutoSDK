//HintName: G.IAccountClient.SendPaymentReceipt.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// SendPaymentReceipt<br/>
        /// SendPaymentReceipt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SendPaymentReceiptAsync(
            global::G.SendPaymentReceiptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SendPaymentReceipt<br/>
        /// SendPaymentReceipt
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="transactionId"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SendPaymentReceiptAsync(
            global::System.Guid accountId,
            global::System.Guid transactionId,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}