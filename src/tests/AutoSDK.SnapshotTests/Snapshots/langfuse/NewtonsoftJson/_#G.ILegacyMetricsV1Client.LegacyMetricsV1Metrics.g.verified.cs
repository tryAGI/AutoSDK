//HintName: G.ILegacyMetricsV1Client.LegacyMetricsV1Metrics.g.cs
#nullable enable

namespace G
{
    public partial interface ILegacyMetricsV1Client
    {
        /// <summary>
        /// Get metrics from the Langfuse project using a query object.<br/>
        /// Consider using the [v2 metrics endpoint](/api-reference#tag/metricsv2/GET/api/public/v2/metrics) for better performance.<br/>
        /// For more details, see the [Metrics API documentation](https://langfuse.com/docs/metrics/features/metrics-api).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LegacyMetricsResponse> LegacyMetricsV1MetricsAsync(
            string query,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}