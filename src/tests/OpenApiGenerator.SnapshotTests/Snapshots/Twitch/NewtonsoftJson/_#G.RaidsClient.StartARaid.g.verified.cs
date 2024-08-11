//HintName: G.RaidsClient.StartARaid.g.cs

#nullable enable

namespace G
{
    public partial class RaidsClient
    {
        partial void PrepareStartARaidArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? fromBroadcasterId,
            ref string? toBroadcasterId);
        partial void PrepareStartARaidRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? fromBroadcasterId,
            string? toBroadcasterId);
        partial void ProcessStartARaidResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartARaidResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Raid another channel by sending the broadcaster’s viewers to the targeted channel.<br/>
        /// Raid another channel by sending the broadcaster’s viewers to the targeted channel.<br/>
        /// When you call the API from a chat bot or extension, the Twitch UX pops up a window at the top of the chat room that identifies the number of viewers in the raid. The raid occurs when the broadcaster clicks **Raid Now** or after the 90-second countdown expires.<br/>
        /// To determine whether the raid successfully occurred, you must subscribe to the [Channel Raid](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelraid) event. For more information, see [Get notified when a raid begins](https://dev.twitch.tv/docs/api/raids#get-notified-when-a-raid-begins).<br/>
        /// To cancel a pending raid, use the [Cancel a raid](https://dev.twitch.tv/docs/api/reference#cancel-a-raid) endpoint.<br/>
        /// **Rate Limit**: The limit is 10 requests within a 10-minute window.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:raids** scope.
        /// </summary>
        /// <param name="fromBroadcasterId"></param>
        /// <param name="toBroadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StartRaidResponse> StartARaidAsync(
            string? fromBroadcasterId,
            string? toBroadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareStartARaidArguments(
                httpClient: _httpClient,
                fromBroadcasterId: ref fromBroadcasterId,
                toBroadcasterId: ref toBroadcasterId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/raids?from_broadcaster_id={fromBroadcasterId}&to_broadcaster_id={toBroadcasterId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStartARaidRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                fromBroadcasterId: fromBroadcasterId,
                toBroadcasterId: toBroadcasterId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessStartARaidResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStartARaidResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.StartRaidResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}