//HintName: G.IAdminClient.AdminSubmitPayment.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SubmitPayment.
        /// </summary>
        /// <param name="token"></param>
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AdminSubmitPaymentAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            double? amount = default,
            string? firstName = default,
            string? lastName = default,
            string? address1 = default,
            string? address2 = default,
            string? city = default,
            string? state = default,
            string? country = default,
            string? zip = default,
            int? cardType = default,
            string? cardNum = default,
            string? cardCCV = default,
            int? expMonth = default,
            int? expYear = default,
            bool? saveAsReoccuring = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}