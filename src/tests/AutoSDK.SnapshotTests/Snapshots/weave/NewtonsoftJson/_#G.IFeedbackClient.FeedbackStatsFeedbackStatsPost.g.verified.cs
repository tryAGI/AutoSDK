//HintName: G.IFeedbackClient.FeedbackStatsFeedbackStatsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Stats<br/>
        /// Return aggregated feedback statistics over time buckets.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackStatsRes> FeedbackStatsFeedbackStatsPostAsync(

            global::G.FeedbackStatsReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Stats<br/>
        /// Return aggregated feedback statistics over time buckets.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start">
        /// Inclusive start time (UTC, ISO 8601).
        /// </param>
        /// <param name="end">
        /// Exclusive end time (UTC, ISO 8601). Defaults to now if omitted.
        /// </param>
        /// <param name="feedbackType">
        /// Filter by feedback_type.
        /// </param>
        /// <param name="triggerRef">
        /// Filter by trigger_ref (exact or prefix match for all-versions).
        /// </param>
        /// <param name="granularity">
        /// Bucket size in seconds. If omitted, auto-selected based on time range.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone for bucket alignment.<br/>
        /// Default Value: UTC
        /// </param>
        /// <param name="metrics">
        /// Metrics to aggregate from payload_dump.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackStatsRes> FeedbackStatsFeedbackStatsPostAsync(
            string projectId,
            global::System.DateTime start,
            global::System.DateTime? end = default,
            string? feedbackType = default,
            string? triggerRef = default,
            int? granularity = default,
            string? timezone = default,
            global::System.Collections.Generic.IList<global::G.FeedbackMetricSpec>? metrics = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}