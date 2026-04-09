//HintName: G.IBetaClient.ListUsageMetricsApiV1BetaUsageMetricsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Usage Metrics<br/>
        /// List usage metrics with filtering and pagination.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="includeTotal">
        /// Include total count in response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId">
        /// Filter by project ID
        /// </param>
        /// <param name="userId">
        /// Filter by user ID
        /// </param>
        /// <param name="eventTypes">
        /// Filter by event types
        /// </param>
        /// <param name="days">
        /// Filter by specific days (YYYY-MM-DD)
        /// </param>
        /// <param name="dayOnOrBefore">
        /// Filter by days on or before this date (YYYY-MM-DD)
        /// </param>
        /// <param name="dayOnOrAfter">
        /// Filter by days on or after this date (YYYY-MM-DD)
        /// </param>
        /// <param name="eventAggregationType">
        /// Filter by event aggregation type
        /// </param>
        /// <param name="eventAggregationKey">
        /// Filter by event aggregation key
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UsageMetricQueryResponse> ListUsageMetricsApiV1BetaUsageMetricsGetAsync(
            global::System.Guid organizationId,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeTotal = default,
            global::System.Guid? projectId = default,
            string? userId = default,
            global::System.Collections.Generic.IList<string>? eventTypes = default,
            global::System.Collections.Generic.IList<string>? days = default,
            string? dayOnOrBefore = default,
            string? dayOnOrAfter = default,
            string? eventAggregationType = default,
            string? eventAggregationKey = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}