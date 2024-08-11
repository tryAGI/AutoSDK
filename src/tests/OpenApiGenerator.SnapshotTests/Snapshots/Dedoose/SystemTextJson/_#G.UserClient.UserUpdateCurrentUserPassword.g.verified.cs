//HintName: G.UserClient.UserUpdateCurrentUserPassword.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserUpdateCurrentUserPasswordArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? userId,
            ref string? encryptedPass);
        partial void PrepareUserUpdateCurrentUserPasswordRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? userId,
            string? encryptedPass);
        partial void ProcessUserUpdateCurrentUserPasswordResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserUpdateCurrentUserPasswordResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateCurrentUserPassword.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UserUpdateCurrentUserPasswordResponse> UserUpdateCurrentUserPasswordAsync(
            string? token,
            string? userId,
            string? encryptedPass,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserUpdateCurrentUserPasswordArguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId,
                encryptedPass: ref encryptedPass);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/user/updatecurrentuserpassword?userId={userId}&encryptedPass={encryptedPass}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUserUpdateCurrentUserPasswordRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId,
                encryptedPass: encryptedPass);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserUpdateCurrentUserPasswordResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserUpdateCurrentUserPasswordResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserUpdateCurrentUserPasswordResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}