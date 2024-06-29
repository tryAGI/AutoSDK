//HintName: G.AccountClient.AccountUpdateAccountPWPolicy.g.cs

#nullable enable

namespace G
{
    public partial class AccountClient
    {
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
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/api/v1/account/updateaccountpwpolicy?accountId={accountId}&enforcePolicy={enforcePolicy}&minLength={minLength}&requireChar={requireChar}&requireUpper={requireUpper}&requireNumber={requireNumber}&requireSymbol={requireSymbol}&maxAgeInDays={maxAgeInDays}&require2Auth={require2Auth}&relogin2Auth={relogin2Auth}&idleTimeoutInMinutes={idleTimeoutInMinutes}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AccountVO?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}