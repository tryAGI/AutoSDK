//HintName: G.EventSubClient.CreateEventsubSubscription.g.cs

#nullable enable

namespace G
{
    public partial class EventSubClient
    {
        partial void PrepareCreateEventsubSubscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateEventSubSubscriptionBody request);
        partial void PrepareCreateEventsubSubscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateEventSubSubscriptionBody request);
        partial void ProcessCreateEventsubSubscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateEventsubSubscriptionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates an EventSub subscription.<br/>
        /// Creates an EventSub subscription.<br/>
        /// __Authorization:__<br/>
        /// If you use [webhooks to receive events](https://dev.twitch.tv/docs/eventsub/handling-webhook-events), the request must specify an app access token. The request will fail if you use a user access token. If the subscription type requires user authorization, the user must have granted your app (client ID) permissions to receive those events before you subscribe to them. For example, to subscribe to [channel.subscribe](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsubscribe) events, your app must get a user access token that includes the `channel:read:subscriptions` scope, which adds the required permission to your app access token’s client ID.<br/>
        /// If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. If the subscription type requires user authorization, the token must include the required scope. However, if the subscription type doesn’t include user authorization, the token may include any scopes or no scopes.<br/>
        /// If you use [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateEventSubSubscriptionResponse> CreateEventsubSubscriptionAsync(
            global::G.CreateEventSubSubscriptionBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateEventsubSubscriptionArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/eventsub/subscriptions", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateEventsubSubscriptionRequest(
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
            ProcessCreateEventsubSubscriptionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateEventsubSubscriptionResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateEventSubSubscriptionResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates an EventSub subscription.<br/>
        /// Creates an EventSub subscription.<br/>
        /// __Authorization:__<br/>
        /// If you use [webhooks to receive events](https://dev.twitch.tv/docs/eventsub/handling-webhook-events), the request must specify an app access token. The request will fail if you use a user access token. If the subscription type requires user authorization, the user must have granted your app (client ID) permissions to receive those events before you subscribe to them. For example, to subscribe to [channel.subscribe](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsubscribe) events, your app must get a user access token that includes the `channel:read:subscriptions` scope, which adds the required permission to your app access token’s client ID.<br/>
        /// If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. If the subscription type requires user authorization, the token must include the required scope. However, if the subscription type doesn’t include user authorization, the token may include any scopes or no scopes.<br/>
        /// If you use [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="version"></param>
        /// <param name="condition"></param>
        /// <param name="transport"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateEventSubSubscriptionResponse> CreateEventsubSubscriptionAsync(
            global::G.CreateEventSubSubscriptionBodyType type,
            string version,
            object condition,
            global::G.CreateEventSubSubscriptionBodyTransport transport,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateEventSubSubscriptionBody
            {
                Type = type,
                Version = version,
                Condition = condition,
                Transport = transport,
            };

            return await CreateEventsubSubscriptionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}