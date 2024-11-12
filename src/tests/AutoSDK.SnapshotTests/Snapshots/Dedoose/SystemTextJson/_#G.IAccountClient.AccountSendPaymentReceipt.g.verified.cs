//HintName: G.IAccountClient.AccountSendPaymentReceipt.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// SendPaymentReceipt.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="transactionId"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AccountSendPaymentReceiptAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            global::System.Guid? transactionId = default,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}