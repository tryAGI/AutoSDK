//HintName: G.IAccountClient.DisableRecurringPayment.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// DisableRecurringPayment<br/>
        /// DisableRecurringPayment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DisableRecurringPaymentAsync(
            global::G.DisableRecurringPaymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DisableRecurringPayment<br/>
        /// DisableRecurringPayment
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DisableRecurringPaymentAsync(
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}