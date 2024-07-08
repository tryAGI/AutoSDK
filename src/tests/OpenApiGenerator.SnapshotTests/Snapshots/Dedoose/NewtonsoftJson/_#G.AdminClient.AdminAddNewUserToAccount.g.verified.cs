//HintName: G.AdminClient.AdminAddNewUserToAccount.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminAddNewUserToAccountArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string accountId,
            ref string username,
            ref string firstName,
            ref string lastName,
            ref string email,
            ref string phone,
            ref string encryptedPass);
        partial void PrepareAdminAddNewUserToAccountRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string accountId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass);
        partial void ProcessAdminAddNewUserToAccountResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminAddNewUserToAccountResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddNewUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> AdminAddNewUserToAccountAsync(
            string token,
            string accountId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminAddNewUserToAccountArguments(
                httpClient: _httpClient,
                token: ref token,
                accountId: ref accountId,
                username: ref username,
                firstName: ref firstName,
                lastName: ref lastName,
                email: ref email,
                phone: ref phone,
                encryptedPass: ref encryptedPass);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/admin/addnewusertoaccount?accountId={accountId}&username={username}&firstName={firstName}&lastName={lastName}&email={email}&phone={phone}&encryptedPass={encryptedPass}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAdminAddNewUserToAccountRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                accountId: accountId,
                username: username,
                firstName: firstName,
                lastName: lastName,
                email: email,
                phone: phone,
                encryptedPass: encryptedPass);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminAddNewUserToAccountResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminAddNewUserToAccountResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}