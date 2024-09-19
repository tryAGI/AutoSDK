//HintName: G.AdminClient.AdminMigrateUserToAccount.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminMigrateUserToAccountArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? userToBeMovedId,
            ref global::System.Guid? accountIdToMoveTo);
        partial void PrepareAdminMigrateUserToAccountRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? userToBeMovedId,
            global::System.Guid? accountIdToMoveTo);
        partial void ProcessAdminMigrateUserToAccountResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminMigrateUserToAccountResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// MigrateUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userToBeMovedId"></param>
        /// <param name="accountIdToMoveTo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AdminMigrateUserToAccountResponse> AdminMigrateUserToAccountAsync(
            string? token = default,
            global::System.Guid? userToBeMovedId = default,
            global::System.Guid? accountIdToMoveTo = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminMigrateUserToAccountArguments(
                httpClient: _httpClient,
                token: ref token,
                userToBeMovedId: ref userToBeMovedId,
                accountIdToMoveTo: ref accountIdToMoveTo);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/admin/migrateusertoaccount",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("userToBeMovedId", userToBeMovedId?.ToString()) 
                .AddOptionalParameter("accountIdToMoveTo", accountIdToMoveTo?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAdminMigrateUserToAccountRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userToBeMovedId: userToBeMovedId,
                accountIdToMoveTo: accountIdToMoveTo);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminMigrateUserToAccountResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminMigrateUserToAccountResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AdminMigrateUserToAccountResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}