//HintName: G.IAgentSchedulesClient.CreateAgentSchedule.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSchedulesClient
    {
        /// <summary>
        /// Create agent schedule<br/>
        /// Create a new schedule for automatically executing an agent at specified intervals. Each execution creates a new session with the configured message and metadata.<br/>
        /// Schedules enable automated agent workflows such as daily reports, periodic monitoring, or regular data processing. The schedule will create sessions tagged with metadata to identify them as scheduled executions.<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/schedules \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \c<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "daily-report",<br/>
        ///   "name": "Daily Summary Report",<br/>
        ///   "message": [{"type": "text", "content": "Generate a summary of today's activities"}],<br/>
        ///   "schedule": {<br/>
        ///     "type": "interval",<br/>
        ///     "interval": "PT24H"<br/>
        ///   },<br/>
        ///   "session_metadata": {<br/>
        ///     "report_type": "daily"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique schedule key, configuration, and creation timestamp.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSchedule> CreateAgentScheduleAsync(
            string agentKey,

            global::G.CreateAgentScheduleRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create agent schedule<br/>
        /// Create a new schedule for automatically executing an agent at specified intervals. Each execution creates a new session with the configured message and metadata.<br/>
        /// Schedules enable automated agent workflows such as daily reports, periodic monitoring, or regular data processing. The schedule will create sessions tagged with metadata to identify them as scheduled executions.<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/schedules \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \c<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "daily-report",<br/>
        ///   "name": "Daily Summary Report",<br/>
        ///   "message": [{"type": "text", "content": "Generate a summary of today's activities"}],<br/>
        ///   "schedule": {<br/>
        ///     "type": "interval",<br/>
        ///     "interval": "PT24H"<br/>
        ///   },<br/>
        ///   "session_metadata": {<br/>
        ///     "report_type": "daily"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique schedule key, configuration, and creation timestamp.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="key">
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </param>
        /// <param name="description">
        /// Optional detailed description of the schedule's purpose.
        /// </param>
        /// <param name="message">
        /// The input message to send to the agent on each scheduled execution.
        /// </param>
        /// <param name="schedule">
        /// Configuration for when and how often the schedule should execute.
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule should be active upon creation.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sessionMetadata">
        /// Arbitrary metadata to include in each session created by this schedule.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="maxExecutionsToKeep">
        /// Maximum number of past execution records to keep. Defaults to 10.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSchedule> CreateAgentScheduleAsync(
            string agentKey,
            string name,
            global::System.Collections.Generic.IList<global::G.AgentInput> message,
            global::G.ScheduleConfiguration schedule,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? description = default,
            bool? enabled = default,
            object? sessionMetadata = default,
            int? maxExecutionsToKeep = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}