//HintName: G.ModerationClient.ResolveUnbanRequests.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        partial void PrepareResolveUnbanRequestsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string moderatorId,
            ref string unbanRequestId,
            ref string status,
            ref string? resolutionText);
        partial void PrepareResolveUnbanRequestsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string moderatorId,
            string unbanRequestId,
            string status,
            string? resolutionText);
        partial void ProcessResolveUnbanRequestsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResolveUnbanRequestsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// NEW Resolves an unban request by approving or denying it.<br/>
        /// NEW Resolves an unban request by approving or denying it.<br/>
        /// __Authorization:__<br/>
        /// * Requires a user access token that includes the **moderator:manage:unban\\\_requests** scope.<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the[user access token](https://dev.twitch.tv/docs/authentication/#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="unbanRequestId"></param>
        /// <param name="status"></param>
        /// <param name="resolutionText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ResolveUnbanRequestsResponse> ResolveUnbanRequestsAsync(
            string broadcasterId,
            string moderatorId,
            string unbanRequestId,
            string status,
            string? resolutionText = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResolveUnbanRequestsArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                moderatorId: ref moderatorId,
                unbanRequestId: ref unbanRequestId,
                status: ref status,
                resolutionText: ref resolutionText);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/moderation/unban_requests?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&unban_request_id={unbanRequestId}&status={status}&resolution_text={resolutionText}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareResolveUnbanRequestsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                unbanRequestId: unbanRequestId,
                status: status,
                resolutionText: resolutionText);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResolveUnbanRequestsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResolveUnbanRequestsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ResolveUnbanRequestsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}