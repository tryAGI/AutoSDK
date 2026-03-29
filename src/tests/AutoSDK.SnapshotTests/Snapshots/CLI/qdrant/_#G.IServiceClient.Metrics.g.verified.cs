//HintName: G.IServiceClient.Metrics.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Collect Prometheus metrics data<br/>
        /// Collect metrics data including app info, collections info, cluster info and statistics
        /// </summary>
        /// <param name="anonymize"></param>
        /// <param name="perCollection"></param>
        /// <param name="timeout">
        /// Default Value: 60
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetricsAsync(
            bool? anonymize = default,
            bool? perCollection = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}