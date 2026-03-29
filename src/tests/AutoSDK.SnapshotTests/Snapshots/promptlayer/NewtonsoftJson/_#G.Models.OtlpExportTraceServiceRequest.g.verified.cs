//HintName: G.Models.OtlpExportTraceServiceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An OTLP ExportTraceServiceRequest in JSON encoding. See the [OTLP specification](https://opentelemetry.io/docs/specs/otlp/#otlphttp-request) for the full schema.
    /// </summary>
    public sealed partial class OtlpExportTraceServiceRequest
    {
        /// <summary>
        /// An array of ResourceSpans. Each element describes spans from a single instrumented resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceSpans")]
        public global::System.Collections.Generic.IList<global::G.OtlpExportTraceServiceRequestResourceSpan>? ResourceSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequest" /> class.
        /// </summary>
        /// <param name="resourceSpans">
        /// An array of ResourceSpans. Each element describes spans from a single instrumented resource.
        /// </param>
        public OtlpExportTraceServiceRequest(
            global::System.Collections.Generic.IList<global::G.OtlpExportTraceServiceRequestResourceSpan>? resourceSpans)
        {
            this.ResourceSpans = resourceSpans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpExportTraceServiceRequest" /> class.
        /// </summary>
        public OtlpExportTraceServiceRequest()
        {
        }
    }
}