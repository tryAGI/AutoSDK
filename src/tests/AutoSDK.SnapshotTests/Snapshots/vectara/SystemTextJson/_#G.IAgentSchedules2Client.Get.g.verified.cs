//HintName: G.IAgentSchedules2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSchedules2Client
    {
        /// <summary>
        /// Get agent schedule<br/>
        /// Retrieve the full details of a specific agent schedule using its unique schedule key. The response includes the schedule's configuration, execution history, and timestamps.
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
        global::System.Threading.Tasks.Task<global::G.AgentSchedule> GetAsync(
            string agentKey,
            string scheduleKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}