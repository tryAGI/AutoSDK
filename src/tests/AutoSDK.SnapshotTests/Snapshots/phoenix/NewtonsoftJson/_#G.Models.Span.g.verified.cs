//HintName: G.Models.Span.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Span
    {
        /// <summary>
        /// Span Global ID, distinct from the OpenTelemetry span ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the span operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Span context containing trace_id and span_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpanContext Context { get; set; } = default!;

        /// <summary>
        /// Type of work that the span encapsulates
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_kind", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanKind { get; set; } = default!;

        /// <summary>
        /// OpenTelemetry span ID of the parent span
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Start time of the span (must be timezone-aware)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// End time of the span (must be timezone-aware)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// Status code of the span
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusCode { get; set; } = default!;

        /// <summary>
        /// Status message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Span attributes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Span events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.SpanEvent>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Span" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the span operation
        /// </param>
        /// <param name="context">
        /// Span context containing trace_id and span_id
        /// </param>
        /// <param name="spanKind">
        /// Type of work that the span encapsulates
        /// </param>
        /// <param name="startTime">
        /// Start time of the span (must be timezone-aware)
        /// </param>
        /// <param name="endTime">
        /// End time of the span (must be timezone-aware)
        /// </param>
        /// <param name="statusCode">
        /// Status code of the span
        /// </param>
        /// <param name="id">
        /// Span Global ID, distinct from the OpenTelemetry span ID
        /// </param>
        /// <param name="parentId">
        /// OpenTelemetry span ID of the parent span
        /// </param>
        /// <param name="statusMessage">
        /// Status message
        /// </param>
        /// <param name="attributes">
        /// Span attributes
        /// </param>
        /// <param name="events">
        /// Span events
        /// </param>
        public Span(
            string name,
            global::G.SpanContext context,
            string spanKind,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string statusCode,
            string? id,
            string? parentId,
            string? statusMessage,
            object? attributes,
            global::System.Collections.Generic.IList<global::G.SpanEvent>? events)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.SpanKind = spanKind ?? throw new global::System.ArgumentNullException(nameof(spanKind));
            this.ParentId = parentId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.StatusCode = statusCode ?? throw new global::System.ArgumentNullException(nameof(statusCode));
            this.StatusMessage = statusMessage;
            this.Attributes = attributes;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Span" /> class.
        /// </summary>
        public Span()
        {
        }
    }
}