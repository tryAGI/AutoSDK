//HintName: G.UserClient.UserSubmitCurrentAccountPayment.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserSubmitCurrentAccountPaymentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref double? amount,
            ref string? firstName,
            ref string? lastName,
            ref string? address1,
            ref string? address2,
            ref string? city,
            ref string? state,
            ref string? country,
            ref string? zip,
            ref int? cardType,
            ref string? cardNum,
            ref string? cardCCV,
            ref int? expMonth,
            ref int? expYear,
            ref bool? saveAsReoccuring);
        partial void PrepareUserSubmitCurrentAccountPaymentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            double? amount,
            string? firstName,
            string? lastName,
            string? address1,
            string? address2,
            string? city,
            string? state,
            string? country,
            string? zip,
            int? cardType,
            string? cardNum,
            string? cardCCV,
            int? expMonth,
            int? expYear,
            bool? saveAsReoccuring);
        partial void ProcessUserSubmitCurrentAccountPaymentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserSubmitCurrentAccountPaymentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// SubmitCurrentAccountPayment.
        /// </summary>
        /// <param name="token"></param>
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
        public async global::System.Threading.Tasks.Task<global::G.PaymentResponse> UserSubmitCurrentAccountPaymentAsync(
            string? token = default,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserSubmitCurrentAccountPaymentArguments(
                httpClient: _httpClient,
                token: ref token,
                amount: ref amount,
                firstName: ref firstName,
                lastName: ref lastName,
                address1: ref address1,
                address2: ref address2,
                city: ref city,
                state: ref state,
                country: ref country,
                zip: ref zip,
                cardType: ref cardType,
                cardNum: ref cardNum,
                cardCCV: ref cardCCV,
                expMonth: ref expMonth,
                expYear: ref expYear,
                saveAsReoccuring: ref saveAsReoccuring);

            if (token != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("token", token.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/user/submitcurrentaccountpayment",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("amount", amount?.ToString()) 
                .AddOptionalParameter("firstName", firstName) 
                .AddOptionalParameter("lastName", lastName) 
                .AddOptionalParameter("address1", address1) 
                .AddOptionalParameter("address2", address2) 
                .AddOptionalParameter("city", city) 
                .AddOptionalParameter("state", state) 
                .AddOptionalParameter("country", country) 
                .AddOptionalParameter("zip", zip) 
                .AddOptionalParameter("cardType", cardType?.ToString()) 
                .AddOptionalParameter("cardNum", cardNum) 
                .AddOptionalParameter("cardCCV", cardCCV) 
                .AddOptionalParameter("expMonth", expMonth?.ToString()) 
                .AddOptionalParameter("expYear", expYear?.ToString()) 
                .AddOptionalParameter("saveAsReoccuring", saveAsReoccuring?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUserSubmitCurrentAccountPaymentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                amount: amount,
                firstName: firstName,
                lastName: lastName,
                address1: address1,
                address2: address2,
                city: city,
                state: state,
                country: country,
                zip: zip,
                cardType: cardType,
                cardNum: cardNum,
                cardCCV: cardCCV,
                expMonth: expMonth,
                expYear: expYear,
                saveAsReoccuring: saveAsReoccuring);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserSubmitCurrentAccountPaymentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserSubmitCurrentAccountPaymentResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PaymentResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}