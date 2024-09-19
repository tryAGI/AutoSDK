//HintName: G.ScheduleClient.GetChannelIcalendar.g.cs

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        partial void PrepareGetChannelIcalendarArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId);
        partial void PrepareGetChannelIcalendarRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId);
        partial void ProcessGetChannelIcalendarResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Gets the broadcaster’s streaming schedule as an iCalendar.<br/>
        /// Gets the broadcaster’s streaming schedule as an [iCalendar](https://datatracker.ietf.org/doc/html/rfc5545).<br/>
        /// __Authorization:__<br/>
        /// The Client-Id and Authorization headers are not required.<br/>
        /// __Response Body:__<br/>
        /// The response body contains the iCalendar data (see [RFC5545](https://datatracker.ietf.org/doc/html/rfc5545)).<br/>
        /// The Content-Type response header is set to `text/calendar`.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task GetChannelIcalendarAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetChannelIcalendarArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId);

            var __pathBuilder = new PathBuilder(
                path: "/schedule/icalendar",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetChannelIcalendarRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetChannelIcalendarResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}