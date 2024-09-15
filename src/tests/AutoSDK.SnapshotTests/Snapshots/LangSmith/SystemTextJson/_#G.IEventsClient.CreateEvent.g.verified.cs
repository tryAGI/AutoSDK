//HintName: G.IEventsClient.CreateEvent.g.cs
#nullable enable

namespace G
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Create Event
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEventApiV1EventsPostResponse> CreateEventAsync(
            global::G.CreateEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Event
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEventApiV1EventsPostResponse> CreateEventAsync(
            global::G.CreateEventRequestEventType eventType,
            string owner,
            string repo,
            global::G.AnyOf<string, object>? commit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}