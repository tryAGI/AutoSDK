//HintName: G.SubscriptionsClient.CheckUserSubscription.g.cs

#nullable enable

namespace G
{
    public partial class SubscriptionsClient
    {
        partial void PrepareCheckUserSubscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string userId);
        partial void PrepareCheckUserSubscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string userId);
        partial void ProcessCheckUserSubscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCheckUserSubscriptionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Checks whether the user subscribes to the broadcaster’s channel.<br/>
        /// Checks whether the user subscribes to the broadcaster’s channel.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:subscriptions** scope.<br/>
        /// A Twitch extensions may use an app access token if the broadcaster has granted the **user:read:subscriptions** scope from within the Twitch Extensions manager.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CheckUserSubscriptionResponse> CheckUserSubscriptionAsync(
            string broadcasterId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCheckUserSubscriptionArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                userId: ref userId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/subscriptions/user?broadcaster_id={broadcasterId}&user_id={userId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCheckUserSubscriptionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                userId: userId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCheckUserSubscriptionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCheckUserSubscriptionResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheckUserSubscriptionResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}