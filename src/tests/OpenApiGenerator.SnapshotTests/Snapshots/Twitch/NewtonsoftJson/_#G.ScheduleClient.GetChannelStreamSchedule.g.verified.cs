//HintName: G.ScheduleClient.GetChannelStreamSchedule.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        partial void PrepareGetChannelStreamScheduleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::System.Collections.Generic.IList<string> id,
            global::System.DateTime startTime,
            ref string utcOffset,
            ref int first,
            ref string after);
        partial void PrepareGetChannelStreamScheduleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::System.Collections.Generic.IList<string> id,
            global::System.DateTime startTime,
            string utcOffset,
            int first,
            string after);
        partial void ProcessGetChannelStreamScheduleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetChannelStreamScheduleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the broadcaster’s streaming schedule.<br/>
        /// Gets the broadcaster’s streaming schedule. You can get the entire schedule or specific segments of the schedule. [Learn More](https://help.twitch.tv/s/article/channel-page-setup#Schedule)<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <param name="utcOffset"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetChannelStreamScheduleResponse> GetChannelStreamScheduleAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string> id,
            global::System.DateTime startTime,
            string utcOffset,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetChannelStreamScheduleArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                id: id,
                startTime: startTime,
                utcOffset: ref utcOffset,
                first: ref first,
                after: ref after);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/schedule?broadcaster_id={broadcasterId}&{string.Join("&", id.Select(static x => $"id={x}"))}&start_time={startTime:yyyy-MM-ddTHH:mm:ssZ}&utc_offset={utcOffset}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetChannelStreamScheduleRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                id: id,
                startTime: startTime,
                utcOffset: utcOffset,
                first: first,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetChannelStreamScheduleResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetChannelStreamScheduleResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetChannelStreamScheduleResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}