//HintName: G.ScheduleClient.CreateChannelStreamScheduleSegment.g.cs

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        partial void PrepareCreateChannelStreamScheduleSegmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::G.CreateChannelStreamScheduleSegmentBody request);
        partial void PrepareCreateChannelStreamScheduleSegmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::G.CreateChannelStreamScheduleSegmentBody request);
        partial void ProcessCreateChannelStreamScheduleSegmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChannelStreamScheduleSegmentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Adds a single or recurring broadcast to the broadcaster’s streaming schedule.<br/>
        /// Adds a single or recurring broadcast to the broadcaster’s streaming schedule. For information about scheduling broadcasts, see [Stream Schedule](https://help.twitch.tv/s/article/channel-page-setup#Schedule).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChannelStreamScheduleSegmentResponse> CreateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            global::G.CreateChannelStreamScheduleSegmentBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateChannelStreamScheduleSegmentArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/schedule/segment?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateChannelStreamScheduleSegmentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateChannelStreamScheduleSegmentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateChannelStreamScheduleSegmentResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateChannelStreamScheduleSegmentResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Adds a single or recurring broadcast to the broadcaster’s streaming schedule.<br/>
        /// Adds a single or recurring broadcast to the broadcaster’s streaming schedule. For information about scheduling broadcasts, see [Stream Schedule](https://help.twitch.tv/s/article/channel-page-setup#Schedule).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="startTime"></param>
        /// <param name="timezone"></param>
        /// <param name="duration"></param>
        /// <param name="isRecurring"></param>
        /// <param name="categoryId"></param>
        /// <param name="title"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChannelStreamScheduleSegmentResponse> CreateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            global::System.DateTime startTime,
            string timezone,
            string duration,
            bool isRecurring = default,
            string? categoryId = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateChannelStreamScheduleSegmentBody
            {
                StartTime = startTime,
                Timezone = timezone,
                Duration = duration,
                IsRecurring = isRecurring,
                CategoryId = categoryId,
                Title = title,
            };

            return await CreateChannelStreamScheduleSegmentAsync(
                broadcasterId: broadcasterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}