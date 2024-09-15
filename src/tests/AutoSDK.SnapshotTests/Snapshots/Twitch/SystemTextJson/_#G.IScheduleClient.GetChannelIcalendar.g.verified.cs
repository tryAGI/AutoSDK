//HintName: G.IScheduleClient.GetChannelIcalendar.g.cs
#nullable enable

namespace G
{
    public partial interface IScheduleClient
    {
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
        global::System.Threading.Tasks.Task GetChannelIcalendarAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}