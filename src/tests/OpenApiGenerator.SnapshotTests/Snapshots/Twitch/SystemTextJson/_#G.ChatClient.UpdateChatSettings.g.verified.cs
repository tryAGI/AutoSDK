//HintName: G.ChatClient.UpdateChatSettings.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        /// <summary>
        /// Updates the broadcaster’s chat settings.<br/>
        /// Updates the broadcaster’s chat settings.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:chat\_settings** scope.<br/>
        /// __Request Body:__<br/>
        /// All fields are optional. Specify only those fields that you want to update.<br/>
        /// To set the `slow_mode_wait_time` or `follower_mode_duration` field to its default value, set the corresponding `slow_mode` or `follower_mode` field to **true** (and don’t include the `slow_mode_wait_time` or `follower_mode_duration` field).<br/>
        /// To set the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field’s value, you must set the corresponding `slow_mode`, `follower_mode`, or `non_moderator_chat_delay` field to **true**.<br/>
        /// To remove the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field’s value, set the corresponding `slow_mode`, `follower_mode`, or `non_moderator_chat_delay` field to **false** (and don’t include the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateChatSettingsResponse> UpdateChatSettingsAsync(
            string broadcasterId,
            string moderatorId,
            global::G.UpdateChatSettingsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/chat/settings?broadcaster_id={broadcasterId}&moderator_id={moderatorId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateChatSettingsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Updates the broadcaster’s chat settings.<br/>
        /// Updates the broadcaster’s chat settings.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:chat\_settings** scope.<br/>
        /// __Request Body:__<br/>
        /// All fields are optional. Specify only those fields that you want to update.<br/>
        /// To set the `slow_mode_wait_time` or `follower_mode_duration` field to its default value, set the corresponding `slow_mode` or `follower_mode` field to **true** (and don’t include the `slow_mode_wait_time` or `follower_mode_duration` field).<br/>
        /// To set the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field’s value, you must set the corresponding `slow_mode`, `follower_mode`, or `non_moderator_chat_delay` field to **true**.<br/>
        /// To remove the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field’s value, set the corresponding `slow_mode`, `follower_mode`, or `non_moderator_chat_delay` field to **false** (and don’t include the `slow_mode_wait_time`, `follower_mode_duration`, or `non_moderator_chat_delay_duration` field).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="emoteMode"></param>
        /// <param name="followerMode"></param>
        /// <param name="followerModeDuration"></param>
        /// <param name="nonModeratorChatDelay"></param>
        /// <param name="nonModeratorChatDelayDuration"></param>
        /// <param name="slowMode"></param>
        /// <param name="slowModeWaitTime"></param>
        /// <param name="subscriberMode"></param>
        /// <param name="uniqueChatMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateChatSettingsResponse> UpdateChatSettingsAsync(
            string broadcasterId,
            string moderatorId,
            bool emoteMode = default,
            bool followerMode = default,
            int followerModeDuration = default,
            bool nonModeratorChatDelay = default,
            int nonModeratorChatDelayDuration = default,
            bool slowMode = default,
            int slowModeWaitTime = default,
            bool subscriberMode = default,
            bool uniqueChatMode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateChatSettingsBody
            {
                EmoteMode = emoteMode,
                FollowerMode = followerMode,
                FollowerModeDuration = followerModeDuration,
                NonModeratorChatDelay = nonModeratorChatDelay,
                NonModeratorChatDelayDuration = nonModeratorChatDelayDuration,
                SlowMode = slowMode,
                SlowModeWaitTime = slowModeWaitTime,
                SubscriberMode = subscriberMode,
                UniqueChatMode = uniqueChatMode,
            };

            return await UpdateChatSettingsAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}