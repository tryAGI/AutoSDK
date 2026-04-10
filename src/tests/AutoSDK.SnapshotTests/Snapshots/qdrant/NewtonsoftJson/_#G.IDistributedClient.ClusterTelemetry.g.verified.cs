//HintName: G.IDistributedClient.ClusterTelemetry.g.cs
#nullable enable

namespace G
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Collect cluster telemetry data<br/>
        /// Get telemetry data, from the point of view of the cluster. This includes peers info, collections info, shard transfers, and resharding status
        /// </summary>
        /// <param name="detailsLevel"></param>
        /// <param name="timeout">
        /// Default Value: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClusterTelemetryResponse> ClusterTelemetryAsync(
            int? detailsLevel = default,
            int? timeout = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}