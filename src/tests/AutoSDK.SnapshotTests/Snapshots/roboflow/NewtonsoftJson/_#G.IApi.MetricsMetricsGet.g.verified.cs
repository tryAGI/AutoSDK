//HintName: G.IApi.MetricsMetricsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Metrics<br/>
        /// Endpoint that serves Prometheus metrics.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetricsMetricsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}