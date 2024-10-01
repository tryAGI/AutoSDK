//HintName: G.ChatClient.SendAShoutout.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareSendAShoutoutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string fromBroadcasterId,
            ref string toBroadcasterId,
            ref string moderatorId);
        partial void PrepareSendAShoutoutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string fromBroadcasterId,
            string toBroadcasterId,
            string moderatorId);
        partial void ProcessSendAShoutoutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Sends a Shoutout to the specified broadcaster.<br/>
        /// Sends a Shoutout to the specified broadcaster. Typically, you send Shoutouts when you or one of your moderators notice another broadcaster in your chat, the other broadcaster is coming up in conversation, or after they raid your broadcast.<br/>
        /// Twitch’s Shoutout feature is a great way for you to show support for other broadcasters and help them grow. Viewers who do not follow the other broadcaster will see a pop-up Follow button in your chat that they can click to follow the other broadcaster. [Learn More](https://help.twitch.tv/s/article/shoutouts)<br/>
        /// **Rate Limits** The broadcaster may send a Shoutout once every 2 minutes. They may send the same broadcaster a Shoutout once every 60 minutes.<br/>
        /// To receive notifications when a Shoutout is sent or received, subscribe to the [channel.shoutout.create](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelshoutoutcreate) and [channel.shoutout.receive](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelshoutoutreceive) subscription types. The **channel.shoutout.create** event includes cooldown periods that indicate when the broadcaster may send another Shoutout without exceeding the endpoint’s rate limit.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:shoutouts** scope.
        /// </summary>
        /// <param name="fromBroadcasterId"></param>
        /// <param name="toBroadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendAShoutoutAsync(
            string fromBroadcasterId,
            string toBroadcasterId,
            string moderatorId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSendAShoutoutArguments(
                httpClient: _httpClient,
                fromBroadcasterId: ref fromBroadcasterId,
                toBroadcasterId: ref toBroadcasterId,
                moderatorId: ref moderatorId);

            var __pathBuilder = new PathBuilder(
                path: "/chat/shoutouts",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("from_broadcaster_id", fromBroadcasterId) 
                .AddRequiredParameter("to_broadcaster_id", toBroadcasterId) 
                .AddRequiredParameter("moderator_id", moderatorId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSendAShoutoutRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                fromBroadcasterId: fromBroadcasterId,
                toBroadcasterId: toBroadcasterId,
                moderatorId: moderatorId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSendAShoutoutResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}