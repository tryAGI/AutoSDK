//HintName: G.IAgentSchedules2Client.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSchedules2Client
    {
        /// <summary>
        /// Update agent schedule<br/>
        /// Update an existing agent schedule. All fields are optional - only provided fields will be updated (PATCH semantics).<br/>
        /// You can pause/resume a schedule by setting the `enabled` field to `false`/`true`. Updating the schedule configuration (interval or cron) will reschedule future executions but will not affect executions currently in progress.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="scheduleKey">
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSchedule> UpdateAsync(
            string agentKey,
            string scheduleKey,

            global::G.UpdateAgentScheduleRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent schedule<br/>
        /// Update an existing agent schedule. All fields are optional - only provided fields will be updated (PATCH semantics).<br/>
        /// You can pause/resume a schedule by setting the `enabled` field to `false`/`true`. Updating the schedule configuration (interval or cron) will reschedule future executions but will not affect executions currently in progress.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="scheduleKey">
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </param>
        /// <param name="description">
        /// Updated description of the schedule's purpose.
        /// </param>
        /// <param name="message">
        /// Updated input message to send to the agent on each scheduled execution.
        /// </param>
        /// <param name="schedule">
        /// Configuration for when and how often the schedule should execute.
        /// </param>
        /// <param name="enabled">
        /// Updated enabled status for the schedule.
        /// </param>
        /// <param name="sessionMetadata">
        /// Updated metadata to include in each session created by this schedule.
        /// </param>
        /// <param name="maxExecutionsToKeep">
        /// Updated maximum number of past execution records to keep.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSchedule> UpdateAsync(
            string agentKey,
            string scheduleKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.AgentInput>? message = default,
            global::G.ScheduleConfiguration? schedule = default,
            bool? enabled = default,
            object? sessionMetadata = default,
            int? maxExecutionsToKeep = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}