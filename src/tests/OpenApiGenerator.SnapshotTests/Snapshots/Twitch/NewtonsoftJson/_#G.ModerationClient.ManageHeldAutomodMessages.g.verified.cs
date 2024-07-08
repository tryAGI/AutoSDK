//HintName: G.ModerationClient.ManageHeldAutomodMessages.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        partial void PrepareManageHeldAutomodMessagesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ManageHeldAutoModMessagesBody request);
        partial void PrepareManageHeldAutomodMessagesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ManageHeldAutoModMessagesBody request);
        partial void ProcessManageHeldAutomodMessagesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Allow or deny the message that AutoMod flagged for review.<br/>
        /// Allow or deny the message that AutoMod flagged for review. For information about AutoMod, see [How to Use AutoMod](https://help.twitch.tv/s/article/how-to-use-automod).<br/>
        /// To get messages that AutoMod is holding for review, subscribe to the **automod-queue.&lt;moderator\_id&gt;.&lt;channel\_id&gt;** [topic](https://dev.twitch.tv/docs/pubsub#topics) using [PubSub](https://dev.twitch.tv/docs/pubsub). PubSub sends a notification to your app when AutoMod holds a message for review.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:automod** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ManageHeldAutomodMessagesAsync(
            global::G.ManageHeldAutoModMessagesBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareManageHeldAutomodMessagesArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/moderation/automod/message", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareManageHeldAutomodMessagesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessManageHeldAutomodMessagesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Allow or deny the message that AutoMod flagged for review.<br/>
        /// Allow or deny the message that AutoMod flagged for review. For information about AutoMod, see [How to Use AutoMod](https://help.twitch.tv/s/article/how-to-use-automod).<br/>
        /// To get messages that AutoMod is holding for review, subscribe to the **automod-queue.&lt;moderator\_id&gt;.&lt;channel\_id&gt;** [topic](https://dev.twitch.tv/docs/pubsub#topics) using [PubSub](https://dev.twitch.tv/docs/pubsub). PubSub sends a notification to your app when AutoMod holds a message for review.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:automod** scope.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="msgId"></param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ManageHeldAutomodMessagesAsync(
            string userId,
            string msgId,
            global::G.ManageHeldAutoModMessagesBodyAction action,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ManageHeldAutoModMessagesBody
            {
                UserId = userId,
                MsgId = msgId,
                Action = action,
            };

            await ManageHeldAutomodMessagesAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}