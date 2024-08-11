//HintName: G.StreamsClient.GetStreamMarkers.g.cs

#nullable enable

namespace G
{
    public partial class StreamsClient
    {
        partial void PrepareGetStreamMarkersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? userId,
            ref string? videoId,
            ref string? first,
            ref string? before,
            ref string? after);
        partial void PrepareGetStreamMarkersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? userId,
            string? videoId,
            string? first,
            string? before,
            string? after);
        partial void ProcessGetStreamMarkersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetStreamMarkersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of markers from the user’s most recent stream or from the specified VOD/video.<br/>
        /// Gets a list of markers from the user’s most recent stream or from the specified VOD/video. A marker is an arbitrary point in a live stream that the broadcaster or editor marked, so they can return to that spot later to create video highlights (see Video Producer, Highlights in the Twitch UX).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:broadcast** or **channel:manage:broadcast** scope.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="videoId"></param>
        /// <param name="first"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetStreamMarkersResponse> GetStreamMarkersAsync(
            string? userId,
            string? videoId,
            string? first,
            string? before,
            string? after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetStreamMarkersArguments(
                httpClient: _httpClient,
                userId: ref userId,
                videoId: ref videoId,
                first: ref first,
                before: ref before,
                after: ref after);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/streams/markers?user_id={userId}&video_id={videoId}&first={first}&before={before}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetStreamMarkersRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId,
                videoId: videoId,
                first: first,
                before: before,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetStreamMarkersResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetStreamMarkersResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetStreamMarkersResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}