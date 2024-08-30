//HintName: G.AccountClient.AccountUpdateAccountUser.g.cs

#nullable enable

namespace G
{
    public partial class AccountClient
    {
        partial void PrepareAccountUpdateAccountUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? userId,
            ref string? firstName,
            ref string? lastName,
            ref string? phone,
            ref string? email,
            ref bool active);
        partial void PrepareAccountUpdateAccountUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? userId,
            string? firstName,
            string? lastName,
            string? phone,
            string? email,
            bool active);
        partial void ProcessAccountUpdateAccountUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAccountUpdateAccountUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateAccountUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="active"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.User> AccountUpdateAccountUserAsync(
            string? token = default,
            string? userId = default,
            string? firstName = default,
            string? lastName = default,
            string? phone = default,
            string? email = default,
            bool active = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAccountUpdateAccountUserArguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId,
                firstName: ref firstName,
                lastName: ref lastName,
                phone: ref phone,
                email: ref email,
                active: ref active);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/account/updateaccountuser?userId={userId}&firstName={firstName}&lastName={lastName}&phone={phone}&email={email}&active={active}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAccountUpdateAccountUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId,
                firstName: firstName,
                lastName: lastName,
                phone: phone,
                email: email,
                active: active);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAccountUpdateAccountUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAccountUpdateAccountUserResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.User?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}