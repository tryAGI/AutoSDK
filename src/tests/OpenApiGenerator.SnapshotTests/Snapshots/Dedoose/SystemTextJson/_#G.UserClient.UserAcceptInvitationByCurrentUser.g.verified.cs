//HintName: G.UserClient.UserAcceptInvitationByCurrentUser.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserAcceptInvitationByCurrentUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string invitationId);
        partial void PrepareUserAcceptInvitationByCurrentUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string invitationId);
        partial void ProcessUserAcceptInvitationByCurrentUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserAcceptInvitationByCurrentUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AcceptInvitationByCurrentUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> UserAcceptInvitationByCurrentUserAsync(
            string token,
            string invitationId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserAcceptInvitationByCurrentUserArguments(
                httpClient: _httpClient,
                token: ref token,
                invitationId: ref invitationId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/user/acceptinvitationbycurrentuser?invitationId={invitationId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUserAcceptInvitationByCurrentUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                invitationId: invitationId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserAcceptInvitationByCurrentUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserAcceptInvitationByCurrentUserResponseContent(
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