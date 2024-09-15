//HintName: G.IEventSubClient.DeleteEventsubSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface IEventSubClient
    {
        /// <summary>
        /// Deletes an EventSub subscription.<br/>
        /// Deletes an EventSub subscription.<br/>
        /// __Authorization:__<br/>
        /// If you use [webhooks to receive events](https://dev.twitch.tv/docs/eventsub/handling-webhook-events), the request must specify an app access token. The request will fail if you use a user access token.<br/>
        /// If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. The token may include any scopes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteEventsubSubscriptionAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}