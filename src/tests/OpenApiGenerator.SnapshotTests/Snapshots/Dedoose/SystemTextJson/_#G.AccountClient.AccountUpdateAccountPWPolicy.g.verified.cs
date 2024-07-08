//HintName: G.AccountClient.AccountUpdateAccountPWPolicy.g.cs

#nullable enable

namespace G
{
    public partial class AccountClient
    {
        partial void PrepareAccountUpdateAccountPWPolicyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string accountId,
            ref bool enforcePolicy,
            ref int minLength,
            ref bool requireChar,
            ref bool requireUpper,
            ref bool requireNumber,
            ref bool requireSymbol,
            ref double maxAgeInDays,
            ref bool require2Auth,
            ref bool relogin2Auth,
            ref int idleTimeoutInMinutes);
        partial void PrepareAccountUpdateAccountPWPolicyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string accountId,
            bool enforcePolicy,
            int minLength,
            bool requireChar,
            bool requireUpper,
            bool requireNumber,
            bool requireSymbol,
            double maxAgeInDays,
            bool require2Auth,
            bool relogin2Auth,
            int idleTimeoutInMinutes);
        partial void ProcessAccountUpdateAccountPWPolicyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAccountUpdateAccountPWPolicyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateAccountPWPolicy.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="enforcePolicy"></param>
        /// <param name="minLength"></param>
        /// <param name="requireChar"></param>
        /// <param name="requireUpper"></param>
        /// <param name="requireNumber"></param>
        /// <param name="requireSymbol"></param>
        /// <param name="maxAgeInDays"></param>
        /// <param name="require2Auth"></param>
        /// <param name="relogin2Auth"></param>
        /// <param name="idleTimeoutInMinutes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AccountVO> AccountUpdateAccountPWPolicyAsync(
            string token,
            string accountId,
            bool enforcePolicy,
            int minLength,
            bool requireChar,
            bool requireUpper,
            bool requireNumber,
            bool requireSymbol,
            double maxAgeInDays,
            bool require2Auth,
            bool relogin2Auth,
            int idleTimeoutInMinutes,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAccountUpdateAccountPWPolicyArguments(
                httpClient: _httpClient,
                token: ref token,
                accountId: ref accountId,
                enforcePolicy: ref enforcePolicy,
                minLength: ref minLength,
                requireChar: ref requireChar,
                requireUpper: ref requireUpper,
                requireNumber: ref requireNumber,
                requireSymbol: ref requireSymbol,
                maxAgeInDays: ref maxAgeInDays,
                require2Auth: ref require2Auth,
                relogin2Auth: ref relogin2Auth,
                idleTimeoutInMinutes: ref idleTimeoutInMinutes);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/account/updateaccountpwpolicy?accountId={accountId}&enforcePolicy={enforcePolicy}&minLength={minLength}&requireChar={requireChar}&requireUpper={requireUpper}&requireNumber={requireNumber}&requireSymbol={requireSymbol}&maxAgeInDays={maxAgeInDays}&require2Auth={require2Auth}&relogin2Auth={relogin2Auth}&idleTimeoutInMinutes={idleTimeoutInMinutes}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAccountUpdateAccountPWPolicyRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                accountId: accountId,
                enforcePolicy: enforcePolicy,
                minLength: minLength,
                requireChar: requireChar,
                requireUpper: requireUpper,
                requireNumber: requireNumber,
                requireSymbol: requireSymbol,
                maxAgeInDays: maxAgeInDays,
                require2Auth: require2Auth,
                relogin2Auth: relogin2Auth,
                idleTimeoutInMinutes: idleTimeoutInMinutes);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAccountUpdateAccountPWPolicyResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAccountUpdateAccountPWPolicyResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.AccountVO?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}