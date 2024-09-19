//HintName: G.GuestStarClient.EndGuestStarSession.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        partial void PrepareEndGuestStarSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string sessionId);
        partial void PrepareEndGuestStarSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string sessionId);
        partial void ProcessEndGuestStarSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// BETA Programmatically ends a Guest Star session on behalf of the broadcaster.<br/>
        /// BETA Programmatically ends a Guest Star session on behalf of the broadcaster. Performs the same action as if the host clicked the “End Call” button in the Guest Star UI.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task EndGuestStarSessionAsync(
            string broadcasterId,
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareEndGuestStarSessionArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                sessionId: ref sessionId);

            var __pathBuilder = new PathBuilder(
                path: "/guest_star/session",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                .AddRequiredParameter("session_id", sessionId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareEndGuestStarSessionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                sessionId: sessionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessEndGuestStarSessionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}