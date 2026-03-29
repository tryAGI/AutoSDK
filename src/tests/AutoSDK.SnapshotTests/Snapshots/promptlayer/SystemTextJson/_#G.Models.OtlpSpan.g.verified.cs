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
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// Hex-encoded span ID (16 hex characters / 8 bytes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// Hex-encoded parent span ID. Empty or omitted for root spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentSpanId")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// The name of the span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Span kind: 0=UNSPECIFIED, 1=INTERNAL, 2=SERVER, 3=CLIENT, 4=PRODUCER, 5=CONSUMER.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public int? Kind { get; set; }

        /// <summary>
        /// Start time in nanoseconds since Unix epoch, encoded as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeUnixNano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTimeUnixNano { get; set; }

        /// <summary>
        /// End time in nanoseconds since Unix epoch, encoded as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeUnixNano")]
        public string? EndTimeUnixNano { get; set; }

        /// <summary>
        /// Span attributes as key-value pairs. GenAI semantic convention attributes (e.g. `gen_ai.request.model`, `gen_ai.usage.input_tokens`) are automatically extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? Attributes { get; set; }

        /// <summary>
        /// Span status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::G.OtlpSpanStatus? Status { get; set; }

        /// <summary>
        /// Span events (e.g. exceptions).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.OtlpSpanEvent>? Events { get; set; }

        /// <summary>
        /// Links to other spans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<global::G.OtlpSpanLink>? Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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