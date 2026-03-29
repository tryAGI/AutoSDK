//HintName: G.Models.OtlpSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single OTLP span. See the [OTLP Span spec](https://opentelemetry.io/docs/specs/otel/trace/api/#span) for full details.
    /// </summary>
    public sealed partial class OtlpSpan
    {
        /// <summary>
        /// Hex-encoded trace ID (32 hex characters / 16 bytes).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// Hex-encoded span ID (16 hex characters / 8 bytes).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spanId", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanId { get; set; } = default!;

        /// <summary>
        /// Hex-encoded parent span ID. Empty or omitted for root spans.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parentSpanId")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// The name of the span.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Span kind: 0=UNSPECIFIED, 1=INTERNAL, 2=SERVER, 3=CLIENT, 4=PRODUCER, 5=CONSUMER.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public int? Kind { get; set; }

        /// <summary>
        /// Start time in nanoseconds since Unix epoch, encoded as a string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTimeUnixNano", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartTimeUnixNano { get; set; } = default!;

        /// <summary>
        /// End time in nanoseconds since Unix epoch, encoded as a string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTimeUnixNano")]
        public string? EndTimeUnixNano { get; set; }

        /// <summary>
        /// Span attributes as key-value pairs. GenAI semantic convention attributes (e.g. `gen_ai.request.model`, `gen_ai.usage.input_tokens`) are automatically extracted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? Attributes { get; set; }

        /// <summary>
        /// Span status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.OtlpSpanStatus? Status { get; set; }

        /// <summary>
        /// Span events (e.g. exceptions).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.OtlpSpanEvent>? Events { get; set; }

        /// <summary>
        /// Links to other spans.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::System.Collections.Generic.IList<global::G.OtlpSpanLink>? Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpan" /> class.
        /// </summary>
        /// <param name="traceId">
        /// Hex-encoded trace ID (32 hex characters / 16 bytes).
        /// </param>
        /// <param name="spanId">
        /// Hex-encoded span ID (16 hex characters / 8 bytes).
        /// </param>
        /// <param name="name">
        /// The name of the span.
        /// </param>
        /// <param name="startTimeUnixNano">
        /// Start time in nanoseconds since Unix epoch, encoded as a string.
        /// </param>
        /// <param name="parentSpanId">
        /// Hex-encoded parent span ID. Empty or omitted for root spans.
        /// </param>
        /// <param name="kind">
        /// Span kind: 0=UNSPECIFIED, 1=INTERNAL, 2=SERVER, 3=CLIENT, 4=PRODUCER, 5=CONSUMER.
        /// </param>
        /// <param name="endTimeUnixNano">
        /// End time in nanoseconds since Unix epoch, encoded as a string.
        /// </param>
        /// <param name="attributes">
        /// Span attributes as key-value pairs. GenAI semantic convention attributes (e.g. `gen_ai.request.model`, `gen_ai.usage.input_tokens`) are automatically extracted.
        /// </param>
        /// <param name="status">
        /// Span status.
        /// </param>
        /// <param name="events">
        /// Span events (e.g. exceptions).
        /// </param>
        /// <param name="links">
        /// Links to other spans.
        /// </param>
        public OtlpSpan(
            string traceId,
            string spanId,
            string name,
            string startTimeUnixNano,
            string? parentSpanId,
            int? kind,
            string? endTimeUnixNano,
            global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? attributes,
            global::G.OtlpSpanStatus? status,
            global::System.Collections.Generic.IList<global::G.OtlpSpanEvent>? events,
            global::System.Collections.Generic.IList<global::G.OtlpSpanLink>? links)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.ParentSpanId = parentSpanId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.StartTimeUnixNano = startTimeUnixNano ?? throw new global::System.ArgumentNullException(nameof(startTimeUnixNano));
            this.EndTimeUnixNano = endTimeUnixNano;
            this.Attributes = attributes;
            this.Status = status;
            this.Events = events;
            this.Links = links;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpan" /> class.
        /// </summary>
        public OtlpSpan()
        {
        }
    }
}