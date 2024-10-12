//HintName: G.IAdminClient.AdminProcessPayment.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// ProcessPayment.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="amount"></param>
        /// <param name="memo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AdminProcessPaymentAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            double? amount = default,
            string? memo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}