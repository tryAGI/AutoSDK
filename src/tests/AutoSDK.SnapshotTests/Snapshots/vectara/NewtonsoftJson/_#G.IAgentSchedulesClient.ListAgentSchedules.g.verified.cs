//HintName: G.IAgentSchedulesClient.ListAgentSchedules.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSchedulesClient
    {

        /// <summary>
        /// List agent schedules<br/>
        /// List all schedules for the specified agent. This endpoint returns high-level information about each schedule including execution status and next scheduled execution time.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListAgentSchedulesResponse> ListAgentSchedulesAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}