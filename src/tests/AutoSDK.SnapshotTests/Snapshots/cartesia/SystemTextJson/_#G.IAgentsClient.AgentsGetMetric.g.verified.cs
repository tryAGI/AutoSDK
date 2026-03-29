//HintName: G.IAgentsClient.AgentsGetMetric.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Metric<br/>
        /// Get a metric by its ID.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="metricId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Metric> AgentsGetMetricAsync(
            global::G.AgentsGetMetricCartesiaVersion cartesiaVersion,
            string metricId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}