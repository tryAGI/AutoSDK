//HintName: G.IStepsClient.ListSteps.g.cs
#nullable enable

namespace G
{
    public partial interface IStepsClient
    {
        /// <summary>
        /// List Steps<br/>
        /// List steps with optional pagination and date filters.
        /// </summary>
        /// <param name="before">
        /// Return steps before this step ID
        /// </param>
        /// <param name="after">
        /// Return steps after this step ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of steps to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for steps by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="startDate">
        /// Return steps after this ISO datetime (e.g. "2025-01-29T15:01:19-08:00")
        /// </param>
        /// <param name="endDate">
        /// Return steps before this ISO datetime (e.g. "2025-01-29T15:01:19-08:00")
        /// </param>
        /// <param name="model">
        /// Filter by the name of the model used for the step
        /// </param>
        /// <param name="agentId">
        /// Filter by the ID of the agent that performed the step
        /// </param>
        /// <param name="traceIds">
        /// Filter by trace ids returned by the server
        /// </param>
        /// <param name="feedback">
        /// Filter by feedback
        /// </param>
        /// <param name="hasFeedback">
        /// Filter by whether steps have feedback (true) or not (false)
        /// </param>
        /// <param name="tags">
        /// Filter by tags
        /// </param>
        /// <param name="projectId">
        /// Filter by the project ID that is associated with the step (cloud only).
        /// </param>
        /// <param name="xProject">
        /// Filter by project slug to associate with the group (cloud only).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Step>> ListStepsAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListStepsOrder? order = default,
            string? orderBy = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? traceIds = default,
            global::G.ListStepsFeedback2? feedback = default,
            bool? hasFeedback = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? projectId = default,
            string? xProject = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}