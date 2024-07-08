//HintName: G.SecurityClient.SecurityImpersonateUser.g.cs

#nullable enable

namespace G
{
    public partial class SecurityClient
    {
        partial void PrepareSecurityImpersonateUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string username,
            ref string email);
        partial void PrepareSecurityImpersonateUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string username,
            string email);
        partial void ProcessSecurityImpersonateUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityImpersonateUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ImpersonateUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> SecurityImpersonateUserAsync(
            string token,
            string username,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSecurityImpersonateUserArguments(
                httpClient: _httpClient,
                token: ref token,
                username: ref username,
                email: ref email);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/security/impersonateuser?username={username}&email={email}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecurityImpersonateUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                username: username,
                email: email);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecurityImpersonateUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecurityImpersonateUserResponseContent(
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