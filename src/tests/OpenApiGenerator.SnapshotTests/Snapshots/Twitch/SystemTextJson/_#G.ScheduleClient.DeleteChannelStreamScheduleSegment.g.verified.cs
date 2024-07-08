//HintName: G.ScheduleClient.DeleteChannelStreamScheduleSegment.g.cs

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        partial void PrepareDeleteChannelStreamScheduleSegmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string id);
        partial void PrepareDeleteChannelStreamScheduleSegmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string id);
        partial void ProcessDeleteChannelStreamScheduleSegmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Deletes a broadcast from the broadcaster’s streaming schedule.<br/>
        /// Removes a broadcast segment from the broadcaster’s streaming schedule.<br/>
        /// **NOTE**: For recurring segments, removing a segment removes all segments in the recurring schedule.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DeleteChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteChannelStreamScheduleSegmentArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                id: ref id);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/schedule/segment?broadcaster_id={broadcasterId}&id={id}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteChannelStreamScheduleSegmentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                id: id);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteChannelStreamScheduleSegmentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}