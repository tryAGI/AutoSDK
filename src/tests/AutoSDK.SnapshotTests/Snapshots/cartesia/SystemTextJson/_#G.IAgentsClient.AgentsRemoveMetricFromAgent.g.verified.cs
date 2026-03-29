//HintName: G.IAgentsClient.AgentsRemoveMetricFromAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Remove Metric from Agent<br/>
        /// Remove a metric from an agent. Once the metric is removed, it will no longer be run on all calls made to the agent automatically from that point onwards. Existing metric results will remain.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="metricId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AgentsRemoveMetricFromAgentAsync(
            global::G.AgentsRemoveMetricFromAgentCartesiaVersion cartesiaVersion,
            string agentId,
            string metricId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}