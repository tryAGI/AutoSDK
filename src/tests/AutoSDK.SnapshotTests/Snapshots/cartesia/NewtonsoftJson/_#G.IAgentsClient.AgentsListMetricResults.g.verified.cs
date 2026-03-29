//HintName: G.IAgentsClient.AgentsListMetricResults.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Metric Results<br/>
        /// Paginated list of metric results. Filter results using the query parameters,
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="metricId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="callId"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListMetricResultsResponse> AgentsListMetricResultsAsync(
            global::G.AgentsListMetricResultsCartesiaVersion cartesiaVersion,
            string? agentId = default,
            string? deploymentId = default,
            string? metricId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? callId = default,
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}