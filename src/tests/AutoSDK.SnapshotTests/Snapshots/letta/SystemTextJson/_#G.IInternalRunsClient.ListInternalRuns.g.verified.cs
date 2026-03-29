//HintName: G.IInternalRunsClient.ListInternalRuns.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IInternalRunsClient
    {
        /// <summary>
        /// List Runs<br/>
        /// List all runs.
        /// </summary>
        /// <param name="runId">
        /// Filter by a specific run ID.
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent associated with the run.
        /// </param>
        /// <param name="agentIds">
        /// The unique identifiers of the agents associated with the run. Deprecated in favor of agent_id field.
        /// </param>
        /// <param name="statuses">
        /// Filter runs by status. Can specify multiple statuses.
        /// </param>
        /// <param name="background">
        /// If True, filters for runs that were created in background mode.
        /// </param>
        /// <param name="stopReason">
        /// Filter runs by stop reason.
        /// </param>
        /// <param name="templateFamily">
        /// Filter runs by template family (base_template_id).
        /// </param>
        /// <param name="stepCount">
        /// Filter runs by step count. Must be provided with step_count_operator.
        /// </param>
        /// <param name="stepCountOperator">
        /// Operator for step_count filter: 'eq' for equals, 'gte' for greater than or equal, 'lte' for less than or equal.<br/>
        /// Default Value: eq
        /// </param>
        /// <param name="toolsUsed">
        /// Filter runs that used any of the specified tools.
        /// </param>
        /// <param name="before">
        /// Run ID cursor for pagination. Returns runs that come before this run ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Run ID cursor for pagination. Returns runs that come after this run ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of runs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for runs by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="active">
        /// Filter for active runs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ascending">
        /// Whether to sort agents oldest to newest (True) or newest to oldest (False, default). Deprecated in favor of order field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId">
        /// Filter runs by project ID.
        /// </param>
        /// <param name="conversationId">
        /// Filter runs by conversation ID.
        /// </param>
        /// <param name="durationPercentile">
        /// Filter runs by duration percentile (1-100). Returns runs slower than this percentile.
        /// </param>
        /// <param name="durationValue">
        /// Duration value in nanoseconds for filtering. Must be used with duration_operator.
        /// </param>
        /// <param name="durationOperator">
        /// Comparison operator for duration filter: 'gt' (greater than), 'lt' (less than), 'eq' (equals).
        /// </param>
        /// <param name="startDate">
        /// Filter runs created on or after this date (ISO 8601 format).
        /// </param>
        /// <param name="endDate">
        /// Filter runs created on or before this date (ISO 8601 format).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Run>> ListInternalRunsAsync(
            string? runId = default,
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::System.Collections.Generic.IList<string>? statuses = default,
            bool? background = default,
            global::G.StopReasonType? stopReason = default,
            string? templateFamily = default,
            int? stepCount = default,
            global::G.ComparisonOperator? stepCountOperator = default,
            global::System.Collections.Generic.IList<string>? toolsUsed = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListInternalRunsOrder? order = default,
            global::G.ListInternalRunsOrderBy? orderBy = default,
            bool? active = default,
            bool? ascending = default,
            string? projectId = default,
            string? conversationId = default,
            int? durationPercentile = default,
            int? durationValue = default,
            global::G.ListInternalRunsDurationOperator2? durationOperator = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}