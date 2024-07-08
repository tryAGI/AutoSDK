//HintName: G.AccountClient.AccountDisableRecurringPayment.g.cs

#nullable enable

namespace G
{
    public partial class AccountClient
    {
        partial void PrepareAccountDisableRecurringPaymentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string accountId);
        partial void PrepareAccountDisableRecurringPaymentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string accountId);
        partial void ProcessAccountDisableRecurringPaymentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAccountDisableRecurringPaymentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DisableRecurringPayment.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> AccountDisableRecurringPaymentAsync(
            string token,
            string accountId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAccountDisableRecurringPaymentArguments(
                httpClient: _httpClient,
                token: ref token,
                accountId: ref accountId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/account/disablerecurringpayment?accountId={accountId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAccountDisableRecurringPaymentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                accountId: accountId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAccountDisableRecurringPaymentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAccountDisableRecurringPaymentResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}