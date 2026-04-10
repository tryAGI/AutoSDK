//HintName: G.ILogsClient.PostProjectLogsIdInsert.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Insert project logs events<br/>
        /// Insert a set of events into the project logs
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsertEventsResponse> PostProjectLogsIdInsertAsync(
            global::System.Guid projectId,

            global::G.InsertProjectLogsEventRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert project logs events<br/>
        /// Insert a set of events into the project logs
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="events">
        /// A list of project logs events to insert
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsertEventsResponse> PostProjectLogsIdInsertAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.InsertProjectLogsEvent> events,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}