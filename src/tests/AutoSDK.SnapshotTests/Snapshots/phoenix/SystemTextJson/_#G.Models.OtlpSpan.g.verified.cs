//HintName: G.Models.OtlpSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpSpan
    {
        /// <summary>
        /// attributes is a collection of key/value pairs. Note, global attributes like server name can be set using the resource API. Examples of attributes:<br/>
        ///     "/http/user_agent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36"<br/>
        ///     "/http/server_latency": 300<br/>
        ///     "example.com/myattribute": true<br/>
        ///     "example.com/score": 10.239<br/>
        /// The OpenTelemetry API specification further restricts the allowed value types:<br/>
        /// https://github.com/open-telemetry/opentelemetry-specification/blob/main/specification/common/README.md#attribute<br/>
        /// Attribute keys MUST be unique (it is not allowed to have more than one attribute with the same key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? Attributes { get; set; }

        /// <summary>
        /// dropped_attributes_count is the number of attributes that were discarded. Attributes can be discarded because their keys are too long or because there are too many attributes. If this value is 0, then no attributes were dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dropped_attributes_count")]
        public int? DroppedAttributesCount { get; set; }

        /// <summary>
        /// dropped_events_count is the number of dropped events. If the value is 0, then no events were dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dropped_events_count")]
        public int? DroppedEventsCount { get; set; }

        /// <summary>
        /// dropped_links_count is the number of dropped links after the maximum size was enforced. If this value is 0, then no links were dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dropped_links_count")]
        public int? DroppedLinksCount { get; set; }

        /// <summary>
        /// end_time_unix_nano is the end time of the span. On the client side, this is the time kept by the local machine where the span execution ends. On the server side, this is the time when the server application handler stops running.<br/>
        /// Value is UNIX Epoch time in nanoseconds since 00:00:00 UTC on 1 January 1970.<br/>
        /// This field is semantically required and it is expected that end_time &gt;= start_time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_unix_nano")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<long?, string, object>))]
        public global::G.AnyOf<long?, string, object>? EndTimeUnixNano { get; set; }

        /// <summary>
        /// events is a collection of Event items. A span with no events is valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.OtlpEvent>? Events { get; set; }

        /// <summary>
        /// Flags, a bit field.<br/>
        /// Bits 0-7 (8 least significant bits) are the trace flags as defined in W3C Trace Context specification. To read the 8-bit W3C trace flag, use `flags &amp; SPAN_FLAGS_TRACE_FLAGS_MASK`.<br/>
        /// See https://www.w3.org/TR/trace-context-2/#trace-flags for the flag definitions.<br/>
        /// Bits 8 and 9 represent the 3 states of whether a span's parent is remote. The states are (unknown, is not remote, is remote).<br/>
        /// To read whether the value is known, use `(flags &amp; SPAN_FLAGS_CONTEXT_HAS_IS_REMOTE_MASK) != 0`.<br/>
        /// To read whether the span is remote, use `(flags &amp; SPAN_FLAGS_CONTEXT_IS_REMOTE_MASK) != 0`.<br/>
        /// When creating span messages, if the message is logically forwarded from another source with an equivalent flags fields (i.e., usually another OTLP span message), the field SHOULD be copied as-is. If creating from a source that does not have an equivalent flags field (such as a runtime representation of an OpenTelemetry span), the high 22 bits MUST be set to zero.<br/>
        /// Readers MUST NOT assume that bits 10-31 (22 most significant bits) will be zero.<br/>
        /// [Optional].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public int? Flags { get; set; }

        /// <summary>
        /// Distinguishes between spans generated in a particular context. For example, two spans with the same name may be distinguished using `CLIENT` (caller) and `SERVER` (callee) to identify queueing latency associated with the span.<br/>
        /// Default Value: SPAN_KIND_INTERNAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.OtlpKind?, int?, object>))]
        public global::G.AnyOf<global::G.OtlpKind?, int?, object>? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public object? Links { get; set; }

        /// <summary>
        /// A description of the span's operation.<br/>
        /// For example, the name can be a qualified method name or a file name and a line number where the operation is called. A best practice is to use the same display name at the same call point in an application. This makes it easier to correlate spans in different traces.<br/>
        /// This field is semantically required to be set to non-empty string. Empty value is equivalent to an unknown span name.<br/>
        /// This field is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The `span_id` of this span's parent span. If this is a root span, then this field must be empty. The ID is an 8-byte array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_span_id")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// A unique identifier for a span within a trace, assigned when the span is created. The ID is an 8-byte array. An ID with all zeroes OR of length other than 8 bytes is considered invalid (empty string in OTLP/JSON is zero-length and thus is also invalid).<br/>
        /// This field is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// start_time_unix_nano is the start time of the span. On the client side, this is the time kept by the local machine where the span execution starts. On the server side, this is the time when the server's application handler starts running.<br/>
        /// Value is UNIX Epoch time in nanoseconds since 00:00:00 UTC on 1 January 1970.<br/>
        /// This field is semantically required and it is expected that end_time &gt;= start_time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_unix_nano")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<long?, string, object>))]
        public global::G.AnyOf<long?, string, object>? StartTimeUnixNano { get; set; }

        /// <summary>
        /// An optional final status for this span. Semantically when Status isn't set, it means span's status code is unset, i.e. assume STATUS_CODE_UNSET (code = 0).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::G.OtlpStatus? Status { get; set; }

        /// <summary>
        /// A unique identifier for a trace. All spans from the same trace share the same `trace_id`. The ID is a 16-byte array. An ID with all zeroes OR of length other than 16 bytes is considered invalid (empty string in OTLP/JSON is zero-length and thus is also invalid).<br/>
        /// This field is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// trace_state conveys information about request position in multiple distributed tracing graphs. It is a trace_state in w3c-trace-context format: https://www.w3.org/TR/trace-context/#tracestate-header<br/>
        /// See also https://github.com/w3c/distributed-tracing for more details about this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_state")]
        public string? TraceState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpan" /> class.
        /// </summary>
        /// <param name="attributes">
        /// attributes is a collection of key/value pairs. Note, global attributes like server name can be set using the resource API. Examples of attributes:<br/>
        ///     "/http/user_agent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36"<br/>
        ///     "/http/server_latency": 300<br/>
        ///     "example.com/myattribute": true<br/>
        ///     "example.com/score": 10.239<br/>
        /// The OpenTelemetry API specification further restricts the allowed value types:<br/>
        /// https://github.com/open-telemetry/opentelemetry-specification/blob/main/specification/common/README.md#attribute<br/>
        /// Attribute keys MUST be unique (it is not allowed to have more than one attribute with the same key).
        /// </param>
        /// <param name="droppedAttributesCount">
        /// dropped_attributes_count is the number of attributes that were discarded. Attributes can be discarded because their keys are too long or because there are too many attributes. If this value is 0, then no attributes were dropped.
        /// </param>
        /// <param name="droppedEventsCount">
        /// dropped_events_count is the number of dropped events. If the value is 0, then no events were dropped.
        /// </param>
        /// <param name="droppedLinksCount">
        /// dropped_links_count is the number of dropped links after the maximum size was enforced. If this value is 0, then no links were dropped.
        /// </param>
        /// <param name="endTimeUnixNano">
        /// end_time_unix_nano is the end time of the span. On the client side, this is the time kept by the local machine where the span execution ends. On the server side, this is the time when the server application handler stops running.<br/>
        /// Value is UNIX Epoch time in nanoseconds since 00:00:00 UTC on 1 January 1970.<br/>
        /// This field is semantically required and it is expected that end_time &gt;= start_time.
        /// </param>
        /// <param name="events">
        /// events is a collection of Event items. A span with no events is valid.
        /// </param>
        /// <param name="flags">
        /// Flags, a bit field.<br/>
        /// Bits 0-7 (8 least significant bits) are the trace flags as defined in W3C Trace Context specification. To read the 8-bit W3C trace flag, use `flags &amp; SPAN_FLAGS_TRACE_FLAGS_MASK`.<br/>
        /// See https://www.w3.org/TR/trace-context-2/#trace-flags for the flag definitions.<br/>
        /// Bits 8 and 9 represent the 3 states of whether a span's parent is remote. The states are (unknown, is not remote, is remote).<br/>
        /// To read whether the value is known, use `(flags &amp; SPAN_FLAGS_CONTEXT_HAS_IS_REMOTE_MASK) != 0`.<br/>
        /// To read whether the span is remote, use `(flags &amp; SPAN_FLAGS_CONTEXT_IS_REMOTE_MASK) != 0`.<br/>
        /// When creating span messages, if the message is logically forwarded from another source with an equivalent flags fields (i.e., usually another OTLP span message), the field SHOULD be copied as-is. If creating from a source that does not have an equivalent flags field (such as a runtime representation of an OpenTelemetry span), the high 22 bits MUST be set to zero.<br/>
        /// Readers MUST NOT assume that bits 10-31 (22 most significant bits) will be zero.<br/>
        /// [Optional].
        /// </param>
        /// <param name="kind">
        /// Distinguishes between spans generated in a particular context. For example, two spans with the same name may be distinguished using `CLIENT` (caller) and `SERVER` (callee) to identify queueing latency associated with the span.<br/>
        /// Default Value: SPAN_KIND_INTERNAL
        /// </param>
        /// <param name="links"></param>
        /// <param name="name">
        /// A description of the span's operation.<br/>
        /// For example, the name can be a qualified method name or a file name and a line number where the operation is called. A best practice is to use the same display name at the same call point in an application. This makes it easier to correlate spans in different traces.<br/>
        /// This field is semantically required to be set to non-empty string. Empty value is equivalent to an unknown span name.<br/>
        /// This field is required.
        /// </param>
        /// <param name="parentSpanId">
        /// The `span_id` of this span's parent span. If this is a root span, then this field must be empty. The ID is an 8-byte array.
        /// </param>
        /// <param name="spanId">
        /// A unique identifier for a span within a trace, assigned when the span is created. The ID is an 8-byte array. An ID with all zeroes OR of length other than 8 bytes is considered invalid (empty string in OTLP/JSON is zero-length and thus is also invalid).<br/>
        /// This field is required.
        /// </param>
        /// <param name="startTimeUnixNano">
        /// start_time_unix_nano is the start time of the span. On the client side, this is the time kept by the local machine where the span execution starts. On the server side, this is the time when the server's application handler starts running.<br/>
        /// Value is UNIX Epoch time in nanoseconds since 00:00:00 UTC on 1 January 1970.<br/>
        /// This field is semantically required and it is expected that end_time &gt;= start_time.
        /// </param>
        /// <param name="status">
        /// An optional final status for this span. Semantically when Status isn't set, it means span's status code is unset, i.e. assume STATUS_CODE_UNSET (code = 0).
        /// </param>
        /// <param name="traceId">
        /// A unique identifier for a trace. All spans from the same trace share the same `trace_id`. The ID is a 16-byte array. An ID with all zeroes OR of length other than 16 bytes is considered invalid (empty string in OTLP/JSON is zero-length and thus is also invalid).<br/>
        /// This field is required.
        /// </param>
        /// <param name="traceState">
        /// trace_state conveys information about request position in multiple distributed tracing graphs. It is a trace_state in w3c-trace-context format: https://www.w3.org/TR/trace-context/#tracestate-header<br/>
        /// See also https://github.com/w3c/distributed-tracing for more details about this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtlpSpan(
            global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? attributes,
            int? droppedAttributesCount,
            int? droppedEventsCount,
            int? droppedLinksCount,
            global::G.AnyOf<long?, string, object>? endTimeUnixNano,
            global::System.Collections.Generic.IList<global::G.OtlpEvent>? events,
            int? flags,
            global::G.AnyOf<global::G.OtlpKind?, int?, object>? kind,
            object? links,
            string? name,
            string? parentSpanId,
            string? spanId,
            global::G.AnyOf<long?, string, object>? startTimeUnixNano,
            global::G.OtlpStatus? status,
            string? traceId,
            string? traceState)
        {
            this.Attributes = attributes;
            this.DroppedAttributesCount = droppedAttributesCount;
            this.DroppedEventsCount = droppedEventsCount;
            this.DroppedLinksCount = droppedLinksCount;
            this.EndTimeUnixNano = endTimeUnixNano;
            this.Events = events;
            this.Flags = flags;
            this.Kind = kind;
            this.Links = links;
            this.Name = name;
            this.ParentSpanId = parentSpanId;
            this.SpanId = spanId;
            this.StartTimeUnixNano = startTimeUnixNano;
            this.Status = status;
            this.TraceId = traceId;
            this.TraceState = traceState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpan" /> class.
        /// </summary>
        public OtlpSpan()
        {
        }
    }
}