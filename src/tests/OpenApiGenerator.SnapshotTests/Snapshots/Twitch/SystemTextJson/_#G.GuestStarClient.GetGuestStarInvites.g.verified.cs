//HintName: G.GuestStarClient.GetGuestStarInvites.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        partial void PrepareGetGuestStarInvitesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string moderatorId,
            ref string sessionId);
        partial void PrepareGetGuestStarInvitesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string moderatorId,
            string sessionId);
        partial void ProcessGetGuestStarInvitesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetGuestStarInvitesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// BETA Provides the caller with a list of pending invites to a Guest Star session.<br/>
        /// BETA Provides the caller with a list of pending invites to a Guest Star session, including the invitee’s ready status while joining the waiting room.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:read:guest_star`, `channel:manage:guest_star`, `moderator:read:guest_star` or `moderator:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetGuestStarInvitesResponse> GetGuestStarInvitesAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetGuestStarInvitesArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                moderatorId: ref moderatorId,
                sessionId: ref sessionId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/guest_star/invites?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&session_id={sessionId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetGuestStarInvitesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetGuestStarInvitesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetGuestStarInvitesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetGuestStarInvitesResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}