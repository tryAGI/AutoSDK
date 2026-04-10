//HintName: G.ILogsClient.PostProjectLogsIdFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Feedback for project logs events<br/>
        /// Log feedback for a set of project logs events
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackResponseSchema> PostProjectLogsIdFeedbackAsync(
            global::System.Guid projectId,

            global::G.FeedbackProjectLogsEventRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback for project logs events<br/>
        /// Log feedback for a set of project logs events
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="feedback">
        /// A list of project logs feedback items
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackResponseSchema> PostProjectLogsIdFeedbackAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.FeedbackProjectLogsItem> feedback,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}