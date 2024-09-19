//HintName: G.ChatClient.UpdateChatSettings.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareUpdateChatSettingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string moderatorId,
            global::G.UpdateChatSettingsBody request);
        partial void PrepareUpdateChatSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string moderatorId,
            global::G.UpdateChatSettingsBody request);
        partial void ProcessUpdateChatSettingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateChatSettingsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateChatSettingsArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                moderatorId: ref moderatorId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/chat/settings",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                .AddRequiredParameter("moderator_id", moderatorId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateChatSettingsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateChatSettingsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateChatSettingsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateChatSettingsResponse?>(__content, JsonSerializerOptions) ??
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
        /// <param name="emoteMode">
        /// A Boolean value that determines whether chat messages must contain only emotes.  <br/>
        ///   <br/>
        /// Set to **true** if only emotes are allowed; otherwise, **false**. The default is **false**.
        /// </param>
        /// <param name="followerMode">
        /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster restricts the chat room to followers only; otherwise, **false**. The default is **true**.  <br/>
        ///   <br/>
        /// To specify how long users must follow the broadcaster before being able to participate in the chat room, see the `follower_mode_duration` field.
        /// </param>
        /// <param name="followerModeDuration">
        /// The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Set only if `follower_mode` is **true**. Possible values are: 0 (no restriction) through 129600 (3 months). The default is 0.
        /// </param>
        /// <param name="nonModeratorChatDelay">
        /// A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster applies a delay; otherwise, **false**. The default is **false**.  <br/>
        ///   <br/>
        /// To specify the length of the delay, see the `non_moderator_chat_delay_duration` field.
        /// </param>
        /// <param name="nonModeratorChatDelayDuration">
        /// The amount of time, in seconds, that messages are delayed before appearing in chat. Set only if `non_moderator_chat_delay` is **true**. Possible values are:  <br/>
        ///   <br/>
        /// * 2 — 2 second delay (recommended)<br/>
        /// * 4 — 4 second delay<br/>
        /// * 6 — 6 second delay
        /// </param>
        /// <param name="slowMode">
        /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages. Set to **true** if the broadcaster applies a wait period between messages; otherwise, **false**. The default is **false**.  <br/>
        ///   <br/>
        /// To specify the delay, see the `slow_mode_wait_time` field.
        /// </param>
        /// <param name="slowModeWaitTime">
        /// The amount of time, in seconds, that users must wait between sending messages. Set only if `slow_mode` is **true**.  <br/>
        ///   <br/>
        /// Possible values are: 3 (3 second delay) through 120 (2 minute delay). The default is 30 seconds.
        /// </param>
        /// <param name="subscriberMode">
        /// A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster restricts the chat room to subscribers only; otherwise, **false**. The default is **false**.
        /// </param>
        /// <param name="uniqueChatMode">
        /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.  <br/>
        ///   <br/>
        /// Set to **true** if the broadcaster allows only unique messages; otherwise, **false**. The default is **false**.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateChatSettingsResponse> UpdateChatSettingsAsync(
            string broadcasterId,
            string moderatorId,
            bool? emoteMode = default,
            bool? followerMode = default,
            int? followerModeDuration = default,
            bool? nonModeratorChatDelay = default,
            int? nonModeratorChatDelayDuration = default,
            bool? slowMode = default,
            int? slowModeWaitTime = default,
            bool? subscriberMode = default,
            bool? uniqueChatMode = default,
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