//HintName: G.IOtlpClient.IngestOtlpTracesWithProtobufAsBytes.g.cs
#nullable enable

namespace G
{
    public partial interface IOtlpClient
    {
        /// <summary>
        /// Ingest Traces (OTLP)<br/>
        /// Ingest OpenTelemetry traces using the standard OTLP/HTTP protocol.<br/>
        /// This endpoint accepts an `ExportTraceServiceRequest` as defined by the [OpenTelemetry specification](https://opentelemetry.io/docs/specs/otel/protocol/otlp/#otlphttp). Spans carrying [GenAI semantic convention](https://opentelemetry.io/docs/specs/semconv/gen-ai/) attributes are automatically converted into PromptLayer request logs.<br/>
        /// Supported content types:<br/>
        /// - `application/x-protobuf` — binary protobuf encoding (recommended)<br/>
        /// - `application/json` — JSON encoding<br/>
        /// Gzip `Content-Encoding` is supported for both formats.<br/>
        /// Spans can include `promptlayer.prompt.name` (or `promptlayer.prompt.id`) and `promptlayer.prompt.version` (or `promptlayer.prompt.label`) attributes to link the generated request log to an existing prompt template in your workspace.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> IngestOtlpTracesWithProtobufAsBytesAsync(
            global::G.IngestOtlpTracesContentType contentType,

            byte[] request,
            global::G.IngestOtlpTracesContentEncoding? contentEncoding = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest Traces (OTLP)<br/>
        /// Ingest OpenTelemetry traces using the standard OTLP/HTTP protocol.<br/>
        /// This endpoint accepts an `ExportTraceServiceRequest` as defined by the [OpenTelemetry specification](https://opentelemetry.io/docs/specs/otel/protocol/otlp/#otlphttp). Spans carrying [GenAI semantic convention](https://opentelemetry.io/docs/specs/semconv/gen-ai/) attributes are automatically converted into PromptLayer request logs.<br/>
        /// Supported content types:<br/>
        /// - `application/x-protobuf` — binary protobuf encoding (recommended)<br/>
        /// - `application/json` — JSON encoding<br/>
        /// Gzip `Content-Encoding` is supported for both formats.<br/>
        /// Spans can include `promptlayer.prompt.name` (or `promptlayer.prompt.id`) and `promptlayer.prompt.version` (or `promptlayer.prompt.label`) attributes to link the generated request log to an existing prompt template in your workspace.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> IngestOtlpTracesWithProtobufAsBytesAsStreamAsync(
            global::G.IngestOtlpTracesContentType contentType,

            byte[] request,
            global::G.IngestOtlpTracesContentEncoding? contentEncoding = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest Traces (OTLP)<br/>
        /// Ingest OpenTelemetry traces using the standard OTLP/HTTP protocol.<br/>
        /// This endpoint accepts an `ExportTraceServiceRequest` as defined by the [OpenTelemetry specification](https://opentelemetry.io/docs/specs/otel/protocol/otlp/#otlphttp). Spans carrying [GenAI semantic convention](https://opentelemetry.io/docs/specs/semconv/gen-ai/) attributes are automatically converted into PromptLayer request logs.<br/>
        /// Supported content types:<br/>
        /// - `application/x-protobuf` — binary protobuf encoding (recommended)<br/>
        /// - `application/json` — JSON encoding<br/>
        /// Gzip `Content-Encoding` is supported for both formats.<br/>
        /// Spans can include `promptlayer.prompt.name` (or `promptlayer.prompt.id`) and `promptlayer.prompt.version` (or `promptlayer.prompt.label`) attributes to link the generated request log to an existing prompt template in your workspace.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> IngestOtlpTracesWithProtobufAsBytesAsResponseAsync(
            global::G.IngestOtlpTracesContentType contentType,

            byte[] request,
            global::G.IngestOtlpTracesContentEncoding? contentEncoding = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}