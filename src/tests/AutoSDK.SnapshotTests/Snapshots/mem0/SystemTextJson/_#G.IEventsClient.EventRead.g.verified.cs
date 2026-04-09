//HintName: G.IEventsClient.EventRead.g.cs
#nullable enable

namespace G
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Retrieve details of a specific event by its ID.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EventReadResponse> EventReadAsync(
            global::System.Guid eventId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}