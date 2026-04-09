//HintName: G.IBetaClient.ListSplitJobsApiV1BetaSplitJobsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Split Jobs<br/>
        /// List document split jobs.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="status">
        /// Filter by job status (pending, processing, completed, failed, cancelled)
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="createdAtOnOrAfter">
        /// Include jobs created at or after this timestamp (inclusive)
        /// </param>
        /// <param name="createdAtOnOrBefore">
        /// Include jobs created at or before this timestamp (inclusive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SplitJobQueryResponse> ListSplitJobsApiV1BetaSplitJobsGetAsync(
            global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2? status = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}