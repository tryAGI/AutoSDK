//HintName: G.IMetadataClient.MetadataSendTelemetry.g.cs
#nullable enable

namespace G
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Send telemetry event<br/>
        /// Send telemetry events for usage tracking and analysis.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataSendTelemetryResponse> MetadataSendTelemetryAsync(

            global::G.MetadataSendTelemetryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send telemetry event<br/>
        /// Send telemetry events for usage tracking and analysis.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="events"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataSendTelemetryResponse> MetadataSendTelemetryAsync(
            global::System.Collections.Generic.IList<global::G.EventsItem> events,
            global::G.MetadataSendTelemetryRequestService service = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}