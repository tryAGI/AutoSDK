//HintName: G.IFeedbackClient.FeedbackPayloadSchemaFeedbackPayloadSchemaPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Payload Schema<br/>
        /// Discover feedback payload schema (paths and types) from sample rows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackPayloadSchemaRes> FeedbackPayloadSchemaFeedbackPayloadSchemaPostAsync(

            global::G.FeedbackPayloadSchemaReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Payload Schema<br/>
        /// Discover feedback payload schema (paths and types) from sample rows.
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
        /// <param name="sampleLimit">
        /// Max distinct trigger_refs to sample when discovering the payload schema. Each distinct trigger_ref (monitor/source) typically has a fixed payload structure, so sampling one payload per ref is usually enough to see the full schema. 2 000 covers virtually all real-world projects while keeping the query fast; the hard cap of 5 000 prevents runaway scans.<br/>
        /// Default Value: 2000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackPayloadSchemaRes> FeedbackPayloadSchemaFeedbackPayloadSchemaPostAsync(
            string projectId,
            global::System.DateTime start,
            global::System.DateTime? end = default,
            string? feedbackType = default,
            string? triggerRef = default,
            int? sampleLimit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}