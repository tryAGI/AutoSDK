//HintName: G.IEventsClient.EventsList.g.cs
#nullable enable

namespace G
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Retrieve all events for current organization and project.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EventsListResponse> EventsListAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}