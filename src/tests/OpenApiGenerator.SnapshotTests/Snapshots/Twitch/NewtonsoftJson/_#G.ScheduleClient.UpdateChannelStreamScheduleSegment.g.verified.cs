//HintName: G.ScheduleClient.UpdateChannelStreamScheduleSegment.g.cs

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        /// <summary>
        /// Updates a scheduled broadcast segment.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateChannelStreamScheduleSegmentResponse> UpdateChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            string id,
            UpdateChannelStreamScheduleSegmentBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/schedule/segment?broadcaster_id={broadcasterId}&id={id}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateChannelStreamScheduleSegmentResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Updates a scheduled broadcast segment.
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
        public async global::System.Threading.Tasks.Task<UpdateChannelStreamScheduleSegmentResponse> UpdateChannelStreamScheduleSegmentAsync(
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
            var request = new UpdateChannelStreamScheduleSegmentBody
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