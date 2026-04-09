//HintName: G.IAgentSchedulesClient.ListExecutions.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSchedulesClient
    {
        /// <summary>
        /// List agent schedule executions<br/>
        /// List all execution attempts for a schedule, ordered by most recent first.
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
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListAgentScheduleExecutionsResponse> ListExecutionsAsync(
            string agentKey,
            string scheduleKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}