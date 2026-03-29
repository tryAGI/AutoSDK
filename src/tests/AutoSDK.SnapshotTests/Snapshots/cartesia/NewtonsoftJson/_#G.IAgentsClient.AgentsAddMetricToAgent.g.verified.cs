//HintName: G.IAgentsClient.AgentsAddMetricToAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Add Metric to Agent<br/>
        /// Add a metric to an agent. Once the metric is added, it will be run on all calls made to the agent automatically from that point onwards.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="metricId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AgentsAddMetricToAgentAsync(
            global::G.AgentsAddMetricToAgentCartesiaVersion cartesiaVersion,
            string agentId,
            string metricId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}