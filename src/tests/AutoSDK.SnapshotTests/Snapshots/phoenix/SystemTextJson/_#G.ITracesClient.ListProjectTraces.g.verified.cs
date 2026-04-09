//HintName: G.ITracesClient.ListProjectTraces.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// List traces for a project
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="startTime">
        /// Inclusive lower bound on trace start time (ISO 8601)
        /// </param>
        /// <param name="endTime">
        /// Exclusive upper bound on trace start time (ISO 8601)
        /// </param>
        /// <param name="sort">
        /// Sort field<br/>
        /// Default Value: start_time
        /// </param>
        /// <param name="order">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit">
        /// Maximum number of traces to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor (Trace GlobalID)
        /// </param>
        /// <param name="includeSpans">
        /// If true, include full span details for each trace. This significantly increases response size and query latency, especially with large page sizes. Prefer fetching spans lazily for individual traces when possible.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sessionIdentifier">
        /// List of session identifiers to filter traces by. Each value can be either a session_id string or a session GlobalID. Only traces belonging to the specified sessions will be returned.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTracesResponseBody> ListProjectTracesAsync(
            string projectIdentifier,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::G.ListProjectTracesSort? sort = default,
            global::G.ListProjectTracesOrder? order = default,
            int? limit = default,
            string? cursor = default,
            bool? includeSpans = default,
            global::System.Collections.Generic.IList<string>? sessionIdentifier = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}