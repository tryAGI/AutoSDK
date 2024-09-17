//HintName: G.IPublicClient.ReadSharedDelta.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SessionFeedbackDelta> ReadSharedDeltaAsync(
            global::System.Guid shareToken,
            global::G.QueryFeedbackDelta request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Shared Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="baselineSessionId"></param>
        /// <param name="comparisonSessionIds"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SessionFeedbackDelta> ReadSharedDeltaAsync(
            global::System.Guid shareToken,
            global::System.Guid baselineSessionId,
            global::System.Collections.Generic.IList<global::System.Guid> comparisonSessionIds,
            string feedbackKey,
            global::G.AnyOf<global::G.QueryFeedbackDeltaFilters, object>? filters = default,
            int? offset = 0,
            int? limit = 100,
            global::G.AnyOf<global::System.Guid?, object>? comparativeExperimentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}