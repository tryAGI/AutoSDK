//HintName: G.AdminClient.AdminUpdateUserInfo.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminUpdateUserInfoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string userId,
            ref string username,
            ref string email,
            ref string phone);
        partial void PrepareAdminUpdateUserInfoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string userId,
            string username,
            string email,
            string phone);
        partial void ProcessAdminUpdateUserInfoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminUpdateUserInfoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateUserInfo.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> AdminUpdateUserInfoAsync(
            string token,
            string userId,
            string username,
            string email,
            string phone,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminUpdateUserInfoArguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId,
                username: ref username,
                email: ref email,
                phone: ref phone);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/admin/updateuserinfo?userId={userId}&username={username}&email={email}&phone={phone}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAdminUpdateUserInfoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId,
                username: username,
                email: email,
                phone: phone);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminUpdateUserInfoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminUpdateUserInfoResponseContent(
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