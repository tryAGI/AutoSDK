//HintName: G.EventSubClient.GetEventsubSubscriptions.g.cs

#nullable enable

namespace G
{
    public partial class EventSubClient
    {
        /// <summary>
        /// Gets a list of EventSub subscriptions that the client in the access token created.<br/>
        /// Gets a list of EventSub subscriptions that the client in the access token created.<br/>
        /// __Authorization:__<br/>
        /// If you use [Webhooks](https://dev.twitch.tv/docs/eventsub/handling-webhook-events) or [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.<br/>
        /// If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. The token may include any scopes.<br/>
        /// __Request Query Parameters:__<br/>
        /// Use the _status_, _type_, and _user\_id_ query parameters to filter the list of subscriptions that are returned. The filters are mutually exclusive; the request fails if you specify more than one filter.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetEventSubSubscriptionsResponse> GetEventsubSubscriptionsAsync(
            global::G.GetEventsubSubscriptionsStatus status,
            global::G.GetEventsubSubscriptionsType type,
            string userId,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/eventsub/subscriptions?status={status}&type={type}&user_id={userId}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetEventSubSubscriptionsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}