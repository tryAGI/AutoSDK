//HintName: G.SubscriptionsClient.GetBroadcasterSubscriptions.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class SubscriptionsClient
    {
        partial void PrepareGetBroadcasterSubscriptionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId,
            ref string? first,
            ref string? after,
            ref string? before);
        partial void PrepareGetBroadcasterSubscriptionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId,
            string? first,
            string? after,
            string? before);
        partial void ProcessGetBroadcasterSubscriptionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetBroadcasterSubscriptionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of users that subscribe to the specified broadcaster.<br/>
        /// Gets a list of users that subscribe to the specified broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:subscriptions** scope.<br/>
        /// A Twitch extensions may use an app access token if the broadcaster has granted the **channel:read:subscriptions** scope from within the Twitch Extensions manager.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetBroadcasterSubscriptionsResponse> GetBroadcasterSubscriptionsAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId = default,
            string? first = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetBroadcasterSubscriptionsArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                userId: userId,
                first: ref first,
                after: ref after,
                before: ref before);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/subscriptions?broadcaster_id={broadcasterId}&{string.Join("&", userId?.Select(static x => $"userId={x}") ?? global::System.Array.Empty<string>())}&first={first}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetBroadcasterSubscriptionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                userId: userId,
                first: first,
                after: after,
                before: before);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetBroadcasterSubscriptionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetBroadcasterSubscriptionsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetBroadcasterSubscriptionsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}