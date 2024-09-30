//HintName: G.UserClient.UserAddNewUserToAccount.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserAddNewUserToAccountArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref string? username,
            ref string? firstName,
            ref string? lastName,
            ref string? email,
            ref string? phone,
            ref string? encryptedPass,
            ref global::System.Guid? groupId);
        partial void PrepareUserAddNewUserToAccountRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            string? username,
            string? firstName,
            string? lastName,
            string? email,
            string? phone,
            string? encryptedPass,
            global::System.Guid? groupId);
        partial void ProcessUserAddNewUserToAccountResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserAddNewUserToAccountResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddNewUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UserServiceAddNewUserToAccountControllerOutput> UserAddNewUserToAccountAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? username = default,
            string? firstName = default,
            string? lastName = default,
            string? email = default,
            string? phone = default,
            string? encryptedPass = default,
            global::System.Guid? groupId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserAddNewUserToAccountArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                username: ref username,
                firstName: ref firstName,
                lastName: ref lastName,
                email: ref email,
                phone: ref phone,
                encryptedPass: ref encryptedPass,
                groupId: ref groupId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/user/addnewusertoaccount",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("username", username) 
                .AddOptionalParameter("firstName", firstName) 
                .AddOptionalParameter("lastName", lastName) 
                .AddOptionalParameter("email", email) 
                .AddOptionalParameter("phone", phone) 
                .AddOptionalParameter("encryptedPass", encryptedPass) 
                .AddOptionalParameter("groupId", groupId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUserAddNewUserToAccountRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                username: username,
                firstName: firstName,
                lastName: lastName,
                email: email,
                phone: phone,
                encryptedPass: encryptedPass,
                groupId: groupId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserAddNewUserToAccountResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserAddNewUserToAccountResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UserServiceAddNewUserToAccountControllerOutput?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}