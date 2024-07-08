//HintName: G.AdminClient.AdminSubmitPayment.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminSubmitPaymentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string accountId,
            ref double amount,
            ref string firstName,
            ref string lastName,
            ref string address1,
            ref string address2,
            ref string city,
            ref string state,
            ref string country,
            ref string zip,
            ref int cardType,
            ref string cardNum,
            ref string cardCCV,
            ref int expMonth,
            ref int expYear,
            ref bool saveAsReoccuring);
        partial void PrepareAdminSubmitPaymentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string accountId,
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
            bool saveAsReoccuring);
        partial void ProcessAdminSubmitPaymentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessAdminSubmitPaymentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> AdminSubmitPaymentAsync(
            string token,
            string accountId,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/admin/submitpayment?accountId={accountId}&amount={amount}&firstName={firstName}&lastName={lastName}&address1={address1}&address2={address2}&city={city}&state={state}&country={country}&zip={zip}&cardType={cardType}&cardNum={cardNum}&cardCCV={cardCCV}&expMonth={expMonth}&expYear={expYear}&saveAsReoccuring={saveAsReoccuring}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}