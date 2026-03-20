//HintName: G.IAgentSchedulesClient.DeleteAgentSchedule.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSchedulesClient
    {

        /// <summary>
        /// Delete agent schedule<br/>
        /// Delete an agent schedule. This stops all future executions of the schedule.<br/>
        /// Sessions that were previously created by this schedule are not deleted and remain accessible.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentScheduleAsync(
            string agentKey,
            string scheduleKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}