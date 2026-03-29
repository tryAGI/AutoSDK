//HintName: G.IServerlessClient.ServerlessGetMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Metrics<br/>
        /// Returns Prometheus-compatible metrics in text format for integration into your<br/>
        /// observability stack<br/>
        /// **Authentication:** Required - Uses API key authentication<br/>
        /// **Format:** Returns text/plain in Prometheus exposition format<br/>
        /// **Common Use Cases:**<br/>
        /// - Export app stats to your observability provider (grafana, datadog etc)<br/>
        /// - Track runner health and performance<br/>
        /// - Set up alerts and monitoring<br/>
        /// See [Prometheus documentation](https://prometheus.io/docs/instrumenting/exposition_formats/) for format details.<br/>
        ///     
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ServerlessGetMetricsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}