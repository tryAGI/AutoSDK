//HintName: G.ScheduleClient.GetChannelStreamSchedule.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        /// <summary>
        /// Gets the broadcaster’s streaming schedule.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <param name="utcOffset"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetChannelStreamScheduleResponse> GetChannelStreamScheduleAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string> id,
            global::System.DateTime startTime,
            string utcOffset,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/schedule?broadcaster_id={broadcasterId}&{string.Join("&", id.Select(static x => $"id={x}"))}&start_time={startTime}&utc_offset={utcOffset}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetChannelStreamScheduleResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}