//HintName: G.IAgentsClient.AgentsCreateMetric.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create Metric<br/>
        /// Create a new metric.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Metric> AgentsCreateMetricAsync(
            global::G.AgentsCreateMetricCartesiaVersion cartesiaVersion,

            global::G.CreateMetricRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Metric<br/>
        /// Create a new metric.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="name">
        /// The name of the metric. This must be a unique name that only allows lower case letters, numbers, and the characters _, -, and .
        /// </param>
        /// <param name="displayName">
        /// The display name of the metric.
        /// </param>
        /// <param name="prompt">
        /// The prompt associated with the metric, detailing the task and evaluation criteria.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Metric> AgentsCreateMetricAsync(
            global::G.AgentsCreateMetricCartesiaVersion cartesiaVersion,
            string name,
            string prompt,
            string? displayName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}