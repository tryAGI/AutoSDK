//HintName: G.IServiceClient.Telemetry.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Collect telemetry data<br/>
        /// Collect telemetry data including app info, system info, collections info, cluster info, configs and statistics
        /// </summary>
        /// <param name="anonymize"></param>
        /// <param name="detailsLevel"></param>
        /// <param name="perCollection"></param>
        /// <param name="timeout">
        /// Default Value: 60
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TelemetryResponse> TelemetryAsync(
            bool? anonymize = default,
            int? detailsLevel = default,
            bool? perCollection = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}