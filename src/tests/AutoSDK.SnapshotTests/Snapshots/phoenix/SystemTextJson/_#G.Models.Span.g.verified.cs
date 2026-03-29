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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the span operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Span context containing trace_id and span_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpanContext Context { get; set; }

        /// <summary>
        /// Type of work that the span encapsulates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanKind { get; set; }

        /// <summary>
        /// OpenTelemetry span ID of the parent span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Start time of the span (must be timezone-aware)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// End time of the span (must be timezone-aware)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Status code of the span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusCode { get; set; }

        /// <summary>
        /// Status message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Span attributes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Span events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.SpanEvent>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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