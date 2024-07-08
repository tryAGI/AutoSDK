//HintName: G.EventSubClient.DeleteEventsubSubscription.g.cs

#nullable enable

namespace G
{
    public partial class EventSubClient
    {
        partial void PrepareDeleteEventsubSubscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id);
        partial void PrepareDeleteEventsubSubscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id);
        partial void ProcessDeleteEventsubSubscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        public async global::System.Threading.Tasks.Task DeleteEventsubSubscriptionAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteEventsubSubscriptionArguments(
                httpClient: _httpClient,
                id: ref id);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/eventsub/subscriptions?id={id}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteEventsubSubscriptionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteEventsubSubscriptionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}