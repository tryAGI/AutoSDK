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
                client: HttpClient);
            PrepareUserSubmitCurrentAccountPaymentArguments(
                httpClient: HttpClient,
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

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/user/submitcurrentaccountpayment",
                baseUri: HttpClient.BaseAddress); 
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
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUserSubmitCurrentAccountPaymentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUserSubmitCurrentAccountPaymentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUserSubmitCurrentAccountPaymentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::System.InvalidOperationException(__content, __ex);
                }

                return
                    global::G.PaymentResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.PaymentResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}