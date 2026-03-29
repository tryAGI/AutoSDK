//HintName: G.IOpentelemetryClient.OpentelemetryExportTraces.g.cs
#nullable enable

namespace G
{
    public partial interface IOpentelemetryClient
    {
        /// <summary>
        /// **OpenTelemetry Traces Ingestion Endpoint**<br/>
        /// This endpoint implements the OTLP/HTTP specification for trace ingestion, providing native OpenTelemetry integration for Langfuse Observability.<br/>
        /// **Supported Formats:**<br/>
        /// - Binary Protobuf: `Content-Type: application/x-protobuf`<br/>
        /// - JSON Protobuf: `Content-Type: application/json`<br/>
        /// - Supports gzip compression via `Content-Encoding: gzip` header<br/>
        /// **Specification Compliance:**<br/>
        /// - Conforms to [OTLP/HTTP Trace Export](https://opentelemetry.io/docs/specs/otlp/#otlphttp)<br/>
        /// - Implements `ExportTraceServiceRequest` message format<br/>
        /// **Documentation:**<br/>
        /// - Integration guide: https://langfuse.com/integrations/native/opentelemetry<br/>
        /// - Data model: https://langfuse.com/docs/observability/data-model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OtelTraceResponse> OpentelemetryExportTracesAsync(

            global::G.OpentelemetryExportTracesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// **OpenTelemetry Traces Ingestion Endpoint**<br/>
        /// This endpoint implements the OTLP/HTTP specification for trace ingestion, providing native OpenTelemetry integration for Langfuse Observability.<br/>
        /// **Supported Formats:**<br/>
        /// - Binary Protobuf: `Content-Type: application/x-protobuf`<br/>
        /// - JSON Protobuf: `Content-Type: application/json`<br/>
        /// - Supports gzip compression via `Content-Encoding: gzip` header<br/>
        /// **Specification Compliance:**<br/>
        /// - Conforms to [OTLP/HTTP Trace Export](https://opentelemetry.io/docs/specs/otlp/#otlphttp)<br/>
        /// - Implements `ExportTraceServiceRequest` message format<br/>
        /// **Documentation:**<br/>
        /// - Integration guide: https://langfuse.com/integrations/native/opentelemetry<br/>
        /// - Data model: https://langfuse.com/docs/observability/data-model
        /// </summary>
        /// <param name="resourceSpans">
        /// Array of resource spans containing trace data as defined in the OTLP specification
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OtelTraceResponse> OpentelemetryExportTracesAsync(
            global::System.Collections.Generic.IList<global::G.OtelResourceSpan> resourceSpans,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}