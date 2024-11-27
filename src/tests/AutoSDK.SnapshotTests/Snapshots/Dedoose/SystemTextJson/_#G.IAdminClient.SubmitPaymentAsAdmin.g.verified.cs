//HintName: G.IAdminClient.SubmitPaymentAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SubmitPayment<br/>
        /// SubmitPayment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SubmitPaymentAsAdminAsync(
            global::G.SubmitPaymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SubmitPayment<br/>
        /// SubmitPayment
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="amount"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address1"></param>
        /// <param name="address2"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="country"></param>
        /// <param name="zip"></param>
        /// <param name="cardType"></param>
        /// <param name="cardNum"></param>
        /// <param name="cardCCV"></param>
        /// <param name="expMonth"></param>
        /// <param name="expYear"></param>
        /// <param name="saveAsReoccuring"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SubmitPaymentAsAdminAsync(
            global::System.Guid accountId,
            double amount,
            string firstName,
            string lastName,
            string address1,
            string address2,
            string city,
            string state,
            string country,
            string zip,
            int cardType,
            string cardNum,
            string cardCCV,
            int expMonth,
            int expYear,
            bool saveAsReoccuring,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}