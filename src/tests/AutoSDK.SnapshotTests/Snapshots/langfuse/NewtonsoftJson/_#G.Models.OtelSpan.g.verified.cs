//HintName: G.Models.OtelSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Individual span representing a unit of work or operation
    /// </summary>
    public sealed partial class OtelSpan
    {
        /// <summary>
        /// Trace ID (16 bytes, hex-encoded string in JSON or Buffer in binary)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceId")]
        public object? TraceId { get; set; }

        /// <summary>
        /// Span ID (8 bytes, hex-encoded string in JSON or Buffer in binary)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spanId")]
        public object? SpanId { get; set; }

        /// <summary>
        /// Parent span ID if this is a child span
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parentSpanId")]
        public object? ParentSpanId { get; set; }

        /// <summary>
        /// Span name describing the operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Span kind (1=INTERNAL, 2=SERVER, 3=CLIENT, 4=PRODUCER, 5=CONSUMER)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public int? Kind { get; set; }

        /// <summary>
        /// Start time in nanoseconds since Unix epoch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTimeUnixNano")]
        public object? StartTimeUnixNano { get; set; }

        /// <summary>
        /// End time in nanoseconds since Unix epoch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTimeUnixNano")]
        public object? EndTimeUnixNano { get; set; }

        /// <summary>
        /// Span attributes including Langfuse-specific attributes (langfuse.observation.*)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtelAttribute>? Attributes { get; set; }

        /// <summary>
        /// Span status object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public object? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelSpan" /> class.
        /// </summary>
        /// <param name="traceId">
        /// Trace ID (16 bytes, hex-encoded string in JSON or Buffer in binary)
        /// </param>
        /// <param name="spanId">
        /// Span ID (8 bytes, hex-encoded string in JSON or Buffer in binary)
        /// </param>
        /// <param name="parentSpanId">
        /// Parent span ID if this is a child span
        /// </param>
        /// <param name="name">
        /// Span name describing the operation
        /// </param>
        /// <param name="kind">
        /// Span kind (1=INTERNAL, 2=SERVER, 3=CLIENT, 4=PRODUCER, 5=CONSUMER)
        /// </param>
        /// <param name="startTimeUnixNano">
        /// Start time in nanoseconds since Unix epoch
        /// </param>
        /// <param name="endTimeUnixNano">
        /// End time in nanoseconds since Unix epoch
        /// </param>
        /// <param name="attributes">
        /// Span attributes including Langfuse-specific attributes (langfuse.observation.*)
        /// </param>
        /// <param name="status">
        /// Span status object
        /// </param>
        public OtelSpan(
            object? traceId,
            object? spanId,
            object? parentSpanId,
            string? name,
            int? kind,
            object? startTimeUnixNano,
            object? endTimeUnixNano,
            global::System.Collections.Generic.IList<global::G.OtelAttribute>? attributes,
            object? status)
        {
            this.TraceId = traceId;
            this.SpanId = spanId;
            this.ParentSpanId = parentSpanId;
            this.Name = name;
            this.Kind = kind;
            this.StartTimeUnixNano = startTimeUnixNano;
            this.EndTimeUnixNano = endTimeUnixNano;
            this.Attributes = attributes;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtelSpan" /> class.
        /// </summary>
        public OtelSpan()
        {
        }
    }
}