//HintName: G.ModerationClient.GetUnbanRequests.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// NEW Gets a list of unban requests for a broadcaster’s channel.<br/>
        /// NEW Gets a list of unban requests for a broadcaster’s channel.<br/>
        /// __Authorization:__<br/>
        /// * Requires a user access token that includes the **moderator:read:unban\_requests** or **moderator:manage:unban\_requests** scope.<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [user access token](https://dev.twitch.tv/docs/authentication/#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="status"></param>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetUnbanRequestsResponse> GetUnbanRequestsAsync(
            string broadcasterId,
            string moderatorId,
            string status,
            string userId,
            string after,
            int first,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/moderation/unban_requests?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&status={status}&user_id={userId}&after={after}&first={first}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetUnbanRequestsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}