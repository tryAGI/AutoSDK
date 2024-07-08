//HintName: G.ScheduleClient.UpdateChannelStreamScheduleSegment.g.cs

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        partial void PrepareUpdateChannelStreamScheduleSegmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string id,
            global::G.UpdateChannelStreamScheduleSegmentBody request);
        partial void PrepareUpdateChannelStreamScheduleSegmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string id,
            global::G.UpdateChannelStreamScheduleSegmentBody request);
        partial void ProcessUpdateChannelStreamScheduleSegmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateChannelStreamScheduleSegmentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a scheduled broadcast segment.<br/>
        /// Updates a scheduled broadcast segment.<br/>
        /// For recurring segments, updating a segment’s title, category, duration, and timezone, changes all segments in the recurring schedule, not just the specified segment.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateChannelStreamScheduleSegmentResponse> UpdateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            string id,
            global::G.UpdateChannelStreamScheduleSegmentBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateChannelStreamScheduleSegmentArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                id: ref id,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/schedule/segment?broadcaster_id={broadcasterId}&id={id}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateChannelStreamScheduleSegmentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                id: id,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateChannelStreamScheduleSegmentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateChannelStreamScheduleSegmentResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateChannelStreamScheduleSegmentResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Updates a scheduled broadcast segment.<br/>
        /// Updates a scheduled broadcast segment.<br/>
        /// For recurring segments, updating a segment’s title, category, duration, and timezone, changes all segments in the recurring schedule, not just the specified segment.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <param name="duration"></param>
        /// <param name="categoryId"></param>
        /// <param name="title"></param>
        /// <param name="isCanceled"></param>
        /// <param name="timezone"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateChannelStreamScheduleSegmentResponse> UpdateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            string id,
            global::System.DateTime startTime = default,
            string? duration = default,
            string? categoryId = default,
            string? title = default,
            bool isCanceled = default,
            string? timezone = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateChannelStreamScheduleSegmentBody
            {
                StartTime = startTime,
                Duration = duration,
                CategoryId = categoryId,
                Title = title,
                IsCanceled = isCanceled,
                Timezone = timezone,
            };

            return await UpdateChannelStreamScheduleSegmentAsync(
                broadcasterId: broadcasterId,
                id: id,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}