//HintName: G.IEventSubClient.CreateEventsubSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IEventSubClient
    {
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEventSubSubscriptionResponse> CreateEventsubSubscriptionAsync(
            global::G.CreateEventSubSubscriptionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an EventSub subscription.<br/>
        /// Creates an EventSub subscription.<br/>
        /// __Authorization:__<br/>
        /// If you use [webhooks to receive events](https://dev.twitch.tv/docs/eventsub/handling-webhook-events), the request must specify an app access token. The request will fail if you use a user access token. If the subscription type requires user authorization, the user must have granted your app (client ID) permissions to receive those events before you subscribe to them. For example, to subscribe to [channel.subscribe](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsubscribe) events, your app must get a user access token that includes the `channel:read:subscriptions` scope, which adds the required permission to your app access token’s client ID.<br/>
        /// If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. If the subscription type requires user authorization, the token must include the required scope. However, if the subscription type doesn’t include user authorization, the token may include any scopes or no scopes.<br/>
        /// If you use [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.
        /// </summary>
        /// <param name="type">
        /// The type of subscription to create. For a list of subscriptions that you can create, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types). Set this field to the value in the **Name** column of the Subscription Types table.
        /// </param>
        /// <param name="version">
        /// The version number that identifies the definition of the subscription type that you want the response to use.
        /// </param>
        /// <param name="condition">
        /// A JSON object that contains the parameter values that are specific to the specified subscription type. For the object’s required and optional fields, see the subscription type’s documentation.
        /// </param>
        /// <param name="transport">
        /// The transport details that you want Twitch to use when sending you notifications.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEventSubSubscriptionResponse> CreateEventsubSubscriptionAsync(
            global::G.CreateEventSubSubscriptionBodyType type,
            string version,
            object condition,
            global::G.CreateEventSubSubscriptionBodyTransport transport,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}