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
            ref string resolutionText);
        partial void PrepareResolveUnbanRequestsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string moderatorId,
            string unbanRequestId,
            string status,
            string resolutionText);
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
            string resolutionText,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/moderation/unban_requests?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&unban_request_id={unbanRequestId}&status={status}&resolution_text={resolutionText}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ResolveUnbanRequestsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}